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
            SetUpTimer();
            
        }

        #endregion

        #region Methods

        /// <summary>
        /// Set the configured interval to the timer and set the action to do on Tick.
        /// </summary>
        private void SetUpTimer()
        {
            refreshTimer.Interval = Configuration.RefreshInterval * 60 * 1000;
            refreshTimer.Tick += (s, ea) => LoadDrivers();
            refreshTimer.Start();
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
            var drivers = await Task.Run(() => DriverDataProviderContainer.Controller.GetDrivers());
            foreach (var driver in drivers)
            {
                var item = new ListViewItem(new string[] { driver.FullName, driver.Position, driver.PersonalId, driver.Description })
                {
                    ImageIndex = driver.HasExpiredParameters ? 2 : driver.GetIfAnyParameterExpireDateIsInPeriod(Configuration.ExpireWarningForLicense, Configuration.ExpireWarningForRequalification, Configuration.ExpireWarningForMedicalExam) ? 1 : 0,
                    Tag = driver,
                    ToolTipText = driver.GetStatusToolTip()
                };
                _ = lvDriversList.Items.Add(item);
            }
            if (lvDriversList.Items.Count > 0 && selectedIndex >= 0 && selectedIndex < lvDriversList.Items.Count)
            {
                lvDriversList.SelectedItems.Clear();
                lvDriversList.Items[selectedIndex].Selected = true;
            }
            lvDriversList.ResumeLayout();
            ShowLoadedDriversStatistic(drivers);
            btnRefreshDrivers.Enabled = true;
        }

        private void ShowLoadedDriversStatistic(List<Driver> drivers)
        {
            var noLicenseCount = drivers.Count(d => d.DriverLicense == null);
            var noRequalificationCount = drivers.Count(d => d.Requalificaiton == null);
            var noMedChecksCount = drivers.Count(d => d.MedicalExams.Count == 0);
            var expiredLicenseCount = drivers.Count(d => d.DriverLicense?.IsExpired == true);
            var expiredRequalificationsCount = drivers.Count(d => d.Requalificaiton?.IsExpired == true);
            var driversWithExpiredMedChecksCount = drivers.Count(d => d.MedicalExams.Count(me => me.IsExpired) > 0);
            var warningLicenseCount = drivers.Count(d => d.DriverLicense?.GetIfExpirationDateIsInPeriod(Configuration.ExpireWarningForLicense) == true);
            var warningRequalificationCount = drivers.Count(d => d.Requalificaiton?.GetIfExpirationDateIsInPeriod(Configuration.ExpireWarningForRequalification) == true);
            var warningMedicalChecksCount = drivers.Count(d => d.MedicalExams.Count(me => me.GetIfExpirationDateIsInPeriod(Configuration.ExpireWarningForMedicalExam)) > 0);
            var statisticMessage = new StringBuilder();
            if (expiredLicenseCount > 0)
            {
                _ = statisticMessage.AppendLine($"Existe{(expiredLicenseCount > 1 ? "n" : "")} {expiredLicenseCount} chofer{(expiredLicenseCount > 1 ? "es" : "")} con la licencia expirada.");
            }
            if (expiredRequalificationsCount > 0)
            {
                _ = statisticMessage.AppendLine($"Existe{(expiredRequalificationsCount > 1 ? "n" : "")} {expiredRequalificationsCount} chofer{(expiredRequalificationsCount > 1 ? "es" : "")} con la recalificación expirada.");
            }
            if (driversWithExpiredMedChecksCount > 0)
            {
                _ = statisticMessage.AppendLine($"Existe{(driversWithExpiredMedChecksCount > 1 ? "n" : "")} {driversWithExpiredMedChecksCount} chofer{(driversWithExpiredMedChecksCount > 1 ? "es" : "")} con chequeos médicos vencidos.");
            }
            if (noLicenseCount > 0)
            {
                _ = statisticMessage.AppendLine($"Existe{(noLicenseCount > 1 ? "n" : "")} {noLicenseCount} chofer{(noLicenseCount > 1 ? "es" : "")} sin una licencia activa.");
            }
            if (noRequalificationCount > 0)
            {
                _ = statisticMessage.AppendLine($"Existe{(noRequalificationCount > 1 ? "n" : "")} {noRequalificationCount} chofer{(noRequalificationCount > 1 ? "es" : "")} sin recalificación activa.");
            }
            if (noMedChecksCount > 0)
            {
                _ = statisticMessage.AppendLine($"Existe{(noMedChecksCount > 1 ? "n" : "")} {noMedChecksCount} chofer{(noMedChecksCount > 1 ? "es" : "")} sin chequeos médicos activos.");
            }
            if (warningLicenseCount > 0)
            {
                _ = statisticMessage.AppendLine($"Existe{(warningLicenseCount > 1 ? "n" : "")} {warningLicenseCount} chofer{(warningLicenseCount > 1 ? "es" : "")} con licencia{(warningLicenseCount > 1 ? "s" : "")} próxima{(warningLicenseCount > 1 ? "s" : "")} a vencerse.");
            }
            if (warningRequalificationCount > 0)
            {
                _ = statisticMessage.AppendLine($"Existe{(warningRequalificationCount > 1 ? "n" : "")} {warningRequalificationCount} chofer{(warningRequalificationCount > 1 ? "es" : "")} con recalificaci{(warningRequalificationCount > 1 ? "ones" : "ón")} próxima{(warningRequalificationCount > 1 ? "s" : "")} a vencerse.");
            }
            if (warningMedicalChecksCount > 0)
            {
                _ = statisticMessage.AppendLine($"Existe{(warningMedicalChecksCount > 1 ? "n" : "")} {warningMedicalChecksCount} chofer{(warningMedicalChecksCount > 1 ? "es" : "")} con chequeos médicos próximos a vencerse.");
            }
            if (statisticMessage.Length == 0)
            {
                statisticMessage.AppendLine("Todo se encuentra en orden.");
            }
            driversControlNotifyIcon.ShowBalloonTip
                (
                3,
                "Control de choferes",
                statisticMessage.ToString(),
                (expiredLicenseCount + expiredRequalificationsCount + driversWithExpiredMedChecksCount + noLicenseCount + noRequalificationCount + noMedChecksCount) > 0 ? ToolTipIcon.Error
                : (warningLicenseCount + warningRequalificationCount + warningMedicalChecksCount) > 0 ? ToolTipIcon.Warning
                : ToolTipIcon.Info
                );
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
        /// Update the form by the current selected driver in the ListView.
        /// </summary>
        private void UpdatedSelectedDriver()
        {
            if (lvDriversList.SelectedItems.Count > 0)
            {
                lvDriversList.Enabled = false;
                ShowDriverInfo(GetSelectedDriver());
                lvDriversList.Enabled = true;
            }
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
                            $"{me.Expires.ToShortDateString()} {(me.IsExpired ? "(Expiró)" : $"(Faltan {(me.Expires - DateTime.Now).Days} día(s))")}",
                            me.Result.GetShowText(),
                            me.Description
                            );
                    dgvMedicalExamActive.Rows[added].Tag = me;
                }
                TpMedicalExams.ImageIndex = driver.MedicalExams.Count(me => me.IsExpired) > 0 ? 2 : driver.MedicalExams.Count(me => me.GetIfExpirationDateIsInPeriod(Configuration.ExpireWarningForMedicalExam)) > 0 ? 1 : 0;
            }
            else
            {
                TpMedicalExams.ImageIndex = 2;
                ClearMedicalExamTab();
            }
            LoadMedicalExamsHistory(driver);
        }

        /// <summary>
        /// Load the Medical Exam history for the specified driver.
        /// </summary>
        /// <param name="driver">The driver to load the medical exam history.</param>
        private void LoadMedicalExamsHistory(Driver driver)
        {
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

        /// <summary>
        /// Update the Requalification tab with the data of the specified driver.
        /// </summary>
        /// <param name="driver">The driver to show information.</param>
        private void UpdateRequalificationTab(Driver driver)
        {
            if (driver.Requalificaiton != null)
            {
                lbRequalificationCreationDate.Text = $"Registrada: {driver.Requalificaiton.Created.ToShortDateString()}";
                txtRequalificationPage.Text = driver.Requalificaiton.Page;
                txtRequalificationVolume.Text = driver.Requalificaiton.Volume;
                txtRequalificationDateOfMaking.Text = driver.Requalificaiton.DateOfMaking.ToLongDateString();
                txtRequalificationExpires.Text = driver.Requalificaiton.Expires.ToLongDateString();
                txtRequalificationDescription.Text = driver.Requalificaiton.Description;
                if (driver.Requalificaiton.IsExpired)
                {
                    TpRequalification.ImageIndex = 2;
                    lbRequalificationExpire.Text = "La recalificación ha expirado.";
                }
                else
                {
                    var remainingTime = driver.Requalificaiton.Expires - DateTime.Now;
                    lbRequalificationExpire.Text = $"Falta{(remainingTime.Days > 1 ? "n" : "")} {remainingTime.Days} día{(remainingTime.Days > 1 ? "s" : "")} para que expire la la recalificación.";
                    if (driver.Requalificaiton.GetIfExpirationDateIsInPeriod(Configuration.ExpireWarningForRequalification))
                    {
                        TpRequalification.ImageIndex = 1;
                        lbRequalificationExpire.ForeColor = Color.Yellow;
                    }
                    else
                    {
                        TpRequalification.ImageIndex = 0;
                        lbRequalificationExpire.ForeColor = Color.Green;
                    }
                }
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
                lbLicenseCreationDate.Text = $"Registrada: {driver.DriverLicense.Created.ToShortDateString()}";
                txtLicenseNumber.Text = driver.DriverLicense.Number;
                txtLicenseCategory.Text = driver.DriverLicense.Category;
                txtLicenseExpireDate.Text = driver.DriverLicense.Expires.ToLongDateString();
                txtDriverLicenseDescription.Text = driver.DriverLicense.Description;
                if (driver.DriverLicense.IsExpired)
                {
                    TpDriverLicense.ImageIndex = 2;
                    lbLicenseExpiration.Text = "La licensia de conducción ha expirado.";
                    lbLicenseExpiration.ForeColor = Color.Red;
                }
                else
                {
                    var remainingTime = driver.DriverLicense.Expires - DateTime.Now;
                    lbLicenseExpiration.Text = $"Falta{(remainingTime.Days > 1 ? "n" : "")} {remainingTime.Days} día{(remainingTime.Days > 1 ? "s" : "")} para que expire la licencia.";
                    if (driver.DriverLicense.GetIfExpirationDateIsInPeriod(Configuration.ExpireWarningForLicense))
                    {
                        TpDriverLicense.ImageIndex = 1;
                        lbLicenseExpiration.ForeColor = Color.Yellow;
                    }
                    else
                    {
                        TpDriverLicense.ImageIndex = 0;
                        lbLicenseExpiration.ForeColor = Color.Green;
                    }
                }
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
            txtRequalificationDateOfMaking.Text = string.Empty;
            txtRequalificationExpires.Text = string.Empty;
            lbRequalificationExpire.Text = "No existe recalificación activa.";
            lbRequalificationExpire.ForeColor = Color.Red;
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
            txtLicenseExpireDate.Text = string.Empty;
            lbLicenseExpiration.Text = "No exite licencia activa.";
            lbLicenseExpiration.ForeColor = Color.Red;
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

        /// <summary>
        /// Open the new medical exam form.
        /// </summary>
        private void NewMedicalExam()
        {
            var frm = new FrmNewMedicalExam();
            frm.NewMedicalExamAdded += me =>
            {
                if (DriverDataProviderContainer.Controller.AddNewMedicalExam(GetSelectedDriver(), me))
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
        /// Archive current selected medical exams.
        /// </summary>
        private void ArchiveMedicalExam()
        {
            if (GetSelectedRowsCount() > 0)
            {
                if (MessageBox.Show(
                    $"¿Está seguro que desea archivar {(GetSelectedRowsCount() > 1 ? $"los {GetSelectedRowsCount()}" : "el")} examen{(GetSelectedRowsCount() > 1 ? "es" : "")} seleccionado{(GetSelectedRowsCount() > 1 ? "s" : "")}?",
                    $"Archivar examen{(GetSelectedRowsCount() > 1 ? "es" : "")} médico{(GetSelectedRowsCount() > 1 ? "s" : "")}",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    int total = GetSelectedRowsCount(), errors = 0;
                    for (var i = 0; i < GetSelectedRowsCount(); i++)
                    {
                        if (!DriverDataProviderContainer.Controller.ArchiveMedicalExam(GetSelectedDriver(), (dgvMedicalExamActive.Rows[i].Tag as MedicalExam)))
                        {
                            errors++;
                        }
                    }
                    _ = errors > 0
                        ? MessageBox.Show($"Han ocurrido errores archivando {(total > 1 ? "los" : "el")} examen{(total > 1 ? "es" : "")}. Contacte al desarrollador para obtener soporte acerca de este error.",
                            $"Error archivando examen{(total > 1 ? "es" : "")}",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error)
                        : MessageBox.Show($"Se han archivado satisfactoriamente {total} examen{(total > 1 ? "es" : "")} médico{(total > 1 ? "s" : "")}.",
                            "Examenes archivados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDrivers();
                }
            }
        }

        /// <summary>
        /// Gets the actual amount of selected rows in the Active Medical Exam datagrid.
        /// </summary>
        /// <returns>The count of selected rows.</returns>
        private int GetSelectedRowsCount()
        {
            return dgvMedicalExamActive.SelectedRows.Count;
        }

        #endregion

        #region Events subscribers

        private void LvDriversList_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdatedSelectedDriver();
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

        private void BtnMedicalExamNew_Click(object sender, EventArgs e)
        {
            NewMedicalExam();
        }

        private void BtnMedicalExamArchiveSelected_Click(object sender, EventArgs e)
        {
            ArchiveMedicalExam();
        }

        private void FrmMain_SizeChanged(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                ShowInTaskbar = false;
            }
            else
            {
                if (WindowState == FormWindowState.Normal || WindowState == FormWindowState.Maximized)
                {
                    ShowInTaskbar = true;
                }
            }
        }

        private void DriversControlNotifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                WindowState = FormWindowState.Normal;
            }
        }

        #endregion
    }
}
