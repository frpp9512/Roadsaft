﻿using INGECO.DriversControl.Data;
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
    public partial class FrmDriversMainForm : Form
    {
        #region Constructor

        /// <summary>
        /// Default constructor.
        /// </summary>
        public FrmDriversMainForm()
        {
            InitializeComponent();
            Configuration.LoadFromFile();
            DriverDataProviderContainer.InitializeWithDatabaseProvider(
                Configuration.DatabaseHostName,
                Configuration.DatabaseUserName,
                Configuration.DatabasePassword,
                Configuration.DatabaseName
                );
            SetShowingView(View.Details);
            SetDriversView(DriversView.AllDrivers);
            SetUpTimer();
        }

        #endregion

        #region Properties

        /// <summary>
        /// The loaded drivers to be managed in the form.
        /// </summary>
        public List<Driver> LoadedDrivers { get; set; }
        
        /// <summary>
        /// The current selected DriversView option.
        /// </summary>
        public DriversView DriversView { get; set; }

        #endregion

        #region Methods

        /// <summary>
        /// Set the configured interval to the timer and set the action to do on Tick.
        /// </summary>
        private void SetUpTimer()
        {
            if(refreshTimer.Enabled == true)
            {
                refreshTimer.Stop();
            }
            refreshTimer.Interval = Configuration.RefreshInterval * 60 * 1000;
            refreshTimer.Tick += (s, ea) => LoadDrivers();
            refreshTimer.Start();
        }

        /// <summary>
        /// Loads all the drivers registered in the system.
        /// </summary>
        private async void LoadDrivers()
        {
            stlbLoading.Visible = true;
            LoadedDrivers = await Task.Run(() => 
            {
                switch (DriversView)
                {
                    case DriversView.AllDrivers:
                        return DriverDataProviderContainer.Controller.GetDrivers();
                    case DriversView.DriversWithoutIssues:
                        return DriverDataProviderContainer.Controller.GetDriversWithoutIssues(Configuration.ExpireWarningForLicense, Configuration.ExpireWarningForRequalification, Configuration.ExpireWarningForMedicalExam);
                    case DriversView.DriversWithWarnings:
                        return DriverDataProviderContainer.Controller.GetDriversWithWarnings(Configuration.ExpireWarningForLicense, Configuration.ExpireWarningForRequalification, Configuration.ExpireWarningForMedicalExam);
                    case DriversView.DriversWithIssues:
                        return DriverDataProviderContainer.Controller.GetDriverWithExpiredAttributes(Configuration.ExpireWarningForLicense, Configuration.ExpireWarningForRequalification, Configuration.ExpireWarningForMedicalExam);
                    default:
                        throw new Exception("Ha ocurrido un error cargando los choferes.");
                }
            });
            ShowLoadedDriversStatistic(LoadedDrivers);
            stlbLoading.Visible = false;
            DriversQuickSearch(txtQuickSearch.Text);
        }

        /// <summary>
        /// Perform a quick search with with the loaded drivers.
        /// </summary>
        /// <param name="value">The value to make the search.</param>
        private void DriversQuickSearch(string value)
        {
            btnRefreshDrivers.Enabled = false;
            var selectedIndex = -1;
            if (lvDriversList.SelectedIndices.Count > 0)
            {
                selectedIndex = lvDriversList.SelectedIndices[0];
            }
            SetListViewImageLists();
            lvDriversList.Items.Clear();
            lvDriversList.SuspendLayout();
            var professionalGroup = new ListViewGroup("Profesionales");
            var nonProfessionalGroup = new ListViewGroup("No Profesionales");
            foreach (var driver in LoadedDrivers)
            {
                if (driver.FullName.ToLower().Contains(value.ToLower()) ||
                    driver.PersonalId.Contains(value) || 
                    driver.DriverLicense?.Number.Contains(value) == true)
                {
                    var item = new ListViewItem(new string[] { driver.FullName, driver.Position, driver.Category.GetDisplayText(), driver.PersonalId, driver.Age.ToString(), driver.Description })
                    {
                        ImageIndex = driver.HasExpiredParameters ? 2 : driver.GetIfAnyParameterExpireDateIsInPeriod(Configuration.ExpireWarningForLicense, Configuration.ExpireWarningForRequalification, Configuration.ExpireWarningForMedicalExam) ? 1 : 0,
                        Group = driver.Category == DriverCategory.Professional ? professionalGroup : nonProfessionalGroup,
                        Tag = driver,
                        ToolTipText = driver.GetStatusToolTip()
                    };
                    _ = lvDriversList.Items.Add(item);
                }
            }
            if (lvDriversList.Items.Count > 0 && selectedIndex >= 0 && selectedIndex < lvDriversList.Items.Count)
            {
                lvDriversList.SelectedItems.Clear();
                lvDriversList.Items[selectedIndex].Selected = true;
            }
            lvDriversList.Groups.Add(professionalGroup);
            lvDriversList.Groups.Add(nonProfessionalGroup);
            stlbShowStatics.Text = $"Mostrando {lvDriversList.Items.Count} chofer{(lvDriversList.Items.Count == 1 ? "" : "es")} de {LoadedDrivers.Count} mostrado{(LoadedDrivers.Count == 1 ? "" : "s")}.";
            lvDriversList.ResumeLayout();
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
        }

        /// <summary>
        /// Gets the first of the selected drivers in the ListView.
        /// </summary>
        /// <returns>The first of the selected drivers.</returns>
        private Driver GetFirstSelectedDriver()
        {
            return lvDriversList.SelectedItems[0].Tag as Driver;
        }

        /// <summary>
        /// Gets the current selected drivers in the ListView.
        /// </summary>
        /// <returns>The current selected drivers.</returns>
        private List<Driver> GetSelectedDrivers()
        {
            var selectedDrivers = new List<Driver>();
            for (var i = 0; i < lvDriversList.SelectedItems.Count; i++)
            {
                selectedDrivers.Add(lvDriversList.SelectedItems[i].Tag as Driver);
            }
            return selectedDrivers;
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
        /// Open the Drivers Details form.
        /// </summary>
        private void OpenSelectedDriverDetails()
        {
            if (lvDriversList.SelectedItems.Count > 0)
            {
                var frm = new FrmDriverDetails(GetFirstSelectedDriver());
                frm.UpdateRequested += (s, ea) => LoadDrivers();
                frm.ShowDialog();
            }
        }

        /// <summary>
        /// Sets a view for the ListView.
        /// </summary>
        /// <param name="view">The view to set.</param>
        private void SetShowingView(View view)
        {
            switch (view)
            {
                case View.LargeIcon:
                    lvDriversList.View = View.LargeIcon;
                    icónosPequeñosToolStripMenuItem.Checked = false;
                    detallesToolStripMenuItem.Checked = false;
                    icónosGrandesToolStripMenuItem.Checked = true;
                    listaToolStripMenuItem.Checked = false;
                    teselasToolStripMenuItem.Checked = false;
                    break;
                case View.Details:
                    lvDriversList.View = View.Details;
                    icónosPequeñosToolStripMenuItem.Checked = false;
                    detallesToolStripMenuItem.Checked = true;
                    icónosGrandesToolStripMenuItem.Checked = false;
                    listaToolStripMenuItem.Checked = false;
                    teselasToolStripMenuItem.Checked = false;
                    return;
                case View.SmallIcon:
                    lvDriversList.View = View.SmallIcon;
                    icónosPequeñosToolStripMenuItem.Checked = true;
                    detallesToolStripMenuItem.Checked = false;
                    icónosGrandesToolStripMenuItem.Checked = false;
                    listaToolStripMenuItem.Checked = false;
                    teselasToolStripMenuItem.Checked = false;
                    return;
                case View.List:
                    lvDriversList.View = View.List;
                    icónosPequeñosToolStripMenuItem.Checked = false;
                    detallesToolStripMenuItem.Checked = false;
                    icónosGrandesToolStripMenuItem.Checked = false;
                    listaToolStripMenuItem.Checked = true;
                    teselasToolStripMenuItem.Checked = false;
                    return;
                case View.Tile:
                    lvDriversList.View = View.Tile;
                    icónosPequeñosToolStripMenuItem.Checked = false;
                    detallesToolStripMenuItem.Checked = false;
                    icónosGrandesToolStripMenuItem.Checked = false;
                    listaToolStripMenuItem.Checked = false;
                    teselasToolStripMenuItem.Checked = true;
                    DriversQuickSearch(txtQuickSearch.Text);
                    return;
                default:
                    break;
            }
        }

        /// <summary>
        /// Sets the current Driver's view.
        /// </summary>
        /// <param name="driversView">The new Driver's view.</param>
        private void SetDriversView(DriversView driversView)
        {
            switch (driversView)
            {
                case DriversView.AllDrivers:
                    SelectDriversView(todosLosChoferesToolStripMenuItem, new EventArgs());
                    break;
                case DriversView.DriversWithoutIssues:
                    SelectDriversView(choferessinProblemasToolStripMenuItem, new EventArgs());
                    break;
                case DriversView.DriversWithWarnings:
                    SelectDriversView(choferesConAdvertenciasToolStripMenuItem, new EventArgs());
                    break;
                case DriversView.DriversWithIssues:
                    SelectDriversView(choferesConProblemasToolStripMenuItem, new EventArgs());
                    break;
                default:
                    break;
            }
        }

        /// <summary>
        /// Opens the configuration form.
        /// </summary>
        private void OpenConfigurationForm()
        {
            var frm = new FrmConfiguration();
            frm.FormClosed += (s, ea) =>
            {
                SetUpTimer();
                LoadDrivers();
            };
            frm.Show();
        }

        /// <summary>
        /// Deactivates the current selected drivers.
        /// </summary>
        private void DeactivateSelectedDrivers()
        {
            var selected = GetSelectedDrivers();
            if (MessageBox.Show($"¿Está seguro que desea dar baja {(selected.Count > 1 ? $"a los {selected.Count} choferes seleccionados" : $"al chofer '{selected[0].FullName}'")}?", "Dar baja a choferes", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                foreach (var driver in selected)
                {
                    if (!DriverDataProviderContainer.Controller.DeactivateDriver(driver))
                    {
                        _ = MessageBox.Show("Ha ocurrido un error en la desactivación de un chofer. Vuelva a intentarlo, si el error persiste comunicarse con el desarrollador.", "Error dando baja a chofer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                _ = MessageBox.Show($"Se ha dado baja satisfactoriamente {(selected.Count > 1 ? $"a los {selected.Count} choferes seleccionados" : $"al chofer '{selected[0].FullName}'")}.", "Dar baja a chofer", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            LoadDrivers();
        }

        /// <summary>
        /// Open the <see cref="FrmDriversReports"/> form.
        /// </summary>
        private void OpenDriversReport()
        {
            var frm = new FrmDriversReports(LoadedDrivers);
            frm.Show();
        }

        #endregion

        #region Events subscribers

        private void BtnRefreshDrivers_Click(object sender, EventArgs e)
        {
            LoadDrivers();
        }

        private void BtnNewDriver_Click(object sender, EventArgs e)
        {
            AddNewDriver();
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

        private void LvDriversList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            OpenSelectedDriverDetails();
        }

        private void DetallesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetShowingView(View.Details);
        }

        private void IcónosGrandesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetShowingView(View.LargeIcon);
        }

        private void IcónosPequeñosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetShowingView(View.SmallIcon);
        }

        private void ListaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetShowingView(View.List);
        }

        private void TeselasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetShowingView(View.Tile);
        }

        private void SelectDriversView(object sender, EventArgs e)
        {
            var menuOptions = new ToolStripMenuItem[] { todosLosChoferesToolStripMenuItem, choferessinProblemasToolStripMenuItem, choferesConAdvertenciasToolStripMenuItem, choferesConProblemasToolStripMenuItem };            
            menuOptions.ToList().ForEach(m => m.Checked = m == sender);            
            DriversView = (DriversView)(menuOptions.ToList().IndexOf(sender as ToolStripMenuItem));
            stlbDriversView.Text = $"Visualizando: {DriversView.GetDisplayText()}";
            menuOptions = null;
            try
            {
                LoadDrivers();
            }
            catch(Exception ex)
            { 
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TxtQuickSearch_TextChanged(object sender, EventArgs e)
        {
            DriversQuickSearch(txtQuickSearch.Text);
        }

        private void ConfiguraciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenConfigurationForm();
        }

        private void DriverContextMenu_Opening(object sender, CancelEventArgs e)
        {
            var driverMenuOptions = new ToolStripMenuItem[]
            {
                detallesToolStripMenuItem1,
                imprimirfichaToolStripMenuItem,
                renovarLicenciaToolStripMenuItem,
                renovarRecalificaciónToolStripMenuItem,
                nuevoChequeoMédicoToolStripMenuItem,
            };
            var separators = new ToolStripSeparator[]
            {
                toolStripSeparator3,
                toolStripSeparator4,
                toolStripSeparator5
            };
            separators.ToList().ForEach(m => m.Visible = lvDriversList.SelectedItems.Count > 0);
            driverMenuOptions.ToList().ForEach(m => m.Visible = lvDriversList.SelectedItems.Count > 0);
        }

        private void DetallesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            OpenSelectedDriverDetails();
        }

        private void DarBajaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeactivateSelectedDrivers();
        }

        private void ImprimirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenDriversReport();
        }

        private void ImprimirlistadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenDriversReport();
        }

        #endregion
    }
}
