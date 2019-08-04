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
    /// <summary>
    /// The main form that manages the Drivers.
    /// </summary>
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
            SetShowingView(Configuration.LastUsedView);
            SetDriverCategoryFilter(Configuration.LastDriverCategoryFilter);
            SetDriversView(Configuration.LastDriversView);
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

        /// <summary>
        /// The current filter by driver category.
        /// </summary>
        public DriverCategoryFilter DriverCategoryFilter { get; set; }

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
                try
                {
                    switch (DriversView)
                    {
                        case DriversView.AllDrivers:
                            return DriverDataProviderContainer
                            .Controller
                            .GetDrivers()
                            .Where
                            (
                                d => DriverCategoryFilter == DriverCategoryFilter.ProfessionalsOnly
                                ? d.Category == DriverCategory.Professional
                                : DriverCategoryFilter == DriverCategoryFilter.NonProfessionalsOnly
                                ? d.Category == DriverCategory.NonProfessional
                                : true)
                                .ToList();
                        case DriversView.DriversWithoutIssues:
                            return DriverDataProviderContainer
                            .Controller
                            .GetDriversWithoutIssues
                            (
                                Configuration.ExpireWarningForLicense,
                                Configuration.ExpireWarningForRequalification,
                                Configuration.ExpireWarningForMedicalExam
                            )
                            .Where
                            (
                                d => DriverCategoryFilter == DriverCategoryFilter.ProfessionalsOnly
                                ? d.Category == DriverCategory.Professional
                                : DriverCategoryFilter == DriverCategoryFilter.NonProfessionalsOnly
                                ? d.Category == DriverCategory.NonProfessional
                                : true
                            )
                            .ToList();
                        case DriversView.DriversWithWarnings:
                            return DriverDataProviderContainer
                            .Controller
                            .GetDriversWithWarnings
                            (
                                Configuration.ExpireWarningForLicense,
                                Configuration.ExpireWarningForRequalification,
                                Configuration.ExpireWarningForMedicalExam
                            )
                            .Where
                            (
                                d => DriverCategoryFilter == DriverCategoryFilter.ProfessionalsOnly
                                ? d.Category == DriverCategory.Professional
                                : DriverCategoryFilter == DriverCategoryFilter.NonProfessionalsOnly
                                ? d.Category == DriverCategory.NonProfessional
                                : true
                            )
                            .ToList();
                        case DriversView.DriversWithIssues:
                            return DriverDataProviderContainer
                            .Controller
                            .GetDriverWithExpiredAttributes
                            (
                                Configuration.ExpireWarningForLicense,
                                Configuration.ExpireWarningForRequalification,
                                Configuration.ExpireWarningForMedicalExam
                            )
                            .Where
                            (
                                d => DriverCategoryFilter == DriverCategoryFilter.ProfessionalsOnly
                                ? d.Category == DriverCategory.Professional
                                : DriverCategoryFilter == DriverCategoryFilter.NonProfessionalsOnly
                                ? d.Category == DriverCategory.NonProfessional
                                : true
                            )
                            .ToList();
                        default:
                            throw new Exception("Ha ocurrido un error cargando los choferes.");
                    }
                }
                catch (Exception ex)
                {
                    _ = MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return new List<Driver>();
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
            if (LoadedDrivers != null)
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
                _ = lvDriversList.Groups.Add(professionalGroup);
                _ = lvDriversList.Groups.Add(nonProfessionalGroup);
                UpdateStatusBarInfo();
                lvDriversList.ResumeLayout();
                btnRefreshDrivers.Enabled = true;
            }
        }

        /// <summary>
        /// Update the info showed in the status bar.
        /// </summary>
        private void UpdateStatusBarInfo()
        {
            stlbShowStatics.Text = $"Mostrando {lvDriversList.Items.Count} chofer{(lvDriversList.Items.Count == 1 ? "" : "es")} de {LoadedDrivers.Count} cargado{(LoadedDrivers.Count == 1 ? "" : "s")}.";
            stlbDriversView.Text = $"Visualizando: {DriversView.GetDisplayText()}.";
            stlbDriverCategoryFilter.Text = $"Filtrando por: {DriverCategoryFilter.GetDisplayText()}.";
        }

        private void ShowLoadedDriversStatistic(List<Driver> drivers)
        {
            if (LoadedDrivers.Count > 0)
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
            else
            {
                driversControlNotifyIcon.ShowBalloonTip
                    (
                    3,
                    "Control de choferes",
                    "No se ha cargado ningún chofer.",
                    ToolTipIcon.Warning
                    );
            }
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
        private void OpenSelectedDriverDetails(DriverDetailsInitialAction initAction)
        {
            if (lvDriversList.SelectedItems.Count > 0)
            {
                var frm = new FrmDriverDetails(GetFirstSelectedDriver(), initAction);
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
        /// Set the current Driver Category Filter.
        /// </summary>
        /// <param name="filter"></param>
        private void SetDriverCategoryFilter(DriverCategoryFilter filter)
        {
            DriverCategoryFilter = filter;
            switch (filter)
            {
                case DriverCategoryFilter.All:
                    todosLosChoferesToolStripMenuItem1.Checked = true;
                    break;
                case DriverCategoryFilter.ProfessionalsOnly:
                    profesionalesToolStripMenuItem.Checked = true;
                    break;
                case DriverCategoryFilter.NonProfessionalsOnly:
                    noProfesionalesToolStripMenuItem.Checked = true;
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
            var frm = new FrmDriversReports(LoadedDrivers, DriversView, DriverCategoryFilter);
            frm.Show();
        }

        /// <summary>
        /// Open the About from.
        /// </summary>
        private void OpenAboutForm()
        {
            var frm = new FrmAbout();
            frm.ShowDialog();
        }

        /// <summary>
        /// Opens the Driver Report form.
        /// </summary>
        private void OpenDriverReportForm()
        {
            var frm = new FrmDriverReport(GetSelectedDrivers());
            frm.Show();
        }

        /// <summary>
        /// Selects all drivers showed in the List View.
        /// </summary>
        private void SelectAllDrivers()
        {
            if (lvDriversList.Items.Count > 0)
            {
                for (var i = 0; i < lvDriversList.Items.Count; i++)
                {
                    lvDriversList.Items[i].Selected = lvDriversList.Items[i].Selected ? lvDriversList.Items[i].Selected : true;
                }
            }
        }

        /// <summary>
        /// Deselect all when multiple items are selected in the List View."
        /// </summary>
        private void DeselectAll()
        {
            if (lvDriversList.SelectedItems.Count > 1)
            {
                for (var i = 1; i < lvDriversList.Items.Count; i++)
                {
                    if (lvDriversList.SelectedItems[0] != lvDriversList.Items[i])
                    {
                        lvDriversList.Items[i].Selected = lvDriversList.Items[i].Selected ? false : lvDriversList.Items[i].Selected;
                    }
                }
            }
        }

        /// <summary>
        /// Update the status bar info with the selected driver(s).
        /// </summary>
        private void UpdateSelectedDriverStatusBarInfo()
        {
            var selected = GetSelectedDrivers();
            if (selected.Count > 0)
            {
                if (selected.Count == 1)
                {
                    tslbSelectedDriver.Text = $"Seleccionado: {selected[0].FullName}";
                }
                else
                {
                    tslbSelectedDriver.Text = $"Seleccionados {selected.Count} choferes.";
                }
            }
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
                changeWindowStateMenuItem.Image = Properties.Resources.window_restore_small;
                changeWindowStateMenuItem.Text = "&Restaurar";
            }
            else
            {
                if (WindowState == FormWindowState.Normal || WindowState == FormWindowState.Maximized)
                {
                    ShowInTaskbar = true;
                    changeWindowStateMenuItem.Image = Properties.Resources.window_minimize_small;
                    changeWindowStateMenuItem.Text = "&Minimizar";
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
            OpenSelectedDriverDetails(DriverDetailsInitialAction.None);
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
            DriversView = (DriversView)menuOptions.ToList().IndexOf(sender as ToolStripMenuItem);
            
            menuOptions = null;
            try
            {
                LoadDrivers();
            }
            catch(Exception ex)
            {
                _ = MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                darBajaToolStripMenuItem,
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
                toolStripSeparator5,
                toolStripSeparator8
            };
            separators.ToList().ForEach(m => m.Visible = lvDriversList.SelectedItems.Count > 0);
            driverMenuOptions.ToList().ForEach(m => m.Visible = lvDriversList.SelectedItems.Count > 0);
        }

        private void DetallesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            OpenSelectedDriverDetails(DriverDetailsInitialAction.None);
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

        private void HistorialDeBajasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new FrmDriversHistory();
            frm.Show();
        }

        private void ActualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadDrivers();
        }

        private void AcercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenAboutForm();
        }

        private void ImprimirfichaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenDriverReportForm();
        }

        private void SelectDriverCategoryFilter(object sender, EventArgs e)
        {
            var menuOptions = new ToolStripMenuItem[] { todosLosChoferesToolStripMenuItem1, profesionalesToolStripMenuItem, noProfesionalesToolStripMenuItem };
            menuOptions.ToList().ForEach(mu => mu.Checked = mu == sender);
            DriverCategoryFilter = (DriverCategoryFilter)menuOptions.ToList().IndexOf(sender as ToolStripMenuItem);
            try
            {
                LoadDrivers();
            }
            catch (Exception ex)
            {
                _ = MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmDriversMainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Configuration.LastUsedView = lvDriversList.View;
            Configuration.LastDriversView = DriversView;
            Configuration.LastDriverCategoryFilter = DriverCategoryFilter;
            Configuration.SaveToFile();
        }

        private void SeleccionarTodosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SelectAllDrivers();
        }

        private void LvDriversList_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateSelectedDriverStatusBarInfo();
        }

        private void RenovarLicenciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenSelectedDriverDetails(DriverDetailsInitialAction.LicenseRenewal);
        }

        private void RenovarRecalificaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenSelectedDriverDetails(DriverDetailsInitialAction.RequalificationRenewal);
        }

        private void NuevoChequeoMédicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenSelectedDriverDetails(DriverDetailsInitialAction.NewMedicalExam);
        }

        private void LicenciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenSelectedDriverDetails(DriverDetailsInitialAction.LicenseTabOpen);
        }

        private void RecalificaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenSelectedDriverDetails(DriverDetailsInitialAction.RequalificationTabOpen);
        }

        private void ExamenesMédicosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenSelectedDriverDetails(DriverDetailsInitialAction.MedicalExamTabOpen);
        }

        #endregion

        #region Method overriding

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if(keyData == Keys.Escape)
            {
                DeselectAll();
                return true;
            }
            if(keyData == Keys.Enter)
            {
                OpenSelectedDriverDetails(DriverDetailsInitialAction.None);
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void NuevoChoferToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddNewDriver();
        }

        private void CerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ChangeWindowStateMenuItem_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                WindowState = FormWindowState.Normal;
            }
            else
            {
                WindowState = FormWindowState.Minimized;
            }
        }

        private void ActualizarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            LoadDrivers();
        }

        private void ConfiguraciónToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            OpenConfigurationForm();
        }

        private void AcercaDeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            OpenAboutForm();
        }

        private void CerrarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Close();
        }

        #endregion
    }
}
