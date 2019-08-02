namespace INGECO.DriversControl
{
    partial class FrmDriversMainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ColumnHeader lvClFullname;
            System.Windows.Forms.ColumnHeader tvClPosition;
            System.Windows.Forms.ColumnHeader tvClDescription;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDriversMainForm));
            this.lvDriversList = new System.Windows.Forms.ListView();
            this.tcClCategory = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tvClPersonalId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tvClAge = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.driverContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.detallesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.licenciaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recalificaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.examenesMédicosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.darBajaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.nuevoChoferToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.imprimirfichaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.renovarLicenciaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.renovarRecalificaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoChequeoMédicoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.actualizarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.imprimirlistadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.driversControlNotifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.refreshTimer = new System.Windows.Forms.Timer(this.components);
            this.appMainMenu = new System.Windows.Forms.MenuStrip();
            this.programaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actualizarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historialDeBajasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imprimirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.cerrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seleccionarTodosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.detallesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.icónosGrandesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.icónosPequeñosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.teselasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.todosLosChoferesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.choferessinProblemasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.choferesConAdvertenciasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.choferesConProblemasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.todosLosChoferesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.profesionalesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.noProfesionalesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opcionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configuraciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtQuickSearch = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.appStatusBar = new System.Windows.Forms.StatusStrip();
            this.stlbLoading = new System.Windows.Forms.ToolStripStatusLabel();
            this.stlbShowStatics = new System.Windows.Forms.ToolStripStatusLabel();
            this.stlbDriversView = new System.Windows.Forms.ToolStripStatusLabel();
            this.stlbDriverCategoryFilter = new System.Windows.Forms.ToolStripStatusLabel();
            this.tslbSelectedDriver = new System.Windows.Forms.ToolStripStatusLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnRefreshDrivers = new System.Windows.Forms.Button();
            this.btnNewDriver = new System.Windows.Forms.Button();
            lvClFullname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            tvClPosition = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            tvClDescription = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.driverContextMenu.SuspendLayout();
            this.appMainMenu.SuspendLayout();
            this.appStatusBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lvClFullname
            // 
            lvClFullname.Text = "Nombre completo";
            lvClFullname.Width = 200;
            // 
            // tvClPosition
            // 
            tvClPosition.Text = "Cargo";
            tvClPosition.Width = 150;
            // 
            // tvClDescription
            // 
            tvClDescription.Text = "Descripción";
            tvClDescription.Width = 200;
            // 
            // lvDriversList
            // 
            this.lvDriversList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvDriversList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvDriversList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            lvClFullname,
            tvClPosition,
            this.tcClCategory,
            this.tvClPersonalId,
            this.tvClAge,
            tvClDescription});
            this.lvDriversList.ContextMenuStrip = this.driverContextMenu;
            this.lvDriversList.FullRowSelect = true;
            this.lvDriversList.HideSelection = false;
            this.lvDriversList.Location = new System.Drawing.Point(12, 142);
            this.lvDriversList.Name = "lvDriversList";
            this.lvDriversList.ShowItemToolTips = true;
            this.lvDriversList.Size = new System.Drawing.Size(840, 369);
            this.lvDriversList.TabIndex = 0;
            this.lvDriversList.TileSize = new System.Drawing.Size(200, 50);
            this.lvDriversList.UseCompatibleStateImageBehavior = false;
            this.lvDriversList.View = System.Windows.Forms.View.Details;
            this.lvDriversList.SelectedIndexChanged += new System.EventHandler(this.LvDriversList_SelectedIndexChanged);
            this.lvDriversList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.LvDriversList_MouseDoubleClick);
            // 
            // tcClCategory
            // 
            this.tcClCategory.Text = "Categoría";
            this.tcClCategory.Width = 120;
            // 
            // tvClPersonalId
            // 
            this.tvClPersonalId.Text = "Carné de identidad";
            this.tvClPersonalId.Width = 120;
            // 
            // tvClAge
            // 
            this.tvClAge.Text = "Edad";
            this.tvClAge.Width = 45;
            // 
            // driverContextMenu
            // 
            this.driverContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.detallesToolStripMenuItem1,
            this.darBajaToolStripMenuItem,
            this.toolStripSeparator8,
            this.nuevoChoferToolStripMenuItem,
            this.toolStripSeparator3,
            this.imprimirfichaToolStripMenuItem,
            this.toolStripSeparator4,
            this.renovarLicenciaToolStripMenuItem,
            this.renovarRecalificaciónToolStripMenuItem,
            this.nuevoChequeoMédicoToolStripMenuItem,
            this.toolStripSeparator5,
            this.actualizarToolStripMenuItem1,
            this.imprimirlistadoToolStripMenuItem});
            this.driverContextMenu.Name = "driverContextMenu";
            this.driverContextMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.driverContextMenu.Size = new System.Drawing.Size(256, 226);
            this.driverContextMenu.Opening += new System.ComponentModel.CancelEventHandler(this.DriverContextMenu_Opening);
            // 
            // detallesToolStripMenuItem1
            // 
            this.detallesToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.licenciaToolStripMenuItem,
            this.recalificaciónToolStripMenuItem,
            this.examenesMédicosToolStripMenuItem});
            this.detallesToolStripMenuItem1.Image = global::INGECO.DriversControl.Properties.Resources.opendetails_small;
            this.detallesToolStripMenuItem1.Name = "detallesToolStripMenuItem1";
            this.detallesToolStripMenuItem1.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this.detallesToolStripMenuItem1.Size = new System.Drawing.Size(255, 22);
            this.detallesToolStripMenuItem1.Text = "&Detalles...";
            this.detallesToolStripMenuItem1.Click += new System.EventHandler(this.DetallesToolStripMenuItem1_Click);
            // 
            // licenciaToolStripMenuItem
            // 
            this.licenciaToolStripMenuItem.Image = global::INGECO.DriversControl.Properties.Resources.driver_license_small;
            this.licenciaToolStripMenuItem.Name = "licenciaToolStripMenuItem";
            this.licenciaToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.licenciaToolStripMenuItem.Text = "Li&cencia...";
            this.licenciaToolStripMenuItem.Click += new System.EventHandler(this.LicenciaToolStripMenuItem_Click);
            // 
            // recalificaciónToolStripMenuItem
            // 
            this.recalificaciónToolStripMenuItem.Image = global::INGECO.DriversControl.Properties.Resources.requalification_small;
            this.recalificaciónToolStripMenuItem.Name = "recalificaciónToolStripMenuItem";
            this.recalificaciónToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.recalificaciónToolStripMenuItem.Text = "Recali&ficación...";
            this.recalificaciónToolStripMenuItem.Click += new System.EventHandler(this.RecalificaciónToolStripMenuItem_Click);
            // 
            // examenesMédicosToolStripMenuItem
            // 
            this.examenesMédicosToolStripMenuItem.Image = global::INGECO.DriversControl.Properties.Resources.medcheck_small;
            this.examenesMédicosToolStripMenuItem.Name = "examenesMédicosToolStripMenuItem";
            this.examenesMédicosToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.examenesMédicosToolStripMenuItem.Text = "E&xamenes médicos...";
            this.examenesMédicosToolStripMenuItem.Click += new System.EventHandler(this.ExamenesMédicosToolStripMenuItem_Click);
            // 
            // darBajaToolStripMenuItem
            // 
            this.darBajaToolStripMenuItem.Image = global::INGECO.DriversControl.Properties.Resources.downred_small;
            this.darBajaToolStripMenuItem.Name = "darBajaToolStripMenuItem";
            this.darBajaToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.darBajaToolStripMenuItem.Size = new System.Drawing.Size(255, 22);
            this.darBajaToolStripMenuItem.Text = "Dar &baja";
            this.darBajaToolStripMenuItem.Click += new System.EventHandler(this.DarBajaToolStripMenuItem_Click);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(252, 6);
            // 
            // nuevoChoferToolStripMenuItem
            // 
            this.nuevoChoferToolStripMenuItem.Image = global::INGECO.DriversControl.Properties.Resources.driver_add_small;
            this.nuevoChoferToolStripMenuItem.Name = "nuevoChoferToolStripMenuItem";
            this.nuevoChoferToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.nuevoChoferToolStripMenuItem.Size = new System.Drawing.Size(255, 22);
            this.nuevoChoferToolStripMenuItem.Text = "&Nuevo chofer...";
            this.nuevoChoferToolStripMenuItem.Click += new System.EventHandler(this.NuevoChoferToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(252, 6);
            // 
            // imprimirfichaToolStripMenuItem
            // 
            this.imprimirfichaToolStripMenuItem.Image = global::INGECO.DriversControl.Properties.Resources.print_blank_small;
            this.imprimirfichaToolStripMenuItem.Name = "imprimirfichaToolStripMenuItem";
            this.imprimirfichaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.P)));
            this.imprimirfichaToolStripMenuItem.Size = new System.Drawing.Size(255, 22);
            this.imprimirfichaToolStripMenuItem.Text = "Imprimir &ficha(s)...";
            this.imprimirfichaToolStripMenuItem.Click += new System.EventHandler(this.ImprimirfichaToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(252, 6);
            // 
            // renovarLicenciaToolStripMenuItem
            // 
            this.renovarLicenciaToolStripMenuItem.Image = global::INGECO.DriversControl.Properties.Resources.driver_license_add_small;
            this.renovarLicenciaToolStripMenuItem.Name = "renovarLicenciaToolStripMenuItem";
            this.renovarLicenciaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.renovarLicenciaToolStripMenuItem.Size = new System.Drawing.Size(255, 22);
            this.renovarLicenciaToolStripMenuItem.Text = "&Renovar licencia...";
            this.renovarLicenciaToolStripMenuItem.Click += new System.EventHandler(this.RenovarLicenciaToolStripMenuItem_Click);
            // 
            // renovarRecalificaciónToolStripMenuItem
            // 
            this.renovarRecalificaciónToolStripMenuItem.Image = global::INGECO.DriversControl.Properties.Resources.requalification_add_small;
            this.renovarRecalificaciónToolStripMenuItem.Name = "renovarRecalificaciónToolStripMenuItem";
            this.renovarRecalificaciónToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.renovarRecalificaciónToolStripMenuItem.Size = new System.Drawing.Size(255, 22);
            this.renovarRecalificaciónToolStripMenuItem.Text = "Renovar &recalificación...";
            this.renovarRecalificaciónToolStripMenuItem.Click += new System.EventHandler(this.RenovarRecalificaciónToolStripMenuItem_Click);
            // 
            // nuevoChequeoMédicoToolStripMenuItem
            // 
            this.nuevoChequeoMédicoToolStripMenuItem.Image = global::INGECO.DriversControl.Properties.Resources.medcheck_add_small;
            this.nuevoChequeoMédicoToolStripMenuItem.Name = "nuevoChequeoMédicoToolStripMenuItem";
            this.nuevoChequeoMédicoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.M)));
            this.nuevoChequeoMédicoToolStripMenuItem.Size = new System.Drawing.Size(255, 22);
            this.nuevoChequeoMédicoToolStripMenuItem.Text = "Nuevo chequeo &médico...";
            this.nuevoChequeoMédicoToolStripMenuItem.Click += new System.EventHandler(this.NuevoChequeoMédicoToolStripMenuItem_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(252, 6);
            // 
            // actualizarToolStripMenuItem1
            // 
            this.actualizarToolStripMenuItem1.Image = global::INGECO.DriversControl.Properties.Resources.refresh_small;
            this.actualizarToolStripMenuItem1.Name = "actualizarToolStripMenuItem1";
            this.actualizarToolStripMenuItem1.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.actualizarToolStripMenuItem1.Size = new System.Drawing.Size(255, 22);
            this.actualizarToolStripMenuItem1.Text = "&Actualizar";
            // 
            // imprimirlistadoToolStripMenuItem
            // 
            this.imprimirlistadoToolStripMenuItem.Image = global::INGECO.DriversControl.Properties.Resources.print_small;
            this.imprimirlistadoToolStripMenuItem.Name = "imprimirlistadoToolStripMenuItem";
            this.imprimirlistadoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.imprimirlistadoToolStripMenuItem.Size = new System.Drawing.Size(255, 22);
            this.imprimirlistadoToolStripMenuItem.Text = "Imprimir &listado...";
            this.imprimirlistadoToolStripMenuItem.Click += new System.EventHandler(this.ImprimirlistadoToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 24F);
            this.label1.ForeColor = System.Drawing.Color.ForestGreen;
            this.label1.Location = new System.Drawing.Point(87, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 45);
            this.label1.TabIndex = 1;
            this.label1.Text = "Roadsaft";
            // 
            // driversControlNotifyIcon
            // 
            this.driversControlNotifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("driversControlNotifyIcon.Icon")));
            this.driversControlNotifyIcon.Text = "Control de choferes";
            this.driversControlNotifyIcon.Visible = true;
            this.driversControlNotifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.DriversControlNotifyIcon_MouseDoubleClick);
            // 
            // refreshTimer
            // 
            this.refreshTimer.Interval = 1000;
            // 
            // appMainMenu
            // 
            this.appMainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.programaToolStripMenuItem,
            this.verToolStripMenuItem,
            this.opcionesToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.appMainMenu.Location = new System.Drawing.Point(0, 0);
            this.appMainMenu.Name = "appMainMenu";
            this.appMainMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.appMainMenu.Size = new System.Drawing.Size(864, 24);
            this.appMainMenu.TabIndex = 16;
            // 
            // programaToolStripMenuItem
            // 
            this.programaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.actualizarToolStripMenuItem,
            this.historialDeBajasToolStripMenuItem,
            this.imprimirToolStripMenuItem,
            this.toolStripSeparator2,
            this.cerrarToolStripMenuItem});
            this.programaToolStripMenuItem.Name = "programaToolStripMenuItem";
            this.programaToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.programaToolStripMenuItem.Text = "&Programa";
            // 
            // actualizarToolStripMenuItem
            // 
            this.actualizarToolStripMenuItem.Image = global::INGECO.DriversControl.Properties.Resources.refresh_small;
            this.actualizarToolStripMenuItem.Name = "actualizarToolStripMenuItem";
            this.actualizarToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.actualizarToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.actualizarToolStripMenuItem.Text = "&Actualizar";
            this.actualizarToolStripMenuItem.Click += new System.EventHandler(this.ActualizarToolStripMenuItem_Click);
            // 
            // historialDeBajasToolStripMenuItem
            // 
            this.historialDeBajasToolStripMenuItem.Name = "historialDeBajasToolStripMenuItem";
            this.historialDeBajasToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.historialDeBajasToolStripMenuItem.Text = "&Historial de bajas...";
            this.historialDeBajasToolStripMenuItem.Click += new System.EventHandler(this.HistorialDeBajasToolStripMenuItem_Click);
            // 
            // imprimirToolStripMenuItem
            // 
            this.imprimirToolStripMenuItem.Image = global::INGECO.DriversControl.Properties.Resources.print_small;
            this.imprimirToolStripMenuItem.Name = "imprimirToolStripMenuItem";
            this.imprimirToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.imprimirToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.imprimirToolStripMenuItem.Text = "&Imprimir...";
            this.imprimirToolStripMenuItem.Click += new System.EventHandler(this.ImprimirToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(170, 6);
            // 
            // cerrarToolStripMenuItem
            // 
            this.cerrarToolStripMenuItem.Image = global::INGECO.DriversControl.Properties.Resources.error;
            this.cerrarToolStripMenuItem.Name = "cerrarToolStripMenuItem";
            this.cerrarToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.cerrarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cerrarToolStripMenuItem.Text = "&Cerrar";
            this.cerrarToolStripMenuItem.Click += new System.EventHandler(this.CerrarToolStripMenuItem_Click);
            // 
            // verToolStripMenuItem
            // 
            this.verToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.seleccionarTodosToolStripMenuItem,
            this.toolStripSeparator7,
            this.detallesToolStripMenuItem,
            this.icónosGrandesToolStripMenuItem,
            this.icónosPequeñosToolStripMenuItem,
            this.listaToolStripMenuItem,
            this.teselasToolStripMenuItem,
            this.toolStripSeparator1,
            this.todosLosChoferesToolStripMenuItem,
            this.choferessinProblemasToolStripMenuItem,
            this.choferesConAdvertenciasToolStripMenuItem,
            this.choferesConProblemasToolStripMenuItem,
            this.toolStripSeparator6,
            this.todosLosChoferesToolStripMenuItem1,
            this.profesionalesToolStripMenuItem,
            this.noProfesionalesToolStripMenuItem});
            this.verToolStripMenuItem.Name = "verToolStripMenuItem";
            this.verToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.verToolStripMenuItem.Text = "&Ver";
            // 
            // seleccionarTodosToolStripMenuItem
            // 
            this.seleccionarTodosToolStripMenuItem.Image = global::INGECO.DriversControl.Properties.Resources.select_all_small;
            this.seleccionarTodosToolStripMenuItem.Name = "seleccionarTodosToolStripMenuItem";
            this.seleccionarTodosToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.seleccionarTodosToolStripMenuItem.Size = new System.Drawing.Size(320, 22);
            this.seleccionarTodosToolStripMenuItem.Text = "Se&leccionar todos";
            this.seleccionarTodosToolStripMenuItem.Click += new System.EventHandler(this.SeleccionarTodosToolStripMenuItem_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(317, 6);
            // 
            // detallesToolStripMenuItem
            // 
            this.detallesToolStripMenuItem.Image = global::INGECO.DriversControl.Properties.Resources.details_small;
            this.detallesToolStripMenuItem.Name = "detallesToolStripMenuItem";
            this.detallesToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.D1)));
            this.detallesToolStripMenuItem.Size = new System.Drawing.Size(320, 22);
            this.detallesToolStripMenuItem.Text = "&Detalles";
            this.detallesToolStripMenuItem.Click += new System.EventHandler(this.DetallesToolStripMenuItem_Click);
            // 
            // icónosGrandesToolStripMenuItem
            // 
            this.icónosGrandesToolStripMenuItem.Image = global::INGECO.DriversControl.Properties.Resources.big_icons_small;
            this.icónosGrandesToolStripMenuItem.Name = "icónosGrandesToolStripMenuItem";
            this.icónosGrandesToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.D2)));
            this.icónosGrandesToolStripMenuItem.Size = new System.Drawing.Size(320, 22);
            this.icónosGrandesToolStripMenuItem.Text = "Icónos &grandes";
            this.icónosGrandesToolStripMenuItem.Click += new System.EventHandler(this.IcónosGrandesToolStripMenuItem_Click);
            // 
            // icónosPequeñosToolStripMenuItem
            // 
            this.icónosPequeñosToolStripMenuItem.Image = global::INGECO.DriversControl.Properties.Resources.small_icons_small;
            this.icónosPequeñosToolStripMenuItem.Name = "icónosPequeñosToolStripMenuItem";
            this.icónosPequeñosToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.D3)));
            this.icónosPequeñosToolStripMenuItem.Size = new System.Drawing.Size(320, 22);
            this.icónosPequeñosToolStripMenuItem.Text = "Icónos &pequeños";
            this.icónosPequeñosToolStripMenuItem.Click += new System.EventHandler(this.IcónosPequeñosToolStripMenuItem_Click);
            // 
            // listaToolStripMenuItem
            // 
            this.listaToolStripMenuItem.Image = global::INGECO.DriversControl.Properties.Resources.list_small;
            this.listaToolStripMenuItem.Name = "listaToolStripMenuItem";
            this.listaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.D4)));
            this.listaToolStripMenuItem.Size = new System.Drawing.Size(320, 22);
            this.listaToolStripMenuItem.Text = "&Lista";
            this.listaToolStripMenuItem.Click += new System.EventHandler(this.ListaToolStripMenuItem_Click);
            // 
            // teselasToolStripMenuItem
            // 
            this.teselasToolStripMenuItem.Image = global::INGECO.DriversControl.Properties.Resources.tiles_small;
            this.teselasToolStripMenuItem.Name = "teselasToolStripMenuItem";
            this.teselasToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.D5)));
            this.teselasToolStripMenuItem.Size = new System.Drawing.Size(320, 22);
            this.teselasToolStripMenuItem.Text = "T&eselas";
            this.teselasToolStripMenuItem.Click += new System.EventHandler(this.TeselasToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(317, 6);
            // 
            // todosLosChoferesToolStripMenuItem
            // 
            this.todosLosChoferesToolStripMenuItem.CheckOnClick = true;
            this.todosLosChoferesToolStripMenuItem.Image = global::INGECO.DriversControl.Properties.Resources.driver_small;
            this.todosLosChoferesToolStripMenuItem.Name = "todosLosChoferesToolStripMenuItem";
            this.todosLosChoferesToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.T)));
            this.todosLosChoferesToolStripMenuItem.Size = new System.Drawing.Size(320, 22);
            this.todosLosChoferesToolStripMenuItem.Text = "Todos los &choferes";
            this.todosLosChoferesToolStripMenuItem.Click += new System.EventHandler(this.SelectDriversView);
            // 
            // choferessinProblemasToolStripMenuItem
            // 
            this.choferessinProblemasToolStripMenuItem.CheckOnClick = true;
            this.choferessinProblemasToolStripMenuItem.Image = global::INGECO.DriversControl.Properties.Resources.ok;
            this.choferessinProblemasToolStripMenuItem.Name = "choferessinProblemasToolStripMenuItem";
            this.choferessinProblemasToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.choferessinProblemasToolStripMenuItem.Size = new System.Drawing.Size(320, 22);
            this.choferessinProblemasToolStripMenuItem.Text = "Choferes &sin problemas";
            this.choferessinProblemasToolStripMenuItem.Click += new System.EventHandler(this.SelectDriversView);
            // 
            // choferesConAdvertenciasToolStripMenuItem
            // 
            this.choferesConAdvertenciasToolStripMenuItem.CheckOnClick = true;
            this.choferesConAdvertenciasToolStripMenuItem.Image = global::INGECO.DriversControl.Properties.Resources.warning;
            this.choferesConAdvertenciasToolStripMenuItem.Name = "choferesConAdvertenciasToolStripMenuItem";
            this.choferesConAdvertenciasToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.A)));
            this.choferesConAdvertenciasToolStripMenuItem.Size = new System.Drawing.Size(320, 22);
            this.choferesConAdvertenciasToolStripMenuItem.Text = "Choferes con &advertencias";
            this.choferesConAdvertenciasToolStripMenuItem.Click += new System.EventHandler(this.SelectDriversView);
            // 
            // choferesConProblemasToolStripMenuItem
            // 
            this.choferesConProblemasToolStripMenuItem.CheckOnClick = true;
            this.choferesConProblemasToolStripMenuItem.Image = global::INGECO.DriversControl.Properties.Resources.error;
            this.choferesConProblemasToolStripMenuItem.Name = "choferesConProblemasToolStripMenuItem";
            this.choferesConProblemasToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.E)));
            this.choferesConProblemasToolStripMenuItem.Size = new System.Drawing.Size(320, 22);
            this.choferesConProblemasToolStripMenuItem.Text = "Choferes con atributos &expirados";
            this.choferesConProblemasToolStripMenuItem.Click += new System.EventHandler(this.SelectDriversView);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(317, 6);
            // 
            // todosLosChoferesToolStripMenuItem1
            // 
            this.todosLosChoferesToolStripMenuItem1.Name = "todosLosChoferesToolStripMenuItem1";
            this.todosLosChoferesToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.T)));
            this.todosLosChoferesToolStripMenuItem1.Size = new System.Drawing.Size(320, 22);
            this.todosLosChoferesToolStripMenuItem1.Text = "Todos los ch&oferes";
            this.todosLosChoferesToolStripMenuItem1.Click += new System.EventHandler(this.SelectDriverCategoryFilter);
            // 
            // profesionalesToolStripMenuItem
            // 
            this.profesionalesToolStripMenuItem.Name = "profesionalesToolStripMenuItem";
            this.profesionalesToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.P)));
            this.profesionalesToolStripMenuItem.Size = new System.Drawing.Size(320, 22);
            this.profesionalesToolStripMenuItem.Text = "&Profesionales";
            this.profesionalesToolStripMenuItem.Click += new System.EventHandler(this.SelectDriverCategoryFilter);
            // 
            // noProfesionalesToolStripMenuItem
            // 
            this.noProfesionalesToolStripMenuItem.Name = "noProfesionalesToolStripMenuItem";
            this.noProfesionalesToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.N)));
            this.noProfesionalesToolStripMenuItem.Size = new System.Drawing.Size(320, 22);
            this.noProfesionalesToolStripMenuItem.Text = "&No profesionales";
            this.noProfesionalesToolStripMenuItem.Click += new System.EventHandler(this.SelectDriverCategoryFilter);
            // 
            // opcionesToolStripMenuItem
            // 
            this.opcionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configuraciónToolStripMenuItem});
            this.opcionesToolStripMenuItem.Name = "opcionesToolStripMenuItem";
            this.opcionesToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.opcionesToolStripMenuItem.Text = "&Opciones";
            // 
            // configuraciónToolStripMenuItem
            // 
            this.configuraciónToolStripMenuItem.Image = global::INGECO.DriversControl.Properties.Resources.settings_small;
            this.configuraciónToolStripMenuItem.Name = "configuraciónToolStripMenuItem";
            this.configuraciónToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F6;
            this.configuraciónToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.configuraciónToolStripMenuItem.Text = "Configuración...";
            this.configuraciónToolStripMenuItem.Click += new System.EventHandler(this.ConfiguraciónToolStripMenuItem_Click);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acercaDeToolStripMenuItem});
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ayudaToolStripMenuItem.Text = "&Ayuda";
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Image = global::INGECO.DriversControl.Properties.Resources.INGECO_DriversControl_small;
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.acercaDeToolStripMenuItem.Text = "&Acerca de...";
            this.acercaDeToolStripMenuItem.Click += new System.EventHandler(this.AcercaDeToolStripMenuItem_Click);
            // 
            // txtQuickSearch
            // 
            this.txtQuickSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtQuickSearch.Location = new System.Drawing.Point(627, 114);
            this.txtQuickSearch.Name = "txtQuickSearch";
            this.txtQuickSearch.Size = new System.Drawing.Size(225, 22);
            this.txtQuickSearch.TabIndex = 17;
            this.txtQuickSearch.TextChanged += new System.EventHandler(this.TxtQuickSearch_TextChanged);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(533, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Búsqueda rápida:";
            // 
            // appStatusBar
            // 
            this.appStatusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stlbLoading,
            this.stlbShowStatics,
            this.stlbDriversView,
            this.stlbDriverCategoryFilter,
            this.tslbSelectedDriver});
            this.appStatusBar.Location = new System.Drawing.Point(0, 514);
            this.appStatusBar.Name = "appStatusBar";
            this.appStatusBar.Size = new System.Drawing.Size(864, 22);
            this.appStatusBar.TabIndex = 19;
            this.appStatusBar.Text = "Barra de estado";
            // 
            // stlbLoading
            // 
            this.stlbLoading.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stlbLoading.ForeColor = System.Drawing.Color.SeaGreen;
            this.stlbLoading.Name = "stlbLoading";
            this.stlbLoading.Size = new System.Drawing.Size(68, 17);
            this.stlbLoading.Text = "Cargando...";
            this.stlbLoading.Visible = false;
            // 
            // stlbShowStatics
            // 
            this.stlbShowStatics.Name = "stlbShowStatics";
            this.stlbShowStatics.Size = new System.Drawing.Size(203, 17);
            this.stlbShowStatics.Text = "Mostrando X choferes de X cargados.";
            // 
            // stlbDriversView
            // 
            this.stlbDriversView.Name = "stlbDriversView";
            this.stlbDriversView.Size = new System.Drawing.Size(179, 17);
            this.stlbDriversView.Text = "Visualizando: Todos los choferes.";
            // 
            // stlbDriverCategoryFilter
            // 
            this.stlbDriverCategoryFilter.Name = "stlbDriverCategoryFilter";
            this.stlbDriverCategoryFilter.Size = new System.Drawing.Size(78, 17);
            this.stlbDriverCategoryFilter.Text = "Filtrando por:";
            // 
            // tslbSelectedDriver
            // 
            this.tslbSelectedDriver.Name = "tslbSelectedDriver";
            this.tslbSelectedDriver.Size = new System.Drawing.Size(80, 17);
            this.tslbSelectedDriver.Text = "Seleccionado:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Light", 16F);
            this.label3.ForeColor = System.Drawing.Color.ForestGreen;
            this.label3.Location = new System.Drawing.Point(90, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(196, 30);
            this.label3.TabIndex = 1;
            this.label3.Text = "Gestión de choferes";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::INGECO.DriversControl.Properties.Resources.driver;
            this.pictureBox2.Location = new System.Drawing.Point(286, 72);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(33, 30);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 20;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::INGECO.DriversControl.Properties.Resources.INGECO_DriversControl;
            this.pictureBox1.Location = new System.Drawing.Point(12, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(69, 75);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // btnRefreshDrivers
            // 
            this.btnRefreshDrivers.FlatAppearance.BorderColor = System.Drawing.Color.MediumSeaGreen;
            this.btnRefreshDrivers.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightGreen;
            this.btnRefreshDrivers.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SeaGreen;
            this.btnRefreshDrivers.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleGreen;
            this.btnRefreshDrivers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefreshDrivers.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefreshDrivers.Image = ((System.Drawing.Image)(resources.GetObject("btnRefreshDrivers.Image")));
            this.btnRefreshDrivers.Location = new System.Drawing.Point(95, 108);
            this.btnRefreshDrivers.Name = "btnRefreshDrivers";
            this.btnRefreshDrivers.Size = new System.Drawing.Size(81, 28);
            this.btnRefreshDrivers.TabIndex = 13;
            this.btnRefreshDrivers.Text = "&Actualizar";
            this.btnRefreshDrivers.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRefreshDrivers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRefreshDrivers.UseVisualStyleBackColor = true;
            this.btnRefreshDrivers.Click += new System.EventHandler(this.BtnRefreshDrivers_Click);
            // 
            // btnNewDriver
            // 
            this.btnNewDriver.FlatAppearance.BorderColor = System.Drawing.Color.MediumSeaGreen;
            this.btnNewDriver.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightGreen;
            this.btnNewDriver.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SeaGreen;
            this.btnNewDriver.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleGreen;
            this.btnNewDriver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewDriver.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewDriver.Image = global::INGECO.DriversControl.Properties.Resources.driver_add_verysmall;
            this.btnNewDriver.Location = new System.Drawing.Point(12, 108);
            this.btnNewDriver.Name = "btnNewDriver";
            this.btnNewDriver.Size = new System.Drawing.Size(77, 28);
            this.btnNewDriver.TabIndex = 12;
            this.btnNewDriver.Text = "&Nuevo...";
            this.btnNewDriver.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNewDriver.UseVisualStyleBackColor = true;
            this.btnNewDriver.Click += new System.EventHandler(this.BtnNewDriver_Click);
            // 
            // FrmDriversMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(864, 536);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.appStatusBar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtQuickSearch);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnRefreshDrivers);
            this.Controls.Add(this.btnNewDriver);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lvDriversList);
            this.Controls.Add(this.appMainMenu);
            this.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.appMainMenu;
            this.MinimumSize = new System.Drawing.Size(742, 506);
            this.Name = "FrmDriversMainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Control de choferes";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmDriversMainForm_FormClosing);
            this.SizeChanged += new System.EventHandler(this.FrmMain_SizeChanged);
            this.driverContextMenu.ResumeLayout(false);
            this.appMainMenu.ResumeLayout(false);
            this.appMainMenu.PerformLayout();
            this.appStatusBar.ResumeLayout(false);
            this.appStatusBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvDriversList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNewDriver;
        private System.Windows.Forms.ColumnHeader tvClPersonalId;
        private System.Windows.Forms.Button btnRefreshDrivers;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.NotifyIcon driversControlNotifyIcon;
        private System.Windows.Forms.Timer refreshTimer;
        private System.Windows.Forms.MenuStrip appMainMenu;
        private System.Windows.Forms.ToolStripMenuItem programaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem opcionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ColumnHeader tvClAge;
        private System.Windows.Forms.ToolStripMenuItem configuraciónToolStripMenuItem;
        private System.Windows.Forms.TextBox txtQuickSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem detallesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem icónosGrandesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem icónosPequeñosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem teselasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem todosLosChoferesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem choferessinProblemasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem choferesConProblemasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem choferesConAdvertenciasToolStripMenuItem;
        private System.Windows.Forms.StatusStrip appStatusBar;
        private System.Windows.Forms.ToolStripStatusLabel stlbShowStatics;
        private System.Windows.Forms.ToolStripStatusLabel stlbDriversView;
        private System.Windows.Forms.ToolStripStatusLabel stlbLoading;
        private System.Windows.Forms.ToolStripMenuItem imprimirToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem cerrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actualizarToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip driverContextMenu;
        private System.Windows.Forms.ToolStripMenuItem detallesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem imprimirfichaToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem renovarLicenciaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem renovarRecalificaciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoChequeoMédicoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem imprimirlistadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem darBajaToolStripMenuItem;
        private System.Windows.Forms.ColumnHeader tcClCategory;
        private System.Windows.Forms.ToolStripMenuItem actualizarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem historialDeBajasToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem todosLosChoferesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem profesionalesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem noProfesionalesToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel stlbDriverCategoryFilter;
        private System.Windows.Forms.ToolStripMenuItem seleccionarTodosToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripStatusLabel tslbSelectedDriver;
        private System.Windows.Forms.ToolStripMenuItem licenciaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recalificaciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem examenesMédicosToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripMenuItem nuevoChoferToolStripMenuItem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}