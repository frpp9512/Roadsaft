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
            this.tvClPersonalId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tvClAge = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.btnNewDriver = new System.Windows.Forms.Button();
            this.btnRefreshDrivers = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.driversControlNotifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.refreshTimer = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.appMainMenu = new System.Windows.Forms.MenuStrip();
            this.programaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detallesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.icónosGrandesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.icónosPequeñosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.teselasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.todosLosChoferesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.choferessinProblemasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.choferesConProblemasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.choferesConAdvertenciasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opcionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configuraciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtQuickSearch = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            lvClFullname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            tvClPosition = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            tvClDescription = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.appMainMenu.SuspendLayout();
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
            this.tvClPersonalId,
            this.tvClAge,
            tvClDescription});
            this.lvDriversList.FullRowSelect = true;
            this.lvDriversList.HideSelection = false;
            this.lvDriversList.Location = new System.Drawing.Point(20, 135);
            this.lvDriversList.Name = "lvDriversList";
            this.lvDriversList.ShowItemToolTips = true;
            this.lvDriversList.Size = new System.Drawing.Size(694, 389);
            this.lvDriversList.TabIndex = 0;
            this.lvDriversList.UseCompatibleStateImageBehavior = false;
            this.lvDriversList.View = System.Windows.Forms.View.Details;
            this.lvDriversList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.LvDriversList_MouseDoubleClick);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 24F);
            this.label1.ForeColor = System.Drawing.Color.ForestGreen;
            this.label1.Location = new System.Drawing.Point(95, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(306, 45);
            this.label1.TabIndex = 1;
            this.label1.Text = "Control de choferes";
            // 
            // btnNewDriver
            // 
            this.btnNewDriver.FlatAppearance.BorderColor = System.Drawing.Color.MediumSeaGreen;
            this.btnNewDriver.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightGreen;
            this.btnNewDriver.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SeaGreen;
            this.btnNewDriver.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleGreen;
            this.btnNewDriver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewDriver.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewDriver.Location = new System.Drawing.Point(20, 106);
            this.btnNewDriver.Name = "btnNewDriver";
            this.btnNewDriver.Size = new System.Drawing.Size(69, 23);
            this.btnNewDriver.TabIndex = 12;
            this.btnNewDriver.Text = "&Nuevo...";
            this.btnNewDriver.UseVisualStyleBackColor = true;
            this.btnNewDriver.Click += new System.EventHandler(this.BtnNewDriver_Click);
            // 
            // btnRefreshDrivers
            // 
            this.btnRefreshDrivers.FlatAppearance.BorderColor = System.Drawing.Color.MediumSeaGreen;
            this.btnRefreshDrivers.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightGreen;
            this.btnRefreshDrivers.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SeaGreen;
            this.btnRefreshDrivers.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleGreen;
            this.btnRefreshDrivers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefreshDrivers.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefreshDrivers.Location = new System.Drawing.Point(170, 106);
            this.btnRefreshDrivers.Name = "btnRefreshDrivers";
            this.btnRefreshDrivers.Size = new System.Drawing.Size(69, 23);
            this.btnRefreshDrivers.TabIndex = 13;
            this.btnRefreshDrivers.Text = "&Actualizar";
            this.btnRefreshDrivers.UseVisualStyleBackColor = true;
            this.btnRefreshDrivers.Click += new System.EventHandler(this.BtnRefreshDrivers_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::INGECO.DriversControl.Properties.Resources.drivers_control;
            this.pictureBox1.Location = new System.Drawing.Point(20, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(69, 68);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
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
            // button1
            // 
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.MediumSeaGreen;
            this.button1.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightGreen;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SeaGreen;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleGreen;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(95, 106);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(69, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "&Filtrar...";
            this.button1.UseVisualStyleBackColor = true;
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
            this.appMainMenu.Size = new System.Drawing.Size(726, 24);
            this.appMainMenu.TabIndex = 16;
            // 
            // programaToolStripMenuItem
            // 
            this.programaToolStripMenuItem.Name = "programaToolStripMenuItem";
            this.programaToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.programaToolStripMenuItem.Text = "&Programa";
            // 
            // verToolStripMenuItem
            // 
            this.verToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.detallesToolStripMenuItem,
            this.icónosGrandesToolStripMenuItem,
            this.icónosPequeñosToolStripMenuItem,
            this.listaToolStripMenuItem,
            this.teselasToolStripMenuItem,
            this.toolStripSeparator1,
            this.todosLosChoferesToolStripMenuItem,
            this.choferessinProblemasToolStripMenuItem,
            this.choferesConAdvertenciasToolStripMenuItem,
            this.choferesConProblemasToolStripMenuItem});
            this.verToolStripMenuItem.Name = "verToolStripMenuItem";
            this.verToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.verToolStripMenuItem.Text = "&Ver";
            // 
            // detallesToolStripMenuItem
            // 
            this.detallesToolStripMenuItem.Name = "detallesToolStripMenuItem";
            this.detallesToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.D1)));
            this.detallesToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.detallesToolStripMenuItem.Text = "&Detalles";
            this.detallesToolStripMenuItem.Click += new System.EventHandler(this.DetallesToolStripMenuItem_Click);
            // 
            // icónosGrandesToolStripMenuItem
            // 
            this.icónosGrandesToolStripMenuItem.Name = "icónosGrandesToolStripMenuItem";
            this.icónosGrandesToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.D2)));
            this.icónosGrandesToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.icónosGrandesToolStripMenuItem.Text = "Icónos &grandes";
            this.icónosGrandesToolStripMenuItem.Click += new System.EventHandler(this.IcónosGrandesToolStripMenuItem_Click);
            // 
            // icónosPequeñosToolStripMenuItem
            // 
            this.icónosPequeñosToolStripMenuItem.Name = "icónosPequeñosToolStripMenuItem";
            this.icónosPequeñosToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.D3)));
            this.icónosPequeñosToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.icónosPequeñosToolStripMenuItem.Text = "Icónos &pequeños";
            this.icónosPequeñosToolStripMenuItem.Click += new System.EventHandler(this.IcónosPequeñosToolStripMenuItem_Click);
            // 
            // listaToolStripMenuItem
            // 
            this.listaToolStripMenuItem.Name = "listaToolStripMenuItem";
            this.listaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.D4)));
            this.listaToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.listaToolStripMenuItem.Text = "&Lista";
            this.listaToolStripMenuItem.Click += new System.EventHandler(this.ListaToolStripMenuItem_Click);
            // 
            // teselasToolStripMenuItem
            // 
            this.teselasToolStripMenuItem.Name = "teselasToolStripMenuItem";
            this.teselasToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.D5)));
            this.teselasToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.teselasToolStripMenuItem.Text = "&Teselas";
            this.teselasToolStripMenuItem.Click += new System.EventHandler(this.TeselasToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(210, 6);
            // 
            // todosLosChoferesToolStripMenuItem
            // 
            this.todosLosChoferesToolStripMenuItem.CheckOnClick = true;
            this.todosLosChoferesToolStripMenuItem.Name = "todosLosChoferesToolStripMenuItem";
            this.todosLosChoferesToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.todosLosChoferesToolStripMenuItem.Text = "Todos los &choferes";
            this.todosLosChoferesToolStripMenuItem.Click += new System.EventHandler(this.SelectDriversView);
            // 
            // choferessinProblemasToolStripMenuItem
            // 
            this.choferessinProblemasToolStripMenuItem.CheckOnClick = true;
            this.choferessinProblemasToolStripMenuItem.Name = "choferessinProblemasToolStripMenuItem";
            this.choferessinProblemasToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.choferessinProblemasToolStripMenuItem.Text = "Choferes &sin problemas";
            this.choferessinProblemasToolStripMenuItem.Click += new System.EventHandler(this.SelectDriversView);
            // 
            // choferesConProblemasToolStripMenuItem
            // 
            this.choferesConProblemasToolStripMenuItem.CheckOnClick = true;
            this.choferesConProblemasToolStripMenuItem.Name = "choferesConProblemasToolStripMenuItem";
            this.choferesConProblemasToolStripMenuItem.Size = new System.Drawing.Size(248, 22);
            this.choferesConProblemasToolStripMenuItem.Text = "Choferes con atributos &expirados";
            this.choferesConProblemasToolStripMenuItem.Click += new System.EventHandler(this.SelectDriversView);
            // 
            // choferesConAdvertenciasToolStripMenuItem
            // 
            this.choferesConAdvertenciasToolStripMenuItem.CheckOnClick = true;
            this.choferesConAdvertenciasToolStripMenuItem.Name = "choferesConAdvertenciasToolStripMenuItem";
            this.choferesConAdvertenciasToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.choferesConAdvertenciasToolStripMenuItem.Text = "Choferes con &advertencias";
            this.choferesConAdvertenciasToolStripMenuItem.Click += new System.EventHandler(this.SelectDriversView);
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
            this.configuraciónToolStripMenuItem.Name = "configuraciónToolStripMenuItem";
            this.configuraciónToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.configuraciónToolStripMenuItem.Text = "Configuración,,,";
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
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.acercaDeToolStripMenuItem.Text = "&Acerca de...";
            // 
            // txtQuickSearch
            // 
            this.txtQuickSearch.Location = new System.Drawing.Point(489, 108);
            this.txtQuickSearch.Name = "txtQuickSearch";
            this.txtQuickSearch.Size = new System.Drawing.Size(225, 22);
            this.txtQuickSearch.TabIndex = 17;
            this.txtQuickSearch.TextChanged += new System.EventHandler(this.TxtQuickSearch_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(395, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Búsqueda rápida:";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(726, 536);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtQuickSearch);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnRefreshDrivers);
            this.Controls.Add(this.btnNewDriver);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lvDriversList);
            this.Controls.Add(this.appMainMenu);
            this.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.appMainMenu;
            this.MinimumSize = new System.Drawing.Size(742, 506);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Control de choferes";
            this.SizeChanged += new System.EventHandler(this.FrmMain_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.appMainMenu.ResumeLayout(false);
            this.appMainMenu.PerformLayout();
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
        private System.Windows.Forms.Button button1;
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
    }
}