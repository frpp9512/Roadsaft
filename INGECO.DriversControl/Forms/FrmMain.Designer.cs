namespace INGECO.DriversControl
{
    partial class FrmMain
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
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label label6;
            System.Windows.Forms.Label label7;
            System.Windows.Forms.Label label8;
            System.Windows.Forms.Label label9;
            System.Windows.Forms.Label label10;
            System.Windows.Forms.Label label12;
            System.Windows.Forms.Label label11;
            System.Windows.Forms.Label label13;
            System.Windows.Forms.Label label14;
            System.Windows.Forms.Label label15;
            System.Windows.Forms.Label label16;
            System.Windows.Forms.Label label17;
            System.Windows.Forms.Label label18;
            System.Windows.Forms.Label label19;
            System.Windows.Forms.ColumnHeader lvClFullname;
            System.Windows.Forms.ColumnHeader tvClPosition;
            this.lvDriversList = new System.Windows.Forms.ListView();
            this.tvClPersonalId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.TpDriverInfo = new System.Windows.Forms.TabPage();
            this.btnSaveChanges = new System.Windows.Forms.Button();
            this.txtPersonalId = new System.Windows.Forms.TextBox();
            this.txtPosition = new System.Windows.Forms.TextBox();
            this.txtFullname = new System.Windows.Forms.TextBox();
            this.TpDriverLicense = new System.Windows.Forms.TabPage();
            this.lbLicenseCreationDate = new System.Windows.Forms.Label();
            this.dgvHistoricLicenses = new System.Windows.Forms.DataGridView();
            this.clCreatedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clDateOfMaking = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clExpires = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnLicenseRenewal = new System.Windows.Forms.Button();
            this.dtLicenseExpires = new System.Windows.Forms.DateTimePicker();
            this.txtLicenseCategory = new System.Windows.Forms.TextBox();
            this.txtLicenseNumber = new System.Windows.Forms.TextBox();
            this.TpRequalification = new System.Windows.Forms.TabPage();
            this.btnRenewRequalification = new System.Windows.Forms.Button();
            this.dgvRequalificationHistorical = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clVolume = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clPage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtRequalificationPage = new System.Windows.Forms.TextBox();
            this.txtRequalificationVolume = new System.Windows.Forms.TextBox();
            this.dtRequalificationExpires = new System.Windows.Forms.DateTimePicker();
            this.dtRequalificationDateOfMaking = new System.Windows.Forms.DateTimePicker();
            this.lbRequalificationCreationDate = new System.Windows.Forms.Label();
            this.TpMedicalExams = new System.Windows.Forms.TabPage();
            this.dgvMedicalExamHistorical = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clMedExamHType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnMedicalExamNew = new System.Windows.Forms.Button();
            this.btnMedicalExamDeleteSelected = new System.Windows.Forms.Button();
            this.btnMedicalExamArchiveSelected = new System.Windows.Forms.Button();
            this.dgvMedicalExamActive = new System.Windows.Forms.DataGridView();
            this.clIcon = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clMedExamType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clMedExamResult = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnNewDriver = new System.Windows.Forms.Button();
            this.btnRefreshDrivers = new System.Windows.Forms.Button();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            label9 = new System.Windows.Forms.Label();
            label10 = new System.Windows.Forms.Label();
            label12 = new System.Windows.Forms.Label();
            label11 = new System.Windows.Forms.Label();
            label13 = new System.Windows.Forms.Label();
            label14 = new System.Windows.Forms.Label();
            label15 = new System.Windows.Forms.Label();
            label16 = new System.Windows.Forms.Label();
            label17 = new System.Windows.Forms.Label();
            label18 = new System.Windows.Forms.Label();
            label19 = new System.Windows.Forms.Label();
            lvClFullname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            tvClPosition = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabControl1.SuspendLayout();
            this.TpDriverInfo.SuspendLayout();
            this.TpDriverLicense.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistoricLicenses)).BeginInit();
            this.TpRequalification.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRequalificationHistorical)).BeginInit();
            this.TpMedicalExams.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicalExamHistorical)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicalExamActive)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(6, 48);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(94, 13);
            label2.TabIndex = 0;
            label2.Text = "Nombre completo:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(6, 104);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(99, 13);
            label3.TabIndex = 2;
            label3.Text = "Carné de identidad:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(6, 76);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(38, 13);
            label4.TabIndex = 4;
            label4.Text = "Cargo:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(8, 48);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(100, 13);
            label5.TabIndex = 2;
            label5.Text = "Número de licencia:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(8, 76);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(65, 13);
            label6.TabIndex = 4;
            label6.Text = "Categoría(s):";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(8, 104);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(103, 13);
            label7.TabIndex = 6;
            label7.Text = "Fecha de expiración:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new System.Drawing.Font("Segoe UI Semibold", 14F);
            label8.Location = new System.Drawing.Point(5, 12);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(136, 25);
            label8.TabIndex = 10;
            label8.Text = "Licencia activa";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new System.Drawing.Font("Segoe UI Semibold", 14F);
            label9.Location = new System.Drawing.Point(6, 154);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(89, 25);
            label9.TabIndex = 12;
            label9.Text = "Histórico";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new System.Drawing.Font("Segoe UI Semibold", 14F);
            label10.Location = new System.Drawing.Point(3, 10);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(186, 25);
            label10.TabIndex = 11;
            label10.Text = "Información general";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new System.Drawing.Font("Segoe UI Semibold", 14F);
            label12.Location = new System.Drawing.Point(6, 14);
            label12.Name = "label12";
            label12.Size = new System.Drawing.Size(185, 25);
            label12.TabIndex = 14;
            label12.Text = "Recalificación activa";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new System.Drawing.Point(8, 55);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(83, 13);
            label11.TabIndex = 16;
            label11.Text = "Fecha realizada:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new System.Drawing.Point(8, 83);
            label13.Name = "label13";
            label13.Size = new System.Drawing.Size(103, 13);
            label13.TabIndex = 18;
            label13.Text = "Fecha de expiración:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new System.Drawing.Point(116, 111);
            label14.Name = "label14";
            label14.Size = new System.Drawing.Size(35, 13);
            label14.TabIndex = 20;
            label14.Text = "Tomo:";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new System.Drawing.Point(225, 111);
            label15.Name = "label15";
            label15.Size = new System.Drawing.Size(30, 13);
            label15.TabIndex = 22;
            label15.Text = "Folio:";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new System.Drawing.Point(8, 111);
            label16.Name = "label16";
            label16.Size = new System.Drawing.Size(46, 13);
            label16.TabIndex = 24;
            label16.Text = "Registro:";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new System.Drawing.Font("Segoe UI Semibold", 14F);
            label17.Location = new System.Drawing.Point(6, 161);
            label17.Name = "label17";
            label17.Size = new System.Drawing.Size(89, 25);
            label17.TabIndex = 26;
            label17.Text = "Histórico";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new System.Drawing.Font("Segoe UI Semibold", 14F);
            label18.Location = new System.Drawing.Point(1, 12);
            label18.Name = "label18";
            label18.Size = new System.Drawing.Size(239, 25);
            label18.TabIndex = 27;
            label18.Text = "Exámenes médicos activos";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new System.Drawing.Font("Segoe UI Semibold", 14F);
            label19.Location = new System.Drawing.Point(1, 186);
            label19.Name = "label19";
            label19.Size = new System.Drawing.Size(89, 25);
            label19.TabIndex = 31;
            label19.Text = "Histórico";
            // 
            // lvClFullname
            // 
            lvClFullname.Text = "Nombre completo";
            lvClFullname.Width = 150;
            // 
            // tvClPosition
            // 
            tvClPosition.Text = "Cargo";
            tvClPosition.Width = 120;
            // 
            // lvDriversList
            // 
            this.lvDriversList.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.lvDriversList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lvDriversList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            lvClFullname,
            tvClPosition,
            this.tvClPersonalId});
            this.lvDriversList.FullRowSelect = true;
            this.lvDriversList.HideSelection = false;
            this.lvDriversList.Location = new System.Drawing.Point(20, 115);
            this.lvDriversList.Name = "lvDriversList";
            this.lvDriversList.Size = new System.Drawing.Size(247, 340);
            this.lvDriversList.TabIndex = 0;
            this.lvDriversList.UseCompatibleStateImageBehavior = false;
            this.lvDriversList.View = System.Windows.Forms.View.Tile;
            this.lvDriversList.SelectedIndexChanged += new System.EventHandler(this.LvDriversList_SelectedIndexChanged);
            // 
            // tvClPersonalId
            // 
            this.tvClPersonalId.Text = "Carné de identidad";
            this.tvClPersonalId.Width = 100;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 24F);
            this.label1.ForeColor = System.Drawing.Color.ForestGreen;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(306, 45);
            this.label1.TabIndex = 1;
            this.label1.Text = "Control de choferes";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.TpDriverInfo);
            this.tabControl1.Controls.Add(this.TpDriverLicense);
            this.tabControl1.Controls.Add(this.TpRequalification);
            this.tabControl1.Controls.Add(this.TpMedicalExams);
            this.tabControl1.Location = new System.Drawing.Point(273, 93);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(524, 362);
            this.tabControl1.TabIndex = 2;
            // 
            // TpDriverInfo
            // 
            this.TpDriverInfo.Controls.Add(label10);
            this.TpDriverInfo.Controls.Add(this.btnSaveChanges);
            this.TpDriverInfo.Controls.Add(this.txtPersonalId);
            this.TpDriverInfo.Controls.Add(label4);
            this.TpDriverInfo.Controls.Add(this.txtPosition);
            this.TpDriverInfo.Controls.Add(label3);
            this.TpDriverInfo.Controls.Add(this.txtFullname);
            this.TpDriverInfo.Controls.Add(label2);
            this.TpDriverInfo.Location = new System.Drawing.Point(4, 22);
            this.TpDriverInfo.Name = "TpDriverInfo";
            this.TpDriverInfo.Padding = new System.Windows.Forms.Padding(3);
            this.TpDriverInfo.Size = new System.Drawing.Size(516, 336);
            this.TpDriverInfo.TabIndex = 0;
            this.TpDriverInfo.Text = "Información";
            this.TpDriverInfo.UseVisualStyleBackColor = true;
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.Location = new System.Drawing.Point(252, 129);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(99, 23);
            this.btnSaveChanges.TabIndex = 6;
            this.btnSaveChanges.Text = "&Guardar cambios";
            this.btnSaveChanges.UseVisualStyleBackColor = true;
            // 
            // txtPersonalId
            // 
            this.txtPersonalId.Location = new System.Drawing.Point(111, 101);
            this.txtPersonalId.Name = "txtPersonalId";
            this.txtPersonalId.Size = new System.Drawing.Size(240, 22);
            this.txtPersonalId.TabIndex = 5;
            // 
            // txtPosition
            // 
            this.txtPosition.Location = new System.Drawing.Point(111, 73);
            this.txtPosition.Name = "txtPosition";
            this.txtPosition.Size = new System.Drawing.Size(240, 22);
            this.txtPosition.TabIndex = 3;
            // 
            // txtFullname
            // 
            this.txtFullname.Location = new System.Drawing.Point(111, 45);
            this.txtFullname.Name = "txtFullname";
            this.txtFullname.Size = new System.Drawing.Size(240, 22);
            this.txtFullname.TabIndex = 1;
            // 
            // TpDriverLicense
            // 
            this.TpDriverLicense.Controls.Add(this.lbLicenseCreationDate);
            this.TpDriverLicense.Controls.Add(label9);
            this.TpDriverLicense.Controls.Add(this.dgvHistoricLicenses);
            this.TpDriverLicense.Controls.Add(label8);
            this.TpDriverLicense.Controls.Add(this.btnLicenseRenewal);
            this.TpDriverLicense.Controls.Add(this.dtLicenseExpires);
            this.TpDriverLicense.Controls.Add(label7);
            this.TpDriverLicense.Controls.Add(this.txtLicenseCategory);
            this.TpDriverLicense.Controls.Add(label6);
            this.TpDriverLicense.Controls.Add(this.txtLicenseNumber);
            this.TpDriverLicense.Controls.Add(label5);
            this.TpDriverLicense.Location = new System.Drawing.Point(4, 22);
            this.TpDriverLicense.Name = "TpDriverLicense";
            this.TpDriverLicense.Padding = new System.Windows.Forms.Padding(3);
            this.TpDriverLicense.Size = new System.Drawing.Size(516, 336);
            this.TpDriverLicense.TabIndex = 1;
            this.TpDriverLicense.Text = "Licencia de conducción";
            this.TpDriverLicense.UseVisualStyleBackColor = true;
            // 
            // lbLicenseCreationDate
            // 
            this.lbLicenseCreationDate.AutoSize = true;
            this.lbLicenseCreationDate.Location = new System.Drawing.Point(147, 21);
            this.lbLicenseCreationDate.Name = "lbLicenseCreationDate";
            this.lbLicenseCreationDate.Size = new System.Drawing.Size(107, 13);
            this.lbLicenseCreationDate.TabIndex = 13;
            this.lbLicenseCreationDate.Text = "Creada: dd/MM/yyyy";
            // 
            // dgvHistoricLicenses
            // 
            this.dgvHistoricLicenses.AllowUserToAddRows = false;
            this.dgvHistoricLicenses.AllowUserToDeleteRows = false;
            this.dgvHistoricLicenses.AllowUserToResizeRows = false;
            this.dgvHistoricLicenses.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvHistoricLicenses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHistoricLicenses.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clCreatedDate,
            this.clNumber,
            this.clCategory,
            this.clDateOfMaking,
            this.clExpires});
            this.dgvHistoricLicenses.Location = new System.Drawing.Point(11, 182);
            this.dgvHistoricLicenses.Name = "dgvHistoricLicenses";
            this.dgvHistoricLicenses.RowHeadersVisible = false;
            this.dgvHistoricLicenses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHistoricLicenses.Size = new System.Drawing.Size(499, 148);
            this.dgvHistoricLicenses.TabIndex = 11;
            // 
            // clCreatedDate
            // 
            this.clCreatedDate.HeaderText = "Creada";
            this.clCreatedDate.Name = "clCreatedDate";
            // 
            // clNumber
            // 
            this.clNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clNumber.HeaderText = "Número";
            this.clNumber.Name = "clNumber";
            this.clNumber.Width = 71;
            // 
            // clCategory
            // 
            this.clCategory.HeaderText = "Categoría";
            this.clCategory.Name = "clCategory";
            // 
            // clDateOfMaking
            // 
            this.clDateOfMaking.HeaderText = "Confeccionada";
            this.clDateOfMaking.Name = "clDateOfMaking";
            // 
            // clExpires
            // 
            this.clExpires.HeaderText = "Expira";
            this.clExpires.Name = "clExpires";
            // 
            // btnLicenseRenewal
            // 
            this.btnLicenseRenewal.Location = new System.Drawing.Point(258, 129);
            this.btnLicenseRenewal.Name = "btnLicenseRenewal";
            this.btnLicenseRenewal.Size = new System.Drawing.Size(99, 23);
            this.btnLicenseRenewal.TabIndex = 9;
            this.btnLicenseRenewal.Text = "&Renovar licencia...";
            this.btnLicenseRenewal.UseVisualStyleBackColor = true;
            this.btnLicenseRenewal.Click += new System.EventHandler(this.BtnLicenseRenewal_Click);
            // 
            // dtLicenseExpires
            // 
            this.dtLicenseExpires.Location = new System.Drawing.Point(117, 101);
            this.dtLicenseExpires.Name = "dtLicenseExpires";
            this.dtLicenseExpires.Size = new System.Drawing.Size(240, 22);
            this.dtLicenseExpires.TabIndex = 7;
            // 
            // txtLicenseCategory
            // 
            this.txtLicenseCategory.Location = new System.Drawing.Point(117, 73);
            this.txtLicenseCategory.Name = "txtLicenseCategory";
            this.txtLicenseCategory.Size = new System.Drawing.Size(240, 22);
            this.txtLicenseCategory.TabIndex = 5;
            // 
            // txtLicenseNumber
            // 
            this.txtLicenseNumber.Location = new System.Drawing.Point(117, 45);
            this.txtLicenseNumber.Name = "txtLicenseNumber";
            this.txtLicenseNumber.Size = new System.Drawing.Size(240, 22);
            this.txtLicenseNumber.TabIndex = 3;
            // 
            // TpRequalification
            // 
            this.TpRequalification.Controls.Add(this.btnRenewRequalification);
            this.TpRequalification.Controls.Add(label17);
            this.TpRequalification.Controls.Add(this.dgvRequalificationHistorical);
            this.TpRequalification.Controls.Add(label16);
            this.TpRequalification.Controls.Add(this.txtRequalificationPage);
            this.TpRequalification.Controls.Add(label15);
            this.TpRequalification.Controls.Add(this.txtRequalificationVolume);
            this.TpRequalification.Controls.Add(label14);
            this.TpRequalification.Controls.Add(this.dtRequalificationExpires);
            this.TpRequalification.Controls.Add(label13);
            this.TpRequalification.Controls.Add(this.dtRequalificationDateOfMaking);
            this.TpRequalification.Controls.Add(label11);
            this.TpRequalification.Controls.Add(this.lbRequalificationCreationDate);
            this.TpRequalification.Controls.Add(label12);
            this.TpRequalification.Location = new System.Drawing.Point(4, 22);
            this.TpRequalification.Name = "TpRequalification";
            this.TpRequalification.Padding = new System.Windows.Forms.Padding(3);
            this.TpRequalification.Size = new System.Drawing.Size(516, 336);
            this.TpRequalification.TabIndex = 2;
            this.TpRequalification.Text = "Recalificación";
            this.TpRequalification.UseVisualStyleBackColor = true;
            // 
            // btnRenewRequalification
            // 
            this.btnRenewRequalification.Location = new System.Drawing.Point(228, 136);
            this.btnRenewRequalification.Name = "btnRenewRequalification";
            this.btnRenewRequalification.Size = new System.Drawing.Size(129, 23);
            this.btnRenewRequalification.TabIndex = 27;
            this.btnRenewRequalification.Text = "&Renovar recalificación...";
            this.btnRenewRequalification.UseVisualStyleBackColor = true;
            // 
            // dgvRequalificationHistorical
            // 
            this.dgvRequalificationHistorical.AllowUserToAddRows = false;
            this.dgvRequalificationHistorical.AllowUserToDeleteRows = false;
            this.dgvRequalificationHistorical.AllowUserToResizeRows = false;
            this.dgvRequalificationHistorical.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvRequalificationHistorical.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRequalificationHistorical.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.clVolume,
            this.clPage});
            this.dgvRequalificationHistorical.Location = new System.Drawing.Point(11, 189);
            this.dgvRequalificationHistorical.Name = "dgvRequalificationHistorical";
            this.dgvRequalificationHistorical.RowHeadersVisible = false;
            this.dgvRequalificationHistorical.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRequalificationHistorical.Size = new System.Drawing.Size(499, 139);
            this.dgvRequalificationHistorical.TabIndex = 25;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Creada";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Confeccionada";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Expira";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // clVolume
            // 
            this.clVolume.HeaderText = "Tomo";
            this.clVolume.Name = "clVolume";
            // 
            // clPage
            // 
            this.clPage.HeaderText = "Folio";
            this.clPage.Name = "clPage";
            // 
            // txtRequalificationPage
            // 
            this.txtRequalificationPage.Location = new System.Drawing.Point(266, 108);
            this.txtRequalificationPage.Name = "txtRequalificationPage";
            this.txtRequalificationPage.Size = new System.Drawing.Size(62, 22);
            this.txtRequalificationPage.TabIndex = 23;
            // 
            // txtRequalificationVolume
            // 
            this.txtRequalificationVolume.Location = new System.Drawing.Point(157, 108);
            this.txtRequalificationVolume.Name = "txtRequalificationVolume";
            this.txtRequalificationVolume.Size = new System.Drawing.Size(62, 22);
            this.txtRequalificationVolume.TabIndex = 21;
            // 
            // dtRequalificationExpires
            // 
            this.dtRequalificationExpires.Location = new System.Drawing.Point(117, 80);
            this.dtRequalificationExpires.Name = "dtRequalificationExpires";
            this.dtRequalificationExpires.Size = new System.Drawing.Size(240, 22);
            this.dtRequalificationExpires.TabIndex = 19;
            // 
            // dtRequalificationDateOfMaking
            // 
            this.dtRequalificationDateOfMaking.Location = new System.Drawing.Point(117, 52);
            this.dtRequalificationDateOfMaking.Name = "dtRequalificationDateOfMaking";
            this.dtRequalificationDateOfMaking.Size = new System.Drawing.Size(240, 22);
            this.dtRequalificationDateOfMaking.TabIndex = 17;
            // 
            // lbRequalificationCreationDate
            // 
            this.lbRequalificationCreationDate.AutoSize = true;
            this.lbRequalificationCreationDate.Location = new System.Drawing.Point(197, 23);
            this.lbRequalificationCreationDate.Name = "lbRequalificationCreationDate";
            this.lbRequalificationCreationDate.Size = new System.Drawing.Size(107, 13);
            this.lbRequalificationCreationDate.TabIndex = 15;
            this.lbRequalificationCreationDate.Text = "Creada: dd/MM/yyyy";
            // 
            // TpMedicalExams
            // 
            this.TpMedicalExams.Controls.Add(this.dgvMedicalExamHistorical);
            this.TpMedicalExams.Controls.Add(label19);
            this.TpMedicalExams.Controls.Add(this.btnMedicalExamNew);
            this.TpMedicalExams.Controls.Add(this.btnMedicalExamDeleteSelected);
            this.TpMedicalExams.Controls.Add(this.btnMedicalExamArchiveSelected);
            this.TpMedicalExams.Controls.Add(label18);
            this.TpMedicalExams.Controls.Add(this.dgvMedicalExamActive);
            this.TpMedicalExams.Location = new System.Drawing.Point(4, 22);
            this.TpMedicalExams.Name = "TpMedicalExams";
            this.TpMedicalExams.Padding = new System.Windows.Forms.Padding(3);
            this.TpMedicalExams.Size = new System.Drawing.Size(516, 336);
            this.TpMedicalExams.TabIndex = 3;
            this.TpMedicalExams.Text = "Exámenes Médicos";
            this.TpMedicalExams.UseVisualStyleBackColor = true;
            // 
            // dgvMedicalExamHistorical
            // 
            this.dgvMedicalExamHistorical.AllowUserToAddRows = false;
            this.dgvMedicalExamHistorical.AllowUserToDeleteRows = false;
            this.dgvMedicalExamHistorical.AllowUserToResizeRows = false;
            this.dgvMedicalExamHistorical.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMedicalExamHistorical.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMedicalExamHistorical.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn7,
            this.clMedExamHType,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10});
            this.dgvMedicalExamHistorical.Location = new System.Drawing.Point(6, 214);
            this.dgvMedicalExamHistorical.Name = "dgvMedicalExamHistorical";
            this.dgvMedicalExamHistorical.RowHeadersVisible = false;
            this.dgvMedicalExamHistorical.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMedicalExamHistorical.Size = new System.Drawing.Size(504, 116);
            this.dgvMedicalExamHistorical.TabIndex = 32;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "Creado";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // clMedExamHType
            // 
            this.clMedExamHType.HeaderText = "Tipo";
            this.clMedExamHType.Name = "clMedExamHType";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.HeaderText = "Realizado";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.HeaderText = "Expira";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.HeaderText = "Resultado";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // btnMedicalExamNew
            // 
            this.btnMedicalExamNew.Location = new System.Drawing.Point(292, 160);
            this.btnMedicalExamNew.Name = "btnMedicalExamNew";
            this.btnMedicalExamNew.Size = new System.Drawing.Size(129, 23);
            this.btnMedicalExamNew.TabIndex = 29;
            this.btnMedicalExamNew.Text = "&Nuevo exámen...";
            this.btnMedicalExamNew.UseVisualStyleBackColor = true;
            // 
            // btnMedicalExamDeleteSelected
            // 
            this.btnMedicalExamDeleteSelected.Location = new System.Drawing.Point(6, 160);
            this.btnMedicalExamDeleteSelected.Name = "btnMedicalExamDeleteSelected";
            this.btnMedicalExamDeleteSelected.Size = new System.Drawing.Size(133, 23);
            this.btnMedicalExamDeleteSelected.TabIndex = 28;
            this.btnMedicalExamDeleteSelected.Text = "&Eliminar seleccionados...";
            this.btnMedicalExamDeleteSelected.UseVisualStyleBackColor = true;
            // 
            // btnMedicalExamArchiveSelected
            // 
            this.btnMedicalExamArchiveSelected.Location = new System.Drawing.Point(145, 160);
            this.btnMedicalExamArchiveSelected.Name = "btnMedicalExamArchiveSelected";
            this.btnMedicalExamArchiveSelected.Size = new System.Drawing.Size(141, 23);
            this.btnMedicalExamArchiveSelected.TabIndex = 28;
            this.btnMedicalExamArchiveSelected.Text = "&Archivar seleccionado(s)...";
            this.btnMedicalExamArchiveSelected.UseVisualStyleBackColor = true;
            // 
            // dgvMedicalExamActive
            // 
            this.dgvMedicalExamActive.AllowUserToAddRows = false;
            this.dgvMedicalExamActive.AllowUserToDeleteRows = false;
            this.dgvMedicalExamActive.AllowUserToResizeRows = false;
            this.dgvMedicalExamActive.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMedicalExamActive.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMedicalExamActive.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clIcon,
            this.dataGridViewTextBoxColumn2,
            this.clMedExamType,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn6,
            this.clMedExamResult});
            this.dgvMedicalExamActive.Location = new System.Drawing.Point(6, 49);
            this.dgvMedicalExamActive.Name = "dgvMedicalExamActive";
            this.dgvMedicalExamActive.RowHeadersVisible = false;
            this.dgvMedicalExamActive.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMedicalExamActive.Size = new System.Drawing.Size(504, 105);
            this.dgvMedicalExamActive.TabIndex = 26;
            // 
            // clIcon
            // 
            this.clIcon.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clIcon.HeaderText = "";
            this.clIcon.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.clIcon.Name = "clIcon";
            this.clIcon.Width = 5;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Creado";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // clMedExamType
            // 
            this.clMedExamType.HeaderText = "Tipo";
            this.clMedExamType.Name = "clMedExamType";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Realizado";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Expira";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // clMedExamResult
            // 
            this.clMedExamResult.HeaderText = "Resultado";
            this.clMedExamResult.Name = "clMedExamResult";
            // 
            // btnNewDriver
            // 
            this.btnNewDriver.Location = new System.Drawing.Point(20, 86);
            this.btnNewDriver.Name = "btnNewDriver";
            this.btnNewDriver.Size = new System.Drawing.Size(69, 23);
            this.btnNewDriver.TabIndex = 12;
            this.btnNewDriver.Text = "&Nuevo...";
            this.btnNewDriver.UseVisualStyleBackColor = true;
            this.btnNewDriver.Click += new System.EventHandler(this.BtnNewDriver_Click);
            // 
            // btnRefreshDrivers
            // 
            this.btnRefreshDrivers.Location = new System.Drawing.Point(95, 86);
            this.btnRefreshDrivers.Name = "btnRefreshDrivers";
            this.btnRefreshDrivers.Size = new System.Drawing.Size(69, 23);
            this.btnRefreshDrivers.TabIndex = 13;
            this.btnRefreshDrivers.Text = "&Actualizar";
            this.btnRefreshDrivers.UseVisualStyleBackColor = true;
            this.btnRefreshDrivers.Click += new System.EventHandler(this.BtnRefreshDrivers_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 467);
            this.Controls.Add(this.btnRefreshDrivers);
            this.Controls.Add(this.btnNewDriver);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lvDriversList);
            this.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimumSize = new System.Drawing.Size(742, 506);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMain";
            this.tabControl1.ResumeLayout(false);
            this.TpDriverInfo.ResumeLayout(false);
            this.TpDriverInfo.PerformLayout();
            this.TpDriverLicense.ResumeLayout(false);
            this.TpDriverLicense.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistoricLicenses)).EndInit();
            this.TpRequalification.ResumeLayout(false);
            this.TpRequalification.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRequalificationHistorical)).EndInit();
            this.TpMedicalExams.ResumeLayout(false);
            this.TpMedicalExams.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicalExamHistorical)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicalExamActive)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvDriversList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage TpDriverInfo;
        private System.Windows.Forms.TabPage TpDriverLicense;
        private System.Windows.Forms.TabPage TpRequalification;
        private System.Windows.Forms.TabPage TpMedicalExams;
        private System.Windows.Forms.TextBox txtPersonalId;
        private System.Windows.Forms.TextBox txtPosition;
        private System.Windows.Forms.TextBox txtFullname;
        private System.Windows.Forms.Button btnSaveChanges;
        private System.Windows.Forms.TextBox txtLicenseNumber;
        private System.Windows.Forms.TextBox txtLicenseCategory;
        private System.Windows.Forms.DateTimePicker dtLicenseExpires;
        private System.Windows.Forms.Button btnLicenseRenewal;
        private System.Windows.Forms.DataGridView dgvHistoricLicenses;
        private System.Windows.Forms.DataGridViewTextBoxColumn clCreatedDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn clNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn clCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn clDateOfMaking;
        private System.Windows.Forms.DataGridViewTextBoxColumn clExpires;
        private System.Windows.Forms.Label lbLicenseCreationDate;
        private System.Windows.Forms.Label lbRequalificationCreationDate;
        private System.Windows.Forms.DateTimePicker dtRequalificationExpires;
        private System.Windows.Forms.DateTimePicker dtRequalificationDateOfMaking;
        private System.Windows.Forms.TextBox txtRequalificationPage;
        private System.Windows.Forms.TextBox txtRequalificationVolume;
        private System.Windows.Forms.DataGridView dgvRequalificationHistorical;
        private System.Windows.Forms.Button btnRenewRequalification;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn clVolume;
        private System.Windows.Forms.DataGridViewTextBoxColumn clPage;
        private System.Windows.Forms.DataGridView dgvMedicalExamActive;
        private System.Windows.Forms.Button btnMedicalExamNew;
        private System.Windows.Forms.Button btnMedicalExamArchiveSelected;
        private System.Windows.Forms.Button btnMedicalExamDeleteSelected;
        private System.Windows.Forms.DataGridView dgvMedicalExamHistorical;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMedExamHType;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.Button btnNewDriver;
        private System.Windows.Forms.ColumnHeader tvClPersonalId;
        private System.Windows.Forms.Button btnRefreshDrivers;
        private System.Windows.Forms.DataGridViewImageColumn clIcon;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMedExamType;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMedExamResult;
    }
}