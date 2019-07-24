using INGECO.DriversControl.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace INGECO.DriversControl
{
    public partial class FrmMain : Form
    {
        #region Constructor

        public FrmMain()
        {
            InitializeComponent();
            DriverDataProviderContainer.InitializeWithDatabaseProvider();
            LoadDrivers();
        }

        #endregion

        #region Methods

        /// <summary>
        /// Loads all the drivers registered in the system.
        /// </summary>
        private async void LoadDrivers()
        {
            btnRefreshDrivers.Enabled = false;
            var selectedIndex = -1;
            if (lvDriversList.SelectedIndices.Count > 0)
            {
                selectedIndex = lvDriversList.SelectedIndices[0];
            }
            ClearTabs();
            SetListViewImageLists();
            lvDriversList.SuspendLayout();
            lvDriversList.Items.Clear();
            var drivers = await Task.Run(() => DriverDataProviderContainer.Controller.GetDrivers());
            foreach (var driver in drivers)
            {
                var item = new ListViewItem(new string[] { driver.FullName, driver.Position, driver.PersonalId, driver.Description })
                {
                    ImageIndex = driver.HasExpiredParameters ? 2 : driver.GetIfAnyParameterExpireDateIsInPeriod(Configuration.ExpireWarningForLicense, Configuration.ExpireWarningForRequalification, Configuration.ExpireWarningForMedicalExam) ? 1 : 0,
                    Tag = driver
                };
                _ = lvDriversList.Items.Add(item);
            }
            if (lvDriversList.Items.Count > 0 && selectedIndex >= 0 && selectedIndex < lvDriversList.Items.Count)
            {
                lvDriversList.SelectedItems.Clear();
                lvDriversList.Items[selectedIndex].Selected = true;
            }
            lvDriversList.ResumeLayout();
            btnRefreshDrivers.Enabled = true;
        }

        /// <summary>
        /// Sets the image list that will be used in the ListView.
        /// </summary>
        private void SetListViewImageLists()
        {
            var imageList = new ImageList();
            imageList.Images.Add(Properties.Resources.ok);
            imageList.Images.Add(Properties.Resources.warning);
            imageList.Images.Add(Properties.Resources.error);
            lvDriversList.LargeImageList = imageList;
            lvDriversList.SmallImageList = imageList;
            tabControl1.ImageList = imageList;
        }

        /// <summary>
        /// Returns the current selected driver in the ListView.
        /// </summary>
        /// <returns></returns>
        private Driver GetSelectedDriver()
        {
            return lvDriversList.SelectedItems[0].Tag as Driver;
        }

        /// <summary>
        /// Show the driver info in the form.
        /// </summary>
        /// <param name="driver"></param>
        private void ShowDriverInfo(Driver driver)
        {
            UpdateInfoTab(driver);
            UpdateLicenseTab(driver);
            UpdateRequalificationTab(driver);
            UpdateMedicalExamsTab(driver);
        }

        /// <summary>
        /// Update the Medical Exam tab with the data of the specified driver.
        /// </summary>
        /// <param name="driver">The driver to show information.</param>
        private void UpdateMedicalExamsTab(Driver driver)
        {
            if (driver.MedicalExams?.Count > 0)
            {
                dgvMedicalExamActive.SuspendLayout();
                dgvMedicalExamActive.Rows.Clear();
                foreach (var me in driver.MedicalExams)
                {
                    var added = dgvMedicalExamActive.Rows.Add
                        (
                            me.IsExpired ?
                                Properties.Resources.error
                                : me.GetIfExpirationDateIsInPeriod(Configuration.ExpireWarningForMedicalExam)
                                ? Properties.Resources.warning
                                : Properties.Resources.ok,
                            me.Created.ToShortDateString(),
                            me.Type.GetShowText(),
                            me.DateOfMaking.ToShortDateString(),
                            me.Expires.ToShortDateString(),
                            me.Result.GetShowText(),
                            me.Description
                            );
                    dgvMedicalExamActive.Rows[added].Tag = me;
                }
                TpMedicalExams.ImageIndex = driver.MedicalExams.Count(me => me.IsExpired) > 0 ? 2 : driver.MedicalExams.Count(me => me.GetIfExpirationDateIsInPeriod(Configuration.ExpireWarningForMedicalExam)) > 0 ? 1 : 0;
                dgvMedicalExamHistorical.SuspendLayout();
                dgvMedicalExamHistorical.Rows.Clear();
                var medicalExamsHistory = DriverDataProviderContainer.Controller.GetDriverMedicalExamsHistory(driver);
                foreach (var mh in medicalExamsHistory)
                {
                    var added = dgvMedicalExamHistorical.Rows.Add(mh.Created.ToShortDateString(), mh.Type.GetShowText(), mh.DateOfMaking.ToShortDateString(), mh.Expires.ToShortDateString(), mh.Result.GetShowText(), mh.Description);
                    dgvMedicalExamHistorical.Rows[added].Tag = mh;
                }
                dgvRequalificationHistorical.ResumeLayout();
            }
            else
            {
                TpMedicalExams.ImageIndex = 2;
                ClearMedicalExamTab();
            }
        }

        /// <summary>
        /// Update the Requalification tab with the data of the specified driver.
        /// </summary>
        /// <param name="driver">The driver to show information.</param>
        private void UpdateRequalificationTab(Driver driver)
        {
            if (driver.Requalificaiton != null)
            {
                lbRequalificationCreationDate.Text = driver.Requalificaiton.Created.ToShortDateString();
                txtRequalificationPage.Text = driver.Requalificaiton.Page;
                txtRequalificationVolume.Text = driver.Requalificaiton.Volume;
                dtRequalificationDateOfMaking.Value = driver.Requalificaiton.DateOfMaking;
                dtRequalificationExpires.Value = driver.Requalificaiton.Expires;
                txtRequalificationDescription.Text = driver.Requalificaiton.Description;
                TpRequalification.ImageIndex = driver.Requalificaiton.IsExpired ? 2 : driver.Requalificaiton.GetIfExpirationDateIsInPeriod(Configuration.ExpireWarningForRequalification) ? 1 : 0;
                dgvRequalificationHistorical.SuspendLayout();
                dgvRequalificationHistorical.Rows.Clear();
                var requalificationsHistory = DriverDataProviderContainer.Controller.GetDriverRequalificationHistory(driver);
                foreach (var req in requalificationsHistory)
                {
                    var added = dgvRequalificationHistorical.Rows.Add(req.Created.ToShortDateString(), req.DateOfMaking, req.Expires, req.Volume, req.Page, req.Description);
                    dgvRequalificationHistorical.Rows[added].Tag = req;
                }
                dgvRequalificationHistorical.ResumeLayout();
            }
            else
            {
                TpRequalification.ImageIndex = 2;
                ClearRequalificationTab();
            }
        }

        /// <summary>
        /// Update the Driver's License tab with the data of the specified driver.
        /// </summary>
        /// <param name="driver"></param>
        private void UpdateLicenseTab(Driver driver)
        {
            if (driver.DriverLicense != null)
            {
                lbLicenseCreationDate.Text = driver.DriverLicense.Created.ToShortDateString();
                txtLicenseNumber.Text = driver.DriverLicense.Number;
                txtLicenseCategory.Text = driver.DriverLicense.Category;
                dtLicenseExpires.Value = driver.DriverLicense.Expires;
                txtDriverLicenseDescription.Text = driver.DriverLicense.Description;
                TpDriverLicense.ImageIndex = driver.DriverLicense.IsExpired ? 2 : driver.DriverLicense.GetIfExpirationDateIsInPeriod(Configuration.ExpireWarningForLicense) ? 1 : 0;
                dgvHistoricLicenses.SuspendLayout();
                dgvHistoricLicenses.Rows.Clear();
                var licensesHistory = DriverDataProviderContainer.Controller.GetDriverLicenseHistory(driver);
                foreach (var lh in licensesHistory)
                {
                    var added = dgvHistoricLicenses.Rows.Add(lh.Created.ToShortDateString(), lh.Number, lh.Category, lh.DateOfMaking, lh.Expires, lh.Description);
                    dgvHistoricLicenses.Rows[added].Tag = lh;
                }
                dgvHistoricLicenses.ResumeLayout();
            }
            else
            {
                TpDriverLicense.ImageIndex = 2;
                ClearLicenseTab();
            }
        }

        /// <summary>
        /// Update the General Info tab with the data of the specified driver.
        /// </summary>
        /// <param name="driver"></param>
        private void UpdateInfoTab(Driver driver)
        {
            txtFullname.Text = driver.FullName;
            txtPosition.Text = driver.Position;
            txtPersonalId.Text = driver.PersonalId;
            txtDescription.Text = driver.Description;
        }

        /// <summary>
        /// Clears the displayed data in all the tabs.
        /// </summary>
        private void ClearTabs()
        {
            ClearLicenseTab();
            ClearRequalificationTab();
            ClearMedicalExamTab();
        }

        /// <summary>
        /// Clears the displayed data from the Medical Exam tab.
        /// </summary>
        private void ClearMedicalExamTab()
        {
            dgvMedicalExamActive.Rows.Clear();
            dgvMedicalExamHistorical.Rows.Clear();
        }

        /// <summary>
        /// Clears the displayed data from the Requalification tab.
        /// </summary>
        private void ClearRequalificationTab()
        {
            txtRequalificationPage.Text = string.Empty;
            txtRequalificationVolume.Text = string.Empty;
            dtRequalificationDateOfMaking.Value = DateTime.Now;
            dtRequalificationExpires.Value = DateTime.Now;
            txtRequalificationDescription.Text = string.Empty;
            dgvRequalificationHistorical.Rows.Clear();
        }

        /// <summary>
        /// Clears the data from the Driver's License tab.
        /// </summary>
        private void ClearLicenseTab()
        {
            lbLicenseCreationDate.Text = string.Empty;
            txtLicenseNumber.Text = string.Empty;
            txtLicenseCategory.Text = string.Empty;
            dtLicenseExpires.Value = DateTime.Now;
            txtDriverLicenseDescription.Text = string.Empty;
            dgvHistoricLicenses.Rows.Clear();
        }

        /// <summary>
        /// Open the new driver form.
        /// </summary>
        private void AddNewDriver()
        {
            var frm = new FrmNewDriver();
            frm.NewDriverAdded += d =>
            {
                if (DriverDataProviderContainer.Controller.AddNewDriver(d))
                {
                    LoadDrivers();
                    return true;
                }
                else
                {
                    return false;
                }
            };
            frm.Show();
        }

        /// <summary>
        /// Open the new driver's license form.
        /// </summary>
        private void DriverLicenseRenewal()
        {
            var frm = GetSelectedDriver().DriverLicense != null ? new FrmNewLicense(GetSelectedDriver().DriverLicense) : new FrmNewLicense();
            frm.NewLicenseForRenewal += l =>
            {
                if (DriverDataProviderContainer.Controller.RenewalLicense(GetSelectedDriver(), l))
                {
                    LoadDrivers();
                    return true;
                }
                else
                {
                    return false;
                }
            };
            _ = frm.ShowDialog();
        }

        /// <summary>
        /// Opens new requalification form.
        /// </summary>
        private void RequalificationRenewal()
        {
            var frm = new FrmNewRequalification();
            frm.NewRequalificaitonAdded += r =>
            {
                if (DriverDataProviderContainer.Controller.RenewalRequalification(GetSelectedDriver(), r))
                {
                    LoadDrivers();
                    return true;
                }
                else
                {
                    return false;
                }
            };
            _ = frm.ShowDialog();
        }

        #endregion

        #region Events subscribers

        private void LvDriversList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lvDriversList.SelectedItems.Count > 0)
            {
                lvDriversList.Enabled = false;
                ShowDriverInfo(GetSelectedDriver());
                lvDriversList.Enabled = true;
            }
        }

        private void BtnRefreshDrivers_Click(object sender, EventArgs e)
        {
            LoadDrivers();
        }

        private void BtnNewDriver_Click(object sender, EventArgs e)
        {
            AddNewDriver();
        }

        private void BtnLicenseRenewal_Click(object sender, EventArgs e)
        {
            DriverLicenseRenewal();
        }

        private void BtnRenewRequalification_Click(object sender, EventArgs e)
        {
            RequalificationRenewal();
        }

        #endregion
    }
}
