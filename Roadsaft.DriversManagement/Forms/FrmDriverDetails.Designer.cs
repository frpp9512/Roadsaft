namespace Roadsaft.DriversManagement
{
    partial class FrmDriverDetails
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
            System.Windows.Forms.Label label22;
            System.Windows.Forms.Label label10;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label21;
            System.Windows.Forms.Label label9;
            System.Windows.Forms.Label label8;
            System.Windows.Forms.Label label7;
            System.Windows.Forms.Label label6;
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label label20;
            System.Windows.Forms.Label label17;
            System.Windows.Forms.Label label16;
            System.Windows.Forms.Label label15;
            System.Windows.Forms.Label label14;
            System.Windows.Forms.Label label13;
            System.Windows.Forms.Label label11;
            System.Windows.Forms.Label label12;
            System.Windows.Forms.Label label19;
            System.Windows.Forms.Label label18;
            System.Windows.Forms.Label label23;
            System.Windows.Forms.Label label24;
            System.Windows.Forms.Label label25;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDriverDetails));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.TpDriverInfo = new System.Windows.Forms.TabPage();
            this.lbRegistered = new System.Windows.Forms.Label();
            this.cbxDriverCategory = new System.Windows.Forms.ComboBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtBirthday = new System.Windows.Forms.TextBox();
            this.txtPersonalId = new System.Windows.Forms.TextBox();
            this.txtPosition = new System.Windows.Forms.TextBox();
            this.txtFullname = new System.Windows.Forms.TextBox();
            this.TpDriverLicense = new System.Windows.Forms.TabPage();
            this.txtLicenseExpireDate = new System.Windows.Forms.TextBox();
            this.lbLicenseExpiration = new System.Windows.Forms.Label();
            this.txtDriverLicenseDescription = new System.Windows.Forms.TextBox();
            this.lbLicenseCreationDate = new System.Windows.Forms.Label();
            this.dgvHistoricLicenses = new System.Windows.Forms.DataGridView();
            this.clLArchived = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clCreatedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clDateOfMaking = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clExpires = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clLicenseDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmsHistory = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.eliminarRegistroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtLicenseCategory = new System.Windows.Forms.TextBox();
            this.txtLicenseNumber = new System.Windows.Forms.TextBox();
            this.TpRequalification = new System.Windows.Forms.TabPage();
            this.txtRequalificationExpires = new System.Windows.Forms.TextBox();
            this.txtRequalificationDateOfMaking = new System.Windows.Forms.TextBox();
            this.lbRequalificationExpire = new System.Windows.Forms.Label();
            this.txtRequalificationDescription = new System.Windows.Forms.TextBox();
            this.dgvRequalificationHistorical = new System.Windows.Forms.DataGridView();
            this.clRArchived = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clVolume = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clPage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clReqDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtRequalificationPage = new System.Windows.Forms.TextBox();
            this.txtRequalificationVolume = new System.Windows.Forms.TextBox();
            this.lbRequalificationCreationDate = new System.Windows.Forms.Label();
            this.TpMedicalExams = new System.Windows.Forms.TabPage();
            this.dgvMedicalExamHistorical = new System.Windows.Forms.DataGridView();
            this.clMeArchived = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clMedExamHType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clHMedExamDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvMedicalExamActive = new System.Windows.Forms.DataGridView();
            this.clIcon = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clMedExamType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clMedExamResult = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clMedExamDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.btnPrintDriverReport = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.btnRestoreGeneralInfo = new System.Windows.Forms.Button();
            this.btnSaveChanges = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnLicenseRenewal = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnRenewRequalification = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btnMedicalExamNew = new System.Windows.Forms.Button();
            this.btnMedicalExamArchiveSelected = new System.Windows.Forms.Button();
            label22 = new System.Windows.Forms.Label();
            label10 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label21 = new System.Windows.Forms.Label();
            label9 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label20 = new System.Windows.Forms.Label();
            label17 = new System.Windows.Forms.Label();
            label16 = new System.Windows.Forms.Label();
            label15 = new System.Windows.Forms.Label();
            label14 = new System.Windows.Forms.Label();
            label13 = new System.Windows.Forms.Label();
            label11 = new System.Windows.Forms.Label();
            label12 = new System.Windows.Forms.Label();
            label19 = new System.Windows.Forms.Label();
            label18 = new System.Windows.Forms.Label();
            label23 = new System.Windows.Forms.Label();
            label24 = new System.Windows.Forms.Label();
            label25 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.TpDriverInfo.SuspendLayout();
            this.TpDriverLicense.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistoricLicenses)).BeginInit();
            this.cmsHistory.SuspendLayout();
            this.TpRequalification.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRequalificationHistorical)).BeginInit();
            this.TpMedicalExams.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicalExamHistorical)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicalExamActive)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new System.Drawing.Point(6, 207);
            label22.Name = "label22";
            label22.Size = new System.Drawing.Size(63, 13);
            label22.TabIndex = 30;
            label22.Text = "Descripción:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new System.Drawing.Font("Segoe UI Semibold", 14F);
            label10.Location = new System.Drawing.Point(62, 6);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(186, 25);
            label10.TabIndex = 11;
            label10.Text = "Información general";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(6, 96);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(38, 13);
            label4.TabIndex = 4;
            label4.Text = "Cargo:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(6, 124);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(99, 13);
            label3.TabIndex = 2;
            label3.Text = "Carné de identidad:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(6, 68);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(94, 13);
            label2.TabIndex = 0;
            label2.Text = "Nombre completo:";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new System.Drawing.Point(7, 164);
            label21.Name = "label21";
            label21.Size = new System.Drawing.Size(63, 13);
            label21.TabIndex = 30;
            label21.Text = "Descripción:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new System.Drawing.Font("Segoe UI Semibold", 14F);
            label9.Location = new System.Drawing.Point(6, 233);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(89, 25);
            label9.TabIndex = 12;
            label9.Text = "Histórico";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new System.Drawing.Font("Segoe UI Semibold", 14F);
            label8.Location = new System.Drawing.Point(64, 6);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(136, 25);
            label8.TabIndex = 10;
            label8.Text = "Licencia activa";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(8, 123);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(103, 13);
            label7.TabIndex = 6;
            label7.Text = "Fecha de expiración:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(8, 95);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(65, 13);
            label6.TabIndex = 4;
            label6.Text = "Categoría(s):";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(8, 67);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(100, 13);
            label5.TabIndex = 2;
            label5.Text = "Número de licencia:";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new System.Drawing.Point(8, 163);
            label20.Name = "label20";
            label20.Size = new System.Drawing.Size(63, 13);
            label20.TabIndex = 28;
            label20.Text = "Descripción:";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new System.Drawing.Font("Segoe UI Semibold", 14F);
            label17.Location = new System.Drawing.Point(6, 234);
            label17.Name = "label17";
            label17.Size = new System.Drawing.Size(89, 25);
            label17.TabIndex = 26;
            label17.Text = "Histórico";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new System.Drawing.Point(8, 135);
            label16.Name = "label16";
            label16.Size = new System.Drawing.Size(46, 13);
            label16.TabIndex = 24;
            label16.Text = "Registro:";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new System.Drawing.Point(223, 135);
            label15.Name = "label15";
            label15.Size = new System.Drawing.Size(30, 13);
            label15.TabIndex = 22;
            label15.Text = "Folio:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new System.Drawing.Point(114, 135);
            label14.Name = "label14";
            label14.Size = new System.Drawing.Size(35, 13);
            label14.TabIndex = 20;
            label14.Text = "Tomo:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new System.Drawing.Point(8, 94);
            label13.Name = "label13";
            label13.Size = new System.Drawing.Size(103, 13);
            label13.TabIndex = 18;
            label13.Text = "Fecha de expiración:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new System.Drawing.Point(8, 66);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(83, 13);
            label11.TabIndex = 16;
            label11.Text = "Fecha realizada:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new System.Drawing.Font("Segoe UI Semibold", 14F);
            label12.Location = new System.Drawing.Point(64, 6);
            label12.Name = "label12";
            label12.Size = new System.Drawing.Size(185, 25);
            label12.TabIndex = 14;
            label12.Text = "Recalificación activa";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new System.Drawing.Font("Segoe UI Semibold", 14F);
            label19.Location = new System.Drawing.Point(1, 188);
            label19.Name = "label19";
            label19.Size = new System.Drawing.Size(89, 25);
            label19.TabIndex = 31;
            label19.Text = "Histórico";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new System.Drawing.Font("Segoe UI Semibold", 14F);
            label18.Location = new System.Drawing.Point(59, 6);
            label18.Name = "label18";
            label18.Size = new System.Drawing.Size(239, 25);
            label18.TabIndex = 27;
            label18.Text = "Exámenes médicos activos";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Location = new System.Drawing.Point(6, 179);
            label23.Name = "label23";
            label23.Size = new System.Drawing.Size(67, 13);
            label23.TabIndex = 2;
            label23.Text = "Cumpleaños:";
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Location = new System.Drawing.Point(246, 179);
            label24.Name = "label24";
            label24.Size = new System.Drawing.Size(33, 13);
            label24.TabIndex = 33;
            label24.Text = "Edad:";
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Location = new System.Drawing.Point(6, 152);
            label25.Name = "label25";
            label25.Size = new System.Drawing.Size(55, 13);
            label25.TabIndex = 35;
            label25.Text = "Categoría:";
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
            this.tabControl1.Location = new System.Drawing.Point(12, 86);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(730, 395);
            this.tabControl1.TabIndex = 3;
            // 
            // TpDriverInfo
            // 
            this.TpDriverInfo.Controls.Add(this.pictureBox4);
            this.TpDriverInfo.Controls.Add(this.btnRestoreGeneralInfo);
            this.TpDriverInfo.Controls.Add(this.lbRegistered);
            this.TpDriverInfo.Controls.Add(this.cbxDriverCategory);
            this.TpDriverInfo.Controls.Add(label25);
            this.TpDriverInfo.Controls.Add(this.txtAge);
            this.TpDriverInfo.Controls.Add(label24);
            this.TpDriverInfo.Controls.Add(this.txtDescription);
            this.TpDriverInfo.Controls.Add(label22);
            this.TpDriverInfo.Controls.Add(label10);
            this.TpDriverInfo.Controls.Add(this.btnSaveChanges);
            this.TpDriverInfo.Controls.Add(this.txtBirthday);
            this.TpDriverInfo.Controls.Add(this.txtPersonalId);
            this.TpDriverInfo.Controls.Add(label4);
            this.TpDriverInfo.Controls.Add(this.txtPosition);
            this.TpDriverInfo.Controls.Add(label23);
            this.TpDriverInfo.Controls.Add(label3);
            this.TpDriverInfo.Controls.Add(this.txtFullname);
            this.TpDriverInfo.Controls.Add(label2);
            this.TpDriverInfo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TpDriverInfo.Location = new System.Drawing.Point(4, 22);
            this.TpDriverInfo.Name = "TpDriverInfo";
            this.TpDriverInfo.Padding = new System.Windows.Forms.Padding(3);
            this.TpDriverInfo.Size = new System.Drawing.Size(722, 369);
            this.TpDriverInfo.TabIndex = 0;
            this.TpDriverInfo.Text = "Información";
            this.TpDriverInfo.UseVisualStyleBackColor = true;
            // 
            // lbRegistered
            // 
            this.lbRegistered.AutoSize = true;
            this.lbRegistered.Location = new System.Drawing.Point(64, 31);
            this.lbRegistered.Name = "lbRegistered";
            this.lbRegistered.Size = new System.Drawing.Size(58, 13);
            this.lbRegistered.TabIndex = 37;
            this.lbRegistered.Text = "Registrado:";
            // 
            // cbxDriverCategory
            // 
            this.cbxDriverCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxDriverCategory.FormattingEnabled = true;
            this.cbxDriverCategory.Location = new System.Drawing.Point(111, 149);
            this.cbxDriverCategory.Name = "cbxDriverCategory";
            this.cbxDriverCategory.Size = new System.Drawing.Size(240, 21);
            this.cbxDriverCategory.TabIndex = 3;
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(285, 176);
            this.txtAge.Name = "txtAge";
            this.txtAge.ReadOnly = true;
            this.txtAge.Size = new System.Drawing.Size(66, 22);
            this.txtAge.TabIndex = 5;
            this.txtAge.TabStop = false;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(111, 204);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(240, 45);
            this.txtDescription.TabIndex = 6;
            // 
            // txtBirthday
            // 
            this.txtBirthday.Location = new System.Drawing.Point(111, 176);
            this.txtBirthday.Name = "txtBirthday";
            this.txtBirthday.ReadOnly = true;
            this.txtBirthday.Size = new System.Drawing.Size(106, 22);
            this.txtBirthday.TabIndex = 4;
            this.txtBirthday.TabStop = false;
            // 
            // txtPersonalId
            // 
            this.txtPersonalId.Location = new System.Drawing.Point(111, 121);
            this.txtPersonalId.Name = "txtPersonalId";
            this.txtPersonalId.Size = new System.Drawing.Size(240, 22);
            this.txtPersonalId.TabIndex = 2;
            // 
            // txtPosition
            // 
            this.txtPosition.Location = new System.Drawing.Point(111, 93);
            this.txtPosition.Name = "txtPosition";
            this.txtPosition.Size = new System.Drawing.Size(240, 22);
            this.txtPosition.TabIndex = 1;
            // 
            // txtFullname
            // 
            this.txtFullname.Location = new System.Drawing.Point(111, 65);
            this.txtFullname.Name = "txtFullname";
            this.txtFullname.Size = new System.Drawing.Size(240, 22);
            this.txtFullname.TabIndex = 0;
            // 
            // TpDriverLicense
            // 
            this.TpDriverLicense.Controls.Add(this.pictureBox1);
            this.TpDriverLicense.Controls.Add(this.txtLicenseExpireDate);
            this.TpDriverLicense.Controls.Add(this.lbLicenseExpiration);
            this.TpDriverLicense.Controls.Add(this.txtDriverLicenseDescription);
            this.TpDriverLicense.Controls.Add(label21);
            this.TpDriverLicense.Controls.Add(this.lbLicenseCreationDate);
            this.TpDriverLicense.Controls.Add(label9);
            this.TpDriverLicense.Controls.Add(this.dgvHistoricLicenses);
            this.TpDriverLicense.Controls.Add(label8);
            this.TpDriverLicense.Controls.Add(label7);
            this.TpDriverLicense.Controls.Add(this.txtLicenseCategory);
            this.TpDriverLicense.Controls.Add(label6);
            this.TpDriverLicense.Controls.Add(this.txtLicenseNumber);
            this.TpDriverLicense.Controls.Add(label5);
            this.TpDriverLicense.Controls.Add(this.btnLicenseRenewal);
            this.TpDriverLicense.Location = new System.Drawing.Point(4, 22);
            this.TpDriverLicense.Name = "TpDriverLicense";
            this.TpDriverLicense.Padding = new System.Windows.Forms.Padding(3);
            this.TpDriverLicense.Size = new System.Drawing.Size(722, 369);
            this.TpDriverLicense.TabIndex = 1;
            this.TpDriverLicense.Text = "Licencia de conducción";
            this.TpDriverLicense.UseVisualStyleBackColor = true;
            // 
            // txtLicenseExpireDate
            // 
            this.txtLicenseExpireDate.Location = new System.Drawing.Point(117, 120);
            this.txtLicenseExpireDate.Name = "txtLicenseExpireDate";
            this.txtLicenseExpireDate.ReadOnly = true;
            this.txtLicenseExpireDate.Size = new System.Drawing.Size(240, 22);
            this.txtLicenseExpireDate.TabIndex = 33;
            // 
            // lbLicenseExpiration
            // 
            this.lbLicenseExpiration.AutoSize = true;
            this.lbLicenseExpiration.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLicenseExpiration.Location = new System.Drawing.Point(114, 145);
            this.lbLicenseExpiration.Name = "lbLicenseExpiration";
            this.lbLicenseExpiration.Size = new System.Drawing.Size(206, 13);
            this.lbLicenseExpiration.TabIndex = 32;
            this.lbLicenseExpiration.Text = "Faltan X días para que expire la licencia.";
            // 
            // txtDriverLicenseDescription
            // 
            this.txtDriverLicenseDescription.Location = new System.Drawing.Point(117, 161);
            this.txtDriverLicenseDescription.Multiline = true;
            this.txtDriverLicenseDescription.Name = "txtDriverLicenseDescription";
            this.txtDriverLicenseDescription.ReadOnly = true;
            this.txtDriverLicenseDescription.Size = new System.Drawing.Size(240, 45);
            this.txtDriverLicenseDescription.TabIndex = 31;
            // 
            // lbLicenseCreationDate
            // 
            this.lbLicenseCreationDate.AutoSize = true;
            this.lbLicenseCreationDate.Location = new System.Drawing.Point(66, 31);
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
            this.dgvHistoricLicenses.BackgroundColor = System.Drawing.Color.White;
            this.dgvHistoricLicenses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHistoricLicenses.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clLArchived,
            this.clCreatedDate,
            this.clNumber,
            this.clCategory,
            this.clDateOfMaking,
            this.clExpires,
            this.clLicenseDescription});
            this.dgvHistoricLicenses.Location = new System.Drawing.Point(11, 261);
            this.dgvHistoricLicenses.MultiSelect = false;
            this.dgvHistoricLicenses.Name = "dgvHistoricLicenses";
            this.dgvHistoricLicenses.ReadOnly = true;
            this.dgvHistoricLicenses.RowHeadersVisible = false;
            this.dgvHistoricLicenses.RowTemplate.ContextMenuStrip = this.cmsHistory;
            this.dgvHistoricLicenses.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.MediumSeaGreen;
            this.dgvHistoricLicenses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHistoricLicenses.Size = new System.Drawing.Size(705, 102);
            this.dgvHistoricLicenses.TabIndex = 11;
            this.dgvHistoricLicenses.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.SelectOnRightClick);
            // 
            // clLArchived
            // 
            this.clLArchived.HeaderText = "Archivada";
            this.clLArchived.Name = "clLArchived";
            this.clLArchived.ReadOnly = true;
            // 
            // clCreatedDate
            // 
            this.clCreatedDate.HeaderText = "Registrada";
            this.clCreatedDate.Name = "clCreatedDate";
            this.clCreatedDate.ReadOnly = true;
            // 
            // clNumber
            // 
            this.clNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clNumber.HeaderText = "Número";
            this.clNumber.Name = "clNumber";
            this.clNumber.ReadOnly = true;
            this.clNumber.Width = 71;
            // 
            // clCategory
            // 
            this.clCategory.HeaderText = "Categoría";
            this.clCategory.Name = "clCategory";
            this.clCategory.ReadOnly = true;
            // 
            // clDateOfMaking
            // 
            this.clDateOfMaking.HeaderText = "Confeccionada";
            this.clDateOfMaking.Name = "clDateOfMaking";
            this.clDateOfMaking.ReadOnly = true;
            // 
            // clExpires
            // 
            this.clExpires.HeaderText = "Expira";
            this.clExpires.Name = "clExpires";
            this.clExpires.ReadOnly = true;
            // 
            // clLicenseDescription
            // 
            this.clLicenseDescription.HeaderText = "Descripción";
            this.clLicenseDescription.Name = "clLicenseDescription";
            this.clLicenseDescription.ReadOnly = true;
            // 
            // cmsHistory
            // 
            this.cmsHistory.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eliminarRegistroToolStripMenuItem});
            this.cmsHistory.Name = "cmsHistory";
            this.cmsHistory.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.cmsHistory.Size = new System.Drawing.Size(170, 26);
            // 
            // eliminarRegistroToolStripMenuItem
            // 
            this.eliminarRegistroToolStripMenuItem.Name = "eliminarRegistroToolStripMenuItem";
            this.eliminarRegistroToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.eliminarRegistroToolStripMenuItem.Text = "&Eliminar registro...";
            this.eliminarRegistroToolStripMenuItem.Click += new System.EventHandler(this.EliminarRegistroToolStripMenuItem_Click);
            // 
            // txtLicenseCategory
            // 
            this.txtLicenseCategory.Location = new System.Drawing.Point(117, 92);
            this.txtLicenseCategory.Name = "txtLicenseCategory";
            this.txtLicenseCategory.ReadOnly = true;
            this.txtLicenseCategory.Size = new System.Drawing.Size(240, 22);
            this.txtLicenseCategory.TabIndex = 5;
            // 
            // txtLicenseNumber
            // 
            this.txtLicenseNumber.Location = new System.Drawing.Point(117, 64);
            this.txtLicenseNumber.Name = "txtLicenseNumber";
            this.txtLicenseNumber.ReadOnly = true;
            this.txtLicenseNumber.Size = new System.Drawing.Size(240, 22);
            this.txtLicenseNumber.TabIndex = 3;
            // 
            // TpRequalification
            // 
            this.TpRequalification.Controls.Add(this.pictureBox2);
            this.TpRequalification.Controls.Add(this.txtRequalificationExpires);
            this.TpRequalification.Controls.Add(this.txtRequalificationDateOfMaking);
            this.TpRequalification.Controls.Add(this.lbRequalificationExpire);
            this.TpRequalification.Controls.Add(this.txtRequalificationDescription);
            this.TpRequalification.Controls.Add(label20);
            this.TpRequalification.Controls.Add(label17);
            this.TpRequalification.Controls.Add(this.dgvRequalificationHistorical);
            this.TpRequalification.Controls.Add(label16);
            this.TpRequalification.Controls.Add(this.txtRequalificationPage);
            this.TpRequalification.Controls.Add(label15);
            this.TpRequalification.Controls.Add(this.txtRequalificationVolume);
            this.TpRequalification.Controls.Add(label14);
            this.TpRequalification.Controls.Add(label13);
            this.TpRequalification.Controls.Add(label11);
            this.TpRequalification.Controls.Add(this.lbRequalificationCreationDate);
            this.TpRequalification.Controls.Add(label12);
            this.TpRequalification.Controls.Add(this.btnRenewRequalification);
            this.TpRequalification.Location = new System.Drawing.Point(4, 22);
            this.TpRequalification.Name = "TpRequalification";
            this.TpRequalification.Padding = new System.Windows.Forms.Padding(3);
            this.TpRequalification.Size = new System.Drawing.Size(722, 369);
            this.TpRequalification.TabIndex = 2;
            this.TpRequalification.Text = "Recalificación";
            this.TpRequalification.UseVisualStyleBackColor = true;
            // 
            // txtRequalificationExpires
            // 
            this.txtRequalificationExpires.Location = new System.Drawing.Point(117, 91);
            this.txtRequalificationExpires.Name = "txtRequalificationExpires";
            this.txtRequalificationExpires.ReadOnly = true;
            this.txtRequalificationExpires.Size = new System.Drawing.Size(240, 22);
            this.txtRequalificationExpires.TabIndex = 34;
            // 
            // txtRequalificationDateOfMaking
            // 
            this.txtRequalificationDateOfMaking.Location = new System.Drawing.Point(117, 63);
            this.txtRequalificationDateOfMaking.Name = "txtRequalificationDateOfMaking";
            this.txtRequalificationDateOfMaking.ReadOnly = true;
            this.txtRequalificationDateOfMaking.Size = new System.Drawing.Size(240, 22);
            this.txtRequalificationDateOfMaking.TabIndex = 34;
            // 
            // lbRequalificationExpire
            // 
            this.lbRequalificationExpire.AutoSize = true;
            this.lbRequalificationExpire.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRequalificationExpire.Location = new System.Drawing.Point(114, 116);
            this.lbRequalificationExpire.Name = "lbRequalificationExpire";
            this.lbRequalificationExpire.Size = new System.Drawing.Size(206, 13);
            this.lbRequalificationExpire.TabIndex = 33;
            this.lbRequalificationExpire.Text = "Faltan X días para que expire la licencia.";
            // 
            // txtRequalificationDescription
            // 
            this.txtRequalificationDescription.Location = new System.Drawing.Point(117, 160);
            this.txtRequalificationDescription.Multiline = true;
            this.txtRequalificationDescription.Name = "txtRequalificationDescription";
            this.txtRequalificationDescription.ReadOnly = true;
            this.txtRequalificationDescription.Size = new System.Drawing.Size(240, 45);
            this.txtRequalificationDescription.TabIndex = 29;
            // 
            // dgvRequalificationHistorical
            // 
            this.dgvRequalificationHistorical.AllowUserToAddRows = false;
            this.dgvRequalificationHistorical.AllowUserToDeleteRows = false;
            this.dgvRequalificationHistorical.AllowUserToResizeRows = false;
            this.dgvRequalificationHistorical.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvRequalificationHistorical.BackgroundColor = System.Drawing.Color.White;
            this.dgvRequalificationHistorical.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRequalificationHistorical.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clRArchived,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.clVolume,
            this.clPage,
            this.clReqDescription});
            this.dgvRequalificationHistorical.Location = new System.Drawing.Point(11, 262);
            this.dgvRequalificationHistorical.MultiSelect = false;
            this.dgvRequalificationHistorical.Name = "dgvRequalificationHistorical";
            this.dgvRequalificationHistorical.ReadOnly = true;
            this.dgvRequalificationHistorical.RowHeadersVisible = false;
            this.dgvRequalificationHistorical.RowTemplate.ContextMenuStrip = this.cmsHistory;
            this.dgvRequalificationHistorical.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.MediumSeaGreen;
            this.dgvRequalificationHistorical.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRequalificationHistorical.Size = new System.Drawing.Size(705, 101);
            this.dgvRequalificationHistorical.TabIndex = 25;
            this.dgvRequalificationHistorical.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.SelectOnRightClick);
            // 
            // clRArchived
            // 
            this.clRArchived.HeaderText = "Archivada";
            this.clRArchived.Name = "clRArchived";
            this.clRArchived.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Creada";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Confeccionada";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Expira";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // clVolume
            // 
            this.clVolume.HeaderText = "Tomo";
            this.clVolume.Name = "clVolume";
            this.clVolume.ReadOnly = true;
            // 
            // clPage
            // 
            this.clPage.HeaderText = "Folio";
            this.clPage.Name = "clPage";
            this.clPage.ReadOnly = true;
            // 
            // clReqDescription
            // 
            this.clReqDescription.HeaderText = "Descripción";
            this.clReqDescription.Name = "clReqDescription";
            this.clReqDescription.ReadOnly = true;
            // 
            // txtRequalificationPage
            // 
            this.txtRequalificationPage.Location = new System.Drawing.Point(264, 132);
            this.txtRequalificationPage.Name = "txtRequalificationPage";
            this.txtRequalificationPage.ReadOnly = true;
            this.txtRequalificationPage.Size = new System.Drawing.Size(62, 22);
            this.txtRequalificationPage.TabIndex = 23;
            // 
            // txtRequalificationVolume
            // 
            this.txtRequalificationVolume.Location = new System.Drawing.Point(155, 132);
            this.txtRequalificationVolume.Name = "txtRequalificationVolume";
            this.txtRequalificationVolume.ReadOnly = true;
            this.txtRequalificationVolume.Size = new System.Drawing.Size(62, 22);
            this.txtRequalificationVolume.TabIndex = 21;
            // 
            // lbRequalificationCreationDate
            // 
            this.lbRequalificationCreationDate.AutoSize = true;
            this.lbRequalificationCreationDate.Location = new System.Drawing.Point(66, 31);
            this.lbRequalificationCreationDate.Name = "lbRequalificationCreationDate";
            this.lbRequalificationCreationDate.Size = new System.Drawing.Size(107, 13);
            this.lbRequalificationCreationDate.TabIndex = 15;
            this.lbRequalificationCreationDate.Text = "Creada: dd/MM/yyyy";
            // 
            // TpMedicalExams
            // 
            this.TpMedicalExams.Controls.Add(this.pictureBox3);
            this.TpMedicalExams.Controls.Add(this.dgvMedicalExamHistorical);
            this.TpMedicalExams.Controls.Add(label19);
            this.TpMedicalExams.Controls.Add(label18);
            this.TpMedicalExams.Controls.Add(this.dgvMedicalExamActive);
            this.TpMedicalExams.Controls.Add(this.btnMedicalExamNew);
            this.TpMedicalExams.Controls.Add(this.btnMedicalExamArchiveSelected);
            this.TpMedicalExams.Location = new System.Drawing.Point(4, 22);
            this.TpMedicalExams.Name = "TpMedicalExams";
            this.TpMedicalExams.Padding = new System.Windows.Forms.Padding(3);
            this.TpMedicalExams.Size = new System.Drawing.Size(722, 369);
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
            this.dgvMedicalExamHistorical.BackgroundColor = System.Drawing.Color.White;
            this.dgvMedicalExamHistorical.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMedicalExamHistorical.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clMeArchived,
            this.dataGridViewTextBoxColumn7,
            this.clMedExamHType,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.clHMedExamDescription});
            this.dgvMedicalExamHistorical.Location = new System.Drawing.Point(6, 216);
            this.dgvMedicalExamHistorical.MultiSelect = false;
            this.dgvMedicalExamHistorical.Name = "dgvMedicalExamHistorical";
            this.dgvMedicalExamHistorical.ReadOnly = true;
            this.dgvMedicalExamHistorical.RowHeadersVisible = false;
            this.dgvMedicalExamHistorical.RowTemplate.ContextMenuStrip = this.cmsHistory;
            this.dgvMedicalExamHistorical.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.MediumSeaGreen;
            this.dgvMedicalExamHistorical.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMedicalExamHistorical.Size = new System.Drawing.Size(710, 147);
            this.dgvMedicalExamHistorical.TabIndex = 32;
            this.dgvMedicalExamHistorical.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.SelectOnRightClick);
            // 
            // clMeArchived
            // 
            this.clMeArchived.HeaderText = "Archivado";
            this.clMeArchived.Name = "clMeArchived";
            this.clMeArchived.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "Registrado";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // clMedExamHType
            // 
            this.clMedExamHType.HeaderText = "Tipo";
            this.clMedExamHType.Name = "clMedExamHType";
            this.clMedExamHType.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.HeaderText = "Realizado";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.HeaderText = "Expira";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.HeaderText = "Resultado";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // clHMedExamDescription
            // 
            this.clHMedExamDescription.HeaderText = "Descripción";
            this.clHMedExamDescription.Name = "clHMedExamDescription";
            this.clHMedExamDescription.ReadOnly = true;
            // 
            // dgvMedicalExamActive
            // 
            this.dgvMedicalExamActive.AllowUserToAddRows = false;
            this.dgvMedicalExamActive.AllowUserToDeleteRows = false;
            this.dgvMedicalExamActive.AllowUserToResizeRows = false;
            this.dgvMedicalExamActive.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMedicalExamActive.BackgroundColor = System.Drawing.Color.White;
            this.dgvMedicalExamActive.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMedicalExamActive.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clIcon,
            this.dataGridViewTextBoxColumn2,
            this.clMedExamType,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn6,
            this.clMedExamResult,
            this.clMedExamDescription});
            this.dgvMedicalExamActive.Location = new System.Drawing.Point(6, 50);
            this.dgvMedicalExamActive.Name = "dgvMedicalExamActive";
            this.dgvMedicalExamActive.ReadOnly = true;
            this.dgvMedicalExamActive.RowHeadersVisible = false;
            this.dgvMedicalExamActive.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.MediumSeaGreen;
            this.dgvMedicalExamActive.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMedicalExamActive.Size = new System.Drawing.Size(710, 105);
            this.dgvMedicalExamActive.TabIndex = 26;
            // 
            // clIcon
            // 
            this.clIcon.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clIcon.HeaderText = "";
            this.clIcon.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.clIcon.Name = "clIcon";
            this.clIcon.ReadOnly = true;
            this.clIcon.Width = 5;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Creado";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // clMedExamType
            // 
            this.clMedExamType.HeaderText = "Tipo";
            this.clMedExamType.Name = "clMedExamType";
            this.clMedExamType.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Realizado";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn6.HeaderText = "Expira";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 61;
            // 
            // clMedExamResult
            // 
            this.clMedExamResult.HeaderText = "Resultado";
            this.clMedExamResult.Name = "clMedExamResult";
            this.clMedExamResult.ReadOnly = true;
            // 
            // clMedExamDescription
            // 
            this.clMedExamDescription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.clMedExamDescription.HeaderText = "Descripción";
            this.clMedExamDescription.Name = "clMedExamDescription";
            this.clMedExamDescription.ReadOnly = true;
            this.clMedExamDescription.Width = 86;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 24F);
            this.label1.ForeColor = System.Drawing.Color.ForestGreen;
            this.label1.Location = new System.Drawing.Point(87, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(290, 45);
            this.label1.TabIndex = 4;
            this.label1.Text = "Detalles del chofer";
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::Roadsaft.DriversManagement.Properties.Resources.opendetails;
            this.pictureBox5.Location = new System.Drawing.Point(12, 12);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(69, 68);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 16;
            this.pictureBox5.TabStop = false;
            // 
            // btnPrintDriverReport
            // 
            this.btnPrintDriverReport.FlatAppearance.BorderColor = System.Drawing.Color.MediumSeaGreen;
            this.btnPrintDriverReport.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightGreen;
            this.btnPrintDriverReport.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SeaGreen;
            this.btnPrintDriverReport.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleGreen;
            this.btnPrintDriverReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrintDriverReport.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintDriverReport.Image = global::Roadsaft.DriversManagement.Properties.Resources.print_blank_verysmall;
            this.btnPrintDriverReport.Location = new System.Drawing.Point(623, 39);
            this.btnPrintDriverReport.Name = "btnPrintDriverReport";
            this.btnPrintDriverReport.Size = new System.Drawing.Size(115, 28);
            this.btnPrintDriverReport.TabIndex = 14;
            this.btnPrintDriverReport.Text = "&Imprimir ficha...";
            this.btnPrintDriverReport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPrintDriverReport.UseVisualStyleBackColor = true;
            this.btnPrintDriverReport.Click += new System.EventHandler(this.BtnPrintDriverReport_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Roadsaft.DriversManagement.Properties.Resources.generalinfo;
            this.pictureBox4.Location = new System.Drawing.Point(9, 6);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(47, 38);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 38;
            this.pictureBox4.TabStop = false;
            // 
            // btnRestoreGeneralInfo
            // 
            this.btnRestoreGeneralInfo.FlatAppearance.BorderColor = System.Drawing.Color.MediumSeaGreen;
            this.btnRestoreGeneralInfo.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightGreen;
            this.btnRestoreGeneralInfo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SeaGreen;
            this.btnRestoreGeneralInfo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleGreen;
            this.btnRestoreGeneralInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestoreGeneralInfo.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestoreGeneralInfo.Image = global::Roadsaft.DriversManagement.Properties.Resources.restore_verysmall;
            this.btnRestoreGeneralInfo.Location = new System.Drawing.Point(111, 255);
            this.btnRestoreGeneralInfo.Name = "btnRestoreGeneralInfo";
            this.btnRestoreGeneralInfo.Size = new System.Drawing.Size(85, 28);
            this.btnRestoreGeneralInfo.TabIndex = 7;
            this.btnRestoreGeneralInfo.Text = "&Restaurar";
            this.btnRestoreGeneralInfo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRestoreGeneralInfo.UseVisualStyleBackColor = true;
            this.btnRestoreGeneralInfo.Click += new System.EventHandler(this.BtnRestoreGeneralInfo_Click);
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.FlatAppearance.BorderColor = System.Drawing.Color.MediumSeaGreen;
            this.btnSaveChanges.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightGreen;
            this.btnSaveChanges.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SeaGreen;
            this.btnSaveChanges.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleGreen;
            this.btnSaveChanges.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveChanges.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveChanges.Image = global::Roadsaft.DriversManagement.Properties.Resources.save_verysmall;
            this.btnSaveChanges.Location = new System.Drawing.Point(227, 255);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(124, 28);
            this.btnSaveChanges.TabIndex = 8;
            this.btnSaveChanges.Text = "&Guardar cambios";
            this.btnSaveChanges.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSaveChanges.UseVisualStyleBackColor = true;
            this.btnSaveChanges.Click += new System.EventHandler(this.BtnSaveChanges_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Roadsaft.DriversManagement.Properties.Resources.driver_license;
            this.pictureBox1.Location = new System.Drawing.Point(11, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(47, 38);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 34;
            this.pictureBox1.TabStop = false;
            // 
            // btnLicenseRenewal
            // 
            this.btnLicenseRenewal.FlatAppearance.BorderColor = System.Drawing.Color.MediumSeaGreen;
            this.btnLicenseRenewal.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SeaGreen;
            this.btnLicenseRenewal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleGreen;
            this.btnLicenseRenewal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLicenseRenewal.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnLicenseRenewal.Image = global::Roadsaft.DriversManagement.Properties.Resources.driver_license_add_verysmall;
            this.btnLicenseRenewal.Location = new System.Drawing.Point(227, 212);
            this.btnLicenseRenewal.Name = "btnLicenseRenewal";
            this.btnLicenseRenewal.Size = new System.Drawing.Size(130, 28);
            this.btnLicenseRenewal.TabIndex = 9;
            this.btnLicenseRenewal.Text = "&Renovar licencia...";
            this.btnLicenseRenewal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLicenseRenewal.UseVisualStyleBackColor = true;
            this.btnLicenseRenewal.Click += new System.EventHandler(this.BtnLicenseRenewal_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Roadsaft.DriversManagement.Properties.Resources.requalification;
            this.pictureBox2.Location = new System.Drawing.Point(11, 6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(47, 38);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 35;
            this.pictureBox2.TabStop = false;
            // 
            // btnRenewRequalification
            // 
            this.btnRenewRequalification.FlatAppearance.BorderColor = System.Drawing.Color.MediumSeaGreen;
            this.btnRenewRequalification.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SeaGreen;
            this.btnRenewRequalification.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleGreen;
            this.btnRenewRequalification.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRenewRequalification.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnRenewRequalification.Image = global::Roadsaft.DriversManagement.Properties.Resources.requalification_add_verysmall;
            this.btnRenewRequalification.Location = new System.Drawing.Point(202, 211);
            this.btnRenewRequalification.Name = "btnRenewRequalification";
            this.btnRenewRequalification.Size = new System.Drawing.Size(155, 27);
            this.btnRenewRequalification.TabIndex = 27;
            this.btnRenewRequalification.Text = "&Renovar recalificación...";
            this.btnRenewRequalification.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRenewRequalification.UseVisualStyleBackColor = true;
            this.btnRenewRequalification.Click += new System.EventHandler(this.BtnRenewRequalification_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Roadsaft.DriversManagement.Properties.Resources.medcheck;
            this.pictureBox3.Location = new System.Drawing.Point(6, 6);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(47, 38);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 36;
            this.pictureBox3.TabStop = false;
            // 
            // btnMedicalExamNew
            // 
            this.btnMedicalExamNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMedicalExamNew.FlatAppearance.BorderColor = System.Drawing.Color.MediumSeaGreen;
            this.btnMedicalExamNew.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightGreen;
            this.btnMedicalExamNew.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SeaGreen;
            this.btnMedicalExamNew.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleGreen;
            this.btnMedicalExamNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMedicalExamNew.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnMedicalExamNew.Image = global::Roadsaft.DriversManagement.Properties.Resources.medcheck_add_verysmall;
            this.btnMedicalExamNew.Location = new System.Drawing.Point(419, 161);
            this.btnMedicalExamNew.Name = "btnMedicalExamNew";
            this.btnMedicalExamNew.Size = new System.Drawing.Size(122, 28);
            this.btnMedicalExamNew.TabIndex = 29;
            this.btnMedicalExamNew.Text = "&Nuevo exámen...";
            this.btnMedicalExamNew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMedicalExamNew.UseVisualStyleBackColor = true;
            this.btnMedicalExamNew.Click += new System.EventHandler(this.BtnMedicalExamNew_Click);
            // 
            // btnMedicalExamArchiveSelected
            // 
            this.btnMedicalExamArchiveSelected.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMedicalExamArchiveSelected.FlatAppearance.BorderColor = System.Drawing.Color.MediumSeaGreen;
            this.btnMedicalExamArchiveSelected.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightGreen;
            this.btnMedicalExamArchiveSelected.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SeaGreen;
            this.btnMedicalExamArchiveSelected.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleGreen;
            this.btnMedicalExamArchiveSelected.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMedicalExamArchiveSelected.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnMedicalExamArchiveSelected.Image = global::Roadsaft.DriversManagement.Properties.Resources.archive_verysmall;
            this.btnMedicalExamArchiveSelected.Location = new System.Drawing.Point(547, 161);
            this.btnMedicalExamArchiveSelected.Name = "btnMedicalExamArchiveSelected";
            this.btnMedicalExamArchiveSelected.Size = new System.Drawing.Size(169, 28);
            this.btnMedicalExamArchiveSelected.TabIndex = 28;
            this.btnMedicalExamArchiveSelected.Text = "&Archivar seleccionado(s)...";
            this.btnMedicalExamArchiveSelected.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMedicalExamArchiveSelected.UseVisualStyleBackColor = true;
            this.btnMedicalExamArchiveSelected.Click += new System.EventHandler(this.BtnMedicalExamArchiveSelected_Click);
            // 
            // FrmDriverDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 493);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.btnPrintDriverReport);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmDriverDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Detalles del chofer";
            this.Load += new System.EventHandler(this.FrmDriverDetails_Load);
            this.tabControl1.ResumeLayout(false);
            this.TpDriverInfo.ResumeLayout(false);
            this.TpDriverInfo.PerformLayout();
            this.TpDriverLicense.ResumeLayout(false);
            this.TpDriverLicense.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistoricLicenses)).EndInit();
            this.cmsHistory.ResumeLayout(false);
            this.TpRequalification.ResumeLayout(false);
            this.TpRequalification.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRequalificationHistorical)).EndInit();
            this.TpMedicalExams.ResumeLayout(false);
            this.TpMedicalExams.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicalExamHistorical)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicalExamActive)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage TpDriverInfo;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Button btnSaveChanges;
        private System.Windows.Forms.TextBox txtPersonalId;
        private System.Windows.Forms.TextBox txtPosition;
        private System.Windows.Forms.TextBox txtFullname;
        private System.Windows.Forms.TabPage TpDriverLicense;
        private System.Windows.Forms.TextBox txtLicenseExpireDate;
        private System.Windows.Forms.Label lbLicenseExpiration;
        private System.Windows.Forms.TextBox txtDriverLicenseDescription;
        private System.Windows.Forms.Label lbLicenseCreationDate;
        private System.Windows.Forms.DataGridView dgvHistoricLicenses;
        private System.Windows.Forms.Button btnLicenseRenewal;
        private System.Windows.Forms.TextBox txtLicenseCategory;
        private System.Windows.Forms.TextBox txtLicenseNumber;
        private System.Windows.Forms.TabPage TpRequalification;
        private System.Windows.Forms.TextBox txtRequalificationExpires;
        private System.Windows.Forms.TextBox txtRequalificationDateOfMaking;
        private System.Windows.Forms.Label lbRequalificationExpire;
        private System.Windows.Forms.TextBox txtRequalificationDescription;
        private System.Windows.Forms.Button btnRenewRequalification;
        private System.Windows.Forms.DataGridView dgvRequalificationHistorical;
        private System.Windows.Forms.TextBox txtRequalificationPage;
        private System.Windows.Forms.TextBox txtRequalificationVolume;
        private System.Windows.Forms.Label lbRequalificationCreationDate;
        private System.Windows.Forms.TabPage TpMedicalExams;
        private System.Windows.Forms.DataGridView dgvMedicalExamHistorical;
        private System.Windows.Forms.Button btnMedicalExamNew;
        private System.Windows.Forms.Button btnMedicalExamArchiveSelected;
        private System.Windows.Forms.DataGridView dgvMedicalExamActive;
        private System.Windows.Forms.DataGridViewImageColumn clIcon;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMedExamType;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMedExamResult;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMedExamDescription;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtBirthday;
        private System.Windows.Forms.DataGridViewTextBoxColumn clRArchived;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn clVolume;
        private System.Windows.Forms.DataGridViewTextBoxColumn clPage;
        private System.Windows.Forms.DataGridViewTextBoxColumn clReqDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn clLArchived;
        private System.Windows.Forms.DataGridViewTextBoxColumn clCreatedDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn clNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn clCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn clDateOfMaking;
        private System.Windows.Forms.DataGridViewTextBoxColumn clExpires;
        private System.Windows.Forms.DataGridViewTextBoxColumn clLicenseDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMeArchived;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMedExamHType;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn clHMedExamDescription;
        private System.Windows.Forms.ComboBox cbxDriverCategory;
        private System.Windows.Forms.ContextMenuStrip cmsHistory;
        private System.Windows.Forms.ToolStripMenuItem eliminarRegistroToolStripMenuItem;
        private System.Windows.Forms.Label lbRegistered;
        private System.Windows.Forms.Button btnRestoreGeneralInfo;
        private System.Windows.Forms.Button btnPrintDriverReport;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
    }
}