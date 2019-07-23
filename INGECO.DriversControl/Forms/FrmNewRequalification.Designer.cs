namespace INGECO.DriversControl
{
    partial class FrmNewRequalification
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
            System.Windows.Forms.Label label16;
            System.Windows.Forms.Label label15;
            System.Windows.Forms.Label label14;
            System.Windows.Forms.Label label13;
            System.Windows.Forms.Label label11;
            System.Windows.Forms.Label label12;
            this.txtRequalificationPage = new System.Windows.Forms.TextBox();
            this.txtRequalificationVolume = new System.Windows.Forms.TextBox();
            this.dtRequalificationExpires = new System.Windows.Forms.DateTimePicker();
            this.dtRequalificationDateOfMaking = new System.Windows.Forms.DateTimePicker();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnLicenseRenewal = new System.Windows.Forms.Button();
            label16 = new System.Windows.Forms.Label();
            label15 = new System.Windows.Forms.Label();
            label14 = new System.Windows.Forms.Label();
            label13 = new System.Windows.Forms.Label();
            label11 = new System.Windows.Forms.Label();
            label12 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new System.Drawing.Point(14, 106);
            label16.Name = "label16";
            label16.Size = new System.Drawing.Size(46, 13);
            label16.TabIndex = 38;
            label16.Text = "Registro:";
            // 
            // txtRequalificationPage
            // 
            this.txtRequalificationPage.Location = new System.Drawing.Point(272, 103);
            this.txtRequalificationPage.Name = "txtRequalificationPage";
            this.txtRequalificationPage.Size = new System.Drawing.Size(62, 22);
            this.txtRequalificationPage.TabIndex = 37;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new System.Drawing.Point(231, 106);
            label15.Name = "label15";
            label15.Size = new System.Drawing.Size(30, 13);
            label15.TabIndex = 36;
            label15.Text = "Folio:";
            // 
            // txtRequalificationVolume
            // 
            this.txtRequalificationVolume.Location = new System.Drawing.Point(163, 103);
            this.txtRequalificationVolume.Name = "txtRequalificationVolume";
            this.txtRequalificationVolume.Size = new System.Drawing.Size(62, 22);
            this.txtRequalificationVolume.TabIndex = 35;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new System.Drawing.Point(122, 106);
            label14.Name = "label14";
            label14.Size = new System.Drawing.Size(35, 13);
            label14.TabIndex = 34;
            label14.Text = "Tomo:";
            // 
            // dtRequalificationExpires
            // 
            this.dtRequalificationExpires.Location = new System.Drawing.Point(123, 75);
            this.dtRequalificationExpires.Name = "dtRequalificationExpires";
            this.dtRequalificationExpires.Size = new System.Drawing.Size(240, 22);
            this.dtRequalificationExpires.TabIndex = 33;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new System.Drawing.Point(14, 78);
            label13.Name = "label13";
            label13.Size = new System.Drawing.Size(103, 13);
            label13.TabIndex = 32;
            label13.Text = "Fecha de expiración:";
            // 
            // dtRequalificationDateOfMaking
            // 
            this.dtRequalificationDateOfMaking.Location = new System.Drawing.Point(123, 47);
            this.dtRequalificationDateOfMaking.Name = "dtRequalificationDateOfMaking";
            this.dtRequalificationDateOfMaking.Size = new System.Drawing.Size(240, 22);
            this.dtRequalificationDateOfMaking.TabIndex = 31;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new System.Drawing.Point(14, 50);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(83, 13);
            label11.TabIndex = 30;
            label11.Text = "Fecha realizada:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new System.Drawing.Font("Segoe UI Semibold", 14F);
            label12.Location = new System.Drawing.Point(12, 9);
            label12.Name = "label12";
            label12.Size = new System.Drawing.Size(186, 25);
            label12.TabIndex = 28;
            label12.Text = "Nueva recalificación";
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(279, 131);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(84, 23);
            this.btnCancel.TabIndex = 39;
            this.btnCancel.Text = "&Cancelar";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnLicenseRenewal
            // 
            this.btnLicenseRenewal.Location = new System.Drawing.Point(189, 131);
            this.btnLicenseRenewal.Name = "btnLicenseRenewal";
            this.btnLicenseRenewal.Size = new System.Drawing.Size(84, 23);
            this.btnLicenseRenewal.TabIndex = 40;
            this.btnLicenseRenewal.Text = "&Crear";
            this.btnLicenseRenewal.UseVisualStyleBackColor = true;
            // 
            // FrmNewRequalification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 165);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnLicenseRenewal);
            this.Controls.Add(label16);
            this.Controls.Add(this.txtRequalificationPage);
            this.Controls.Add(label15);
            this.Controls.Add(this.txtRequalificationVolume);
            this.Controls.Add(label14);
            this.Controls.Add(this.dtRequalificationExpires);
            this.Controls.Add(label13);
            this.Controls.Add(this.dtRequalificationDateOfMaking);
            this.Controls.Add(label11);
            this.Controls.Add(label12);
            this.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmNewRequalification";
            this.Text = "Nueva recalificación";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtRequalificationPage;
        private System.Windows.Forms.TextBox txtRequalificationVolume;
        private System.Windows.Forms.DateTimePicker dtRequalificationExpires;
        private System.Windows.Forms.DateTimePicker dtRequalificationDateOfMaking;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnLicenseRenewal;
    }
}