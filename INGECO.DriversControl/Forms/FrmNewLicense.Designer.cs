namespace INGECO.DriversControl
{
    partial class FrmNewLicense
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
            System.Windows.Forms.Label label8;
            System.Windows.Forms.Label label7;
            System.Windows.Forms.Label label6;
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label label1;
            this.btnLicenseRenewal = new System.Windows.Forms.Button();
            this.dtLicenseExpires = new System.Windows.Forms.DateTimePicker();
            this.txtLicenseCategory = new System.Windows.Forms.TextBox();
            this.txtLicenseNumber = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.dtDateOfMaking = new System.Windows.Forms.DateTimePicker();
            label8 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new System.Drawing.Font("Segoe UI Semibold", 14F);
            label8.Location = new System.Drawing.Point(12, 9);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(266, 25);
            label8.TabIndex = 21;
            label8.Text = "Nueva licencia de conducción";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(15, 129);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(103, 13);
            label7.TabIndex = 18;
            label7.Text = "Fecha de expiración:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(15, 73);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(65, 13);
            label6.TabIndex = 16;
            label6.Text = "Categoría(s):";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(15, 45);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(100, 13);
            label5.TabIndex = 14;
            label5.Text = "Número de licencia:";
            // 
            // btnLicenseRenewal
            // 
            this.btnLicenseRenewal.Location = new System.Drawing.Point(190, 154);
            this.btnLicenseRenewal.Name = "btnLicenseRenewal";
            this.btnLicenseRenewal.Size = new System.Drawing.Size(84, 23);
            this.btnLicenseRenewal.TabIndex = 3;
            this.btnLicenseRenewal.Text = "&Crear";
            this.btnLicenseRenewal.UseVisualStyleBackColor = true;
            this.btnLicenseRenewal.Click += new System.EventHandler(this.BtnLicenseRenewal_Click);
            // 
            // dtLicenseExpires
            // 
            this.dtLicenseExpires.Location = new System.Drawing.Point(124, 126);
            this.dtLicenseExpires.Name = "dtLicenseExpires";
            this.dtLicenseExpires.Size = new System.Drawing.Size(240, 22);
            this.dtLicenseExpires.TabIndex = 2;
            // 
            // txtLicenseCategory
            // 
            this.txtLicenseCategory.Location = new System.Drawing.Point(124, 70);
            this.txtLicenseCategory.Name = "txtLicenseCategory";
            this.txtLicenseCategory.Size = new System.Drawing.Size(240, 22);
            this.txtLicenseCategory.TabIndex = 1;
            // 
            // txtLicenseNumber
            // 
            this.txtLicenseNumber.Location = new System.Drawing.Point(124, 42);
            this.txtLicenseNumber.Name = "txtLicenseNumber";
            this.txtLicenseNumber.Size = new System.Drawing.Size(240, 22);
            this.txtLicenseNumber.TabIndex = 0;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(280, 154);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(84, 23);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "&Cancelar";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // dtDateOfMaking
            // 
            this.dtDateOfMaking.Location = new System.Drawing.Point(124, 98);
            this.dtDateOfMaking.Name = "dtDateOfMaking";
            this.dtDateOfMaking.Size = new System.Drawing.Size(240, 22);
            this.dtDateOfMaking.TabIndex = 22;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(15, 101);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(105, 13);
            label1.TabIndex = 23;
            label1.Text = "Fecha de confección:";
            // 
            // FrmNewLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 186);
            this.Controls.Add(this.dtDateOfMaking);
            this.Controls.Add(label1);
            this.Controls.Add(label8);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnLicenseRenewal);
            this.Controls.Add(this.dtLicenseExpires);
            this.Controls.Add(label7);
            this.Controls.Add(this.txtLicenseCategory);
            this.Controls.Add(label6);
            this.Controls.Add(this.txtLicenseNumber);
            this.Controls.Add(label5);
            this.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmNewLicense";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Nueva licencia";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnLicenseRenewal;
        private System.Windows.Forms.DateTimePicker dtLicenseExpires;
        private System.Windows.Forms.TextBox txtLicenseCategory;
        private System.Windows.Forms.TextBox txtLicenseNumber;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DateTimePicker dtDateOfMaking;
    }
}