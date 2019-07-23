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
            SetListViewImageLists();
            lvDriversList.SuspendLayout();
            lvDriversList.Items.Clear();
            var drivers = await Task.Run(() => DriversDatabaseController.Controller.GetDrivers());
            foreach (var driver in drivers)
            {
                var item = new ListViewItem(new string[] { driver.FullName, driver.Position, driver.PersonalId }, 0)
                {
                    Tag = driver
                };
                _ = lvDriversList.Items.Add(item);
            }
            lvDriversList.ResumeLayout();
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
        }

        private void LvDriversList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lvDriversList.SelectedItems.Count > 0)
            {
                ShowDriverInfo(lvDriversList.SelectedItems[0].Tag as Driver);
            }
        }

        private void ShowDriverInfo(Driver driver)
        {
            UpdateInfoTab(driver);
            UpdateLicenseTab(driver);
            UpdateRequalificationTab(driver);
            UpdateMedicalExamsTab(driver);
        }

        private async void UpdateMedicalExamsTab(Driver driver)
        {
            if (driver.MedicalExams?.Count > 0)
            {
                dgvMedicalExamActive.SuspendLayout();
                dgvMedicalExamActive.Rows.Clear();
                foreach (var me in driver.MedicalExams)
                {
                    var added = dgvMedicalExamActive.Rows.Add(me.Created.ToShortDateString(), me.Type, me.DateOfMaking.ToShortDateString(), me.Expires.ToShortDateString(), me.Result);
                    dgvMedicalExamActive.Rows[added].Tag = me;
                }
                dgvMedicalExamHistorical.SuspendLayout();
                dgvMedicalExamHistorical.Rows.Clear();
                var medicalExamsHistory = await Task.Run(() => DriversDatabaseController.Controller.GetDriverMedicalExamsHistory(driver));
                foreach (var mh in medicalExamsHistory)
                {
                    var added = dgvMedicalExamHistorical.Rows.Add(mh.Created.ToShortDateString(), mh.Type, mh.DateOfMaking.ToShortDateString(), mh.Expires.ToShortDateString(), mh.Result);
                    dgvMedicalExamHistorical.Rows[added].Tag = mh;
                }
                dgvRequalificationHistorical.ResumeLayout();
            }
            else
            {
                ClearMedicalExamTab();
            }
        }

        private void ClearMedicalExamTab()
        {
            dgvMedicalExamActive.Rows.Clear();
            dgvMedicalExamHistorical.Rows.Clear();
        }

        private async void UpdateRequalificationTab(Driver driver)
        {
            if (driver.Requalificaiton != null)
            {
                txtRequalificationPage.Text = driver.Requalificaiton.Page;
                txtRequalificationVolume.Text = driver.Requalificaiton.Volume;
                dtRequalificationDateOfMaking.Value = driver.Requalificaiton.DateOfMaking;
                dtRequalificationExpires.Value = driver.Requalificaiton.Expires;
                dgvRequalificationHistorical.SuspendLayout();
                dgvRequalificationHistorical.Rows.Clear();
                var requalificationsHistory = await Task.Run(() => DriversDatabaseController.Controller.GetDriverRequalificationHistory(driver));
                foreach (var req in requalificationsHistory)
                {
                    var added = dgvRequalificationHistorical.Rows.Add(req.Created.ToShortDateString(), req.DateOfMaking, req.Expires, req.Volume, req.Page);
                    dgvRequalificationHistorical.Rows[added].Tag = req;
                }
                dgvRequalificationHistorical.ResumeLayout();
            }
            else
            {
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

        private async void UpdateLicenseTab(Driver driver)
        {
            if (driver.DriverLicense != null)
            {
                lbLicenseCreationDate.Text = driver.DriverLicense.Created.ToShortDateString();
                txtLicenseNumber.Text = driver.DriverLicense.Number;
                txtLicenseCategory.Text = driver.DriverLicense.Category;
                dtLicenseExpires.Value = driver.DriverLicense.Expires;
                dgvHistoricLicenses.SuspendLayout();
                dgvHistoricLicenses.Rows.Clear();
                var licensesHistory = await Task.Run(() => DriversDatabaseController.Controller.GetDriverLicenseHistory(driver));
                foreach (var lh in licensesHistory)
                {
                    var added = dgvHistoricLicenses.Rows.Add(lh.Created.ToShortDateString(), lh.Number, lh.Category, lh.DateOfMaking, lh.Expires);
                    dgvHistoricLicenses.Rows[added].Tag = lh;
                }
                dgvHistoricLicenses.ResumeLayout();
            }
            else
            {
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
    }
}
