namespace INGECO.DriversControl
{
    partial class FrmConfiguration
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
            System.Windows.Forms.Label label11;
            System.Windows.Forms.Label label12;
            System.Windows.Forms.Label label13;
            System.Windows.Forms.Label label14;
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpGeneral = new System.Windows.Forms.TabPage();
            this.nudMedExamsTimePeriod = new System.Windows.Forms.NumericUpDown();
            this.nudRequalificationTimePeriod = new System.Windows.Forms.NumericUpDown();
            this.nudLicenseTimePeriod = new System.Windows.Forms.NumericUpDown();
            this.nudRefreshTime = new System.Windows.Forms.NumericUpDown();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtDatabaseName = new System.Windows.Forms.TextBox();
            this.txtDatabasePassword = new System.Windows.Forms.TextBox();
            this.txtDatabaseUser = new System.Windows.Forms.TextBox();
            this.txtDatabaseHost = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            label9 = new System.Windows.Forms.Label();
            label10 = new System.Windows.Forms.Label();
            label11 = new System.Windows.Forms.Label();
            label12 = new System.Windows.Forms.Label();
            label13 = new System.Windows.Forms.Label();
            label14 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tpGeneral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMedExamsTimePeriod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRequalificationTimePeriod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLicenseTimePeriod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRefreshTime)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(19, 18);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(48, 13);
            label2.TabIndex = 1;
            label2.Text = "Servidor:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(19, 46);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(44, 13);
            label3.TabIndex = 1;
            label3.Text = "Usuario:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(19, 74);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(63, 13);
            label4.TabIndex = 1;
            label4.Text = "Contraseña:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(19, 102);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(74, 13);
            label5.TabIndex = 1;
            label5.Text = "Base de datos:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(19, 20);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(81, 13);
            label6.TabIndex = 2;
            label6.Text = "Actualizar cada:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(164, 20);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(45, 13);
            label7.TabIndex = 4;
            label7.Text = "minutos.";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(19, 56);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(118, 13);
            label8.TabIndex = 5;
            label8.Text = "Tiempos de alerta para:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new System.Drawing.Point(204, 83);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(27, 13);
            label9.TabIndex = 8;
            label9.Text = "días.";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new System.Drawing.Point(19, 83);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(121, 13);
            label10.TabIndex = 6;
            label10.Text = "Licencias de conducción:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new System.Drawing.Point(204, 111);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(25, 13);
            label11.TabIndex = 11;
            label11.Text = "días";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new System.Drawing.Point(19, 111);
            label12.Name = "label12";
            label12.Size = new System.Drawing.Size(71, 13);
            label12.TabIndex = 9;
            label12.Text = "Recalificación:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new System.Drawing.Point(19, 139);
            label13.Name = "label13";
            label13.Size = new System.Drawing.Size(97, 13);
            label13.TabIndex = 9;
            label13.Text = "Chequeos médicos:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new System.Drawing.Point(204, 139);
            label14.Name = "label14";
            label14.Size = new System.Drawing.Size(25, 13);
            label14.TabIndex = 11;
            label14.Text = "días";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tpGeneral);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 72);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(369, 229);
            this.tabControl1.TabIndex = 0;
            // 
            // tpGeneral
            // 
            this.tpGeneral.Controls.Add(label14);
            this.tpGeneral.Controls.Add(label11);
            this.tpGeneral.Controls.Add(this.nudMedExamsTimePeriod);
            this.tpGeneral.Controls.Add(label13);
            this.tpGeneral.Controls.Add(this.nudRequalificationTimePeriod);
            this.tpGeneral.Controls.Add(label12);
            this.tpGeneral.Controls.Add(label9);
            this.tpGeneral.Controls.Add(this.nudLicenseTimePeriod);
            this.tpGeneral.Controls.Add(label10);
            this.tpGeneral.Controls.Add(label8);
            this.tpGeneral.Controls.Add(label7);
            this.tpGeneral.Controls.Add(this.nudRefreshTime);
            this.tpGeneral.Controls.Add(label6);
            this.tpGeneral.Location = new System.Drawing.Point(4, 22);
            this.tpGeneral.Name = "tpGeneral";
            this.tpGeneral.Padding = new System.Windows.Forms.Padding(3);
            this.tpGeneral.Size = new System.Drawing.Size(361, 203);
            this.tpGeneral.TabIndex = 0;
            this.tpGeneral.Text = "General";
            this.tpGeneral.UseVisualStyleBackColor = true;
            // 
            // nudMedExamsTimePeriod
            // 
            this.nudMedExamsTimePeriod.Location = new System.Drawing.Point(146, 137);
            this.nudMedExamsTimePeriod.Name = "nudMedExamsTimePeriod";
            this.nudMedExamsTimePeriod.Size = new System.Drawing.Size(52, 22);
            this.nudMedExamsTimePeriod.TabIndex = 3;
            // 
            // nudRequalificationTimePeriod
            // 
            this.nudRequalificationTimePeriod.Location = new System.Drawing.Point(146, 109);
            this.nudRequalificationTimePeriod.Name = "nudRequalificationTimePeriod";
            this.nudRequalificationTimePeriod.Size = new System.Drawing.Size(52, 22);
            this.nudRequalificationTimePeriod.TabIndex = 2;
            // 
            // nudLicenseTimePeriod
            // 
            this.nudLicenseTimePeriod.Location = new System.Drawing.Point(146, 81);
            this.nudLicenseTimePeriod.Name = "nudLicenseTimePeriod";
            this.nudLicenseTimePeriod.Size = new System.Drawing.Size(52, 22);
            this.nudLicenseTimePeriod.TabIndex = 1;
            // 
            // nudRefreshTime
            // 
            this.nudRefreshTime.Location = new System.Drawing.Point(106, 18);
            this.nudRefreshTime.Name = "nudRefreshTime";
            this.nudRefreshTime.Size = new System.Drawing.Size(52, 22);
            this.nudRefreshTime.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(label5);
            this.tabPage2.Controls.Add(label4);
            this.tabPage2.Controls.Add(label3);
            this.tabPage2.Controls.Add(label2);
            this.tabPage2.Controls.Add(this.txtDatabaseName);
            this.tabPage2.Controls.Add(this.txtDatabasePassword);
            this.tabPage2.Controls.Add(this.txtDatabaseUser);
            this.tabPage2.Controls.Add(this.txtDatabaseHost);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(361, 203);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Base de datos";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtDatabaseName
            // 
            this.txtDatabaseName.Location = new System.Drawing.Point(99, 99);
            this.txtDatabaseName.Name = "txtDatabaseName";
            this.txtDatabaseName.Size = new System.Drawing.Size(185, 22);
            this.txtDatabaseName.TabIndex = 3;
            // 
            // txtDatabasePassword
            // 
            this.txtDatabasePassword.Location = new System.Drawing.Point(99, 71);
            this.txtDatabasePassword.Name = "txtDatabasePassword";
            this.txtDatabasePassword.Size = new System.Drawing.Size(185, 22);
            this.txtDatabasePassword.TabIndex = 2;
            this.txtDatabasePassword.UseSystemPasswordChar = true;
            // 
            // txtDatabaseUser
            // 
            this.txtDatabaseUser.Location = new System.Drawing.Point(99, 43);
            this.txtDatabaseUser.Name = "txtDatabaseUser";
            this.txtDatabaseUser.Size = new System.Drawing.Size(185, 22);
            this.txtDatabaseUser.TabIndex = 1;
            // 
            // txtDatabaseHost
            // 
            this.txtDatabaseHost.Location = new System.Drawing.Point(99, 15);
            this.txtDatabaseHost.Name = "txtDatabaseHost";
            this.txtDatabaseHost.Size = new System.Drawing.Size(185, 22);
            this.txtDatabaseHost.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 24F);
            this.label1.ForeColor = System.Drawing.Color.ForestGreen;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 45);
            this.label1.TabIndex = 2;
            this.label1.Text = "Configuración";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(306, 303);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "&Cerrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(225, 303);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "&Guardar";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // FrmConfiguration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 336);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmConfiguration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configuración";
            this.tabControl1.ResumeLayout(false);
            this.tpGeneral.ResumeLayout(false);
            this.tpGeneral.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMedExamsTimePeriod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRequalificationTimePeriod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLicenseTimePeriod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRefreshTime)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpGeneral;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDatabaseUser;
        private System.Windows.Forms.TextBox txtDatabaseHost;
        private System.Windows.Forms.TextBox txtDatabasePassword;
        private System.Windows.Forms.TextBox txtDatabaseName;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.NumericUpDown nudRefreshTime;
        private System.Windows.Forms.NumericUpDown nudRequalificationTimePeriod;
        private System.Windows.Forms.NumericUpDown nudLicenseTimePeriod;
        private System.Windows.Forms.NumericUpDown nudMedExamsTimePeriod;
    }
}