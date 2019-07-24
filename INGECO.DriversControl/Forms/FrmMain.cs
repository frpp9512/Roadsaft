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
        public FrmMain()
        {
            InitializeComponent();            
            DriversDatabaseController.Controller.InitializeDataConnection("localhost", "root", "", "ingeco_driverscontrol");
            LoadDrivers();
        }

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
            var drivers = await Task.Run(() => DriversDatabaseController.Controller.GetDrivers());
            foreach (var driver in drivers)
            {
                var item = new ListViewItem(new string[] { driver.FullName, driver.Position, driver.PersonalId })
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

        private void ClearTabs()
        {
            ClearLicenseTab();
            ClearRequalificationTab();
            ClearMedicalExamTab();
        }

        private void LvDriversList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lvDriversList.SelectedItems.Count > 0)
            {
                lvDriversList.Enabled = false;
                ShowDriverInfo(GetSelectedDriver());
                lvDriversList.Enabled = true;
            }
        }

        private Driver GetSelectedDriver()
        {
            return lvDriversList.SelectedItems[0].Tag as Driver;
        }

        private void ShowDriverInfo(Driver driver)
        {
            UpdateInfoTab(driver);
            UpdateLicenseTab(driver);
            UpdateRequalificationTab(driver);
            UpdateMedicalExamsTab(driver);
        }

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
                            me.Result.GetShowText());
                    dgvMedicalExamActive.Rows[added].Tag = me;
                }
                TpMedicalExams.ImageIndex = driver.MedicalExams.Count(me => me.IsExpired) > 0 ? 2 : driver.MedicalExams.Count(me => me.GetIfExpirationDateIsInPeriod(Configuration.ExpireWarningForMedicalExam)) > 0 ? 1 : 0;
                dgvMedicalExamHistorical.SuspendLayout();
                dgvMedicalExamHistorical.Rows.Clear();
                var medicalExamsHistory = DriversDatabaseController.Controller.GetDriverMedicalExamsHistory(driver);
                foreach (var mh in medicalExamsHistory)
                {
                    var added = dgvMedicalExamHistorical.Rows.Add(mh.Created.ToShortDateString(), mh.Type.GetShowText(), mh.DateOfMaking.ToShortDateString(), mh.Expires.ToShortDateString(), mh.Result.GetShowText());
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

        private void ClearMedicalExamTab()
        {
            dgvMedicalExamActive.Rows.Clear();
            dgvMedicalExamHistorical.Rows.Clear();
        }

        private void UpdateRequalificationTab(Driver driver)
        {
            if (driver.Requalificaiton != null)
            {
                lbRequalificationCreationDate.Text = driver.Requalificaiton.Created.ToShortDateString();
                txtRequalificationPage.Text = driver.Requalificaiton.Page;
                txtRequalificationVolume.Text = driver.Requalificaiton.Volume;
                dtRequalificationDateOfMaking.Value = driver.Requalificaiton.DateOfMaking;
                dtRequalificationExpires.Value = driver.Requalificaiton.Expires;
                TpRequalification.ImageIndex = driver.Requalificaiton.IsExpired ? 2 : driver.Requalificaiton.GetIfExpirationDateIsInPeriod(Configuration.ExpireWarningForRequalification) ? 1 : 0;
                dgvRequalificationHistorical.SuspendLayout();
                dgvRequalificationHistorical.Rows.Clear();
                var requalificationsHistory = DriversDatabaseController.Controller.GetDriverRequalificationHistory(driver);
                foreach (var req in requalificationsHistory)
                {
                    var added = dgvRequalificationHistorical.Rows.Add(req.Created.ToShortDateString(), req.DateOfMaking, req.Expires, req.Volume, req.Page);
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

        private void ClearRequalificationTab()
        {
            txtRequalificationPage.Text = string.Empty;
            txtRequalificationVolume.Text = string.Empty;
            dtRequalificationDateOfMaking.Value = DateTime.Now;
            dtRequalificationExpires.Value = DateTime.Now;            
            dgvRequalificationHistorical.Rows.Clear();
        }

        private void UpdateLicenseTab(Driver driver)
        {
            if (driver.DriverLicense != null)
            {
                lbLicenseCreationDate.Text = driver.DriverLicense.Created.ToShortDateString();
                txtLicenseNumber.Text = driver.DriverLicense.Number;
                txtLicenseCategory.Text = driver.DriverLicense.Category;
                dtLicenseExpires.Value = driver.DriverLicense.Expires;
                TpDriverLicense.ImageIndex = driver.DriverLicense.IsExpired ? 2 : driver.DriverLicense.GetIfExpirationDateIsInPeriod(Configuration.ExpireWarningForLicense) ? 1 : 0;
                dgvHistoricLicenses.SuspendLayout();
                dgvHistoricLicenses.Rows.Clear();
                var licensesHistory = DriversDatabaseController.Controller.GetDriverLicenseHistory(driver);
                foreach (var lh in licensesHistory)
                {
                    var added = dgvHistoricLicenses.Rows.Add(lh.Created.ToShortDateString(), lh.Number, lh.Category, lh.DateOfMaking, lh.Expires);
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

        private void ClearLicenseTab()
        {
            lbLicenseCreationDate.Text = "";
            txtLicenseNumber.Text = string.Empty;
            txtLicenseCategory.Text = string.Empty;
            dtLicenseExpires.Value = DateTime.Now;
            dgvHistoricLicenses.Rows.Clear();
        }

        private void UpdateInfoTab(Driver driver)
        {
            txtFullname.Text = driver.FullName;
            txtPosition.Text = driver.Position;
            txtPersonalId.Text = driver.PersonalId;
        }

        private void BtnRefreshDrivers_Click(object sender, EventArgs e)
        {
            LoadDrivers();
        }
    }
}
