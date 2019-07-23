namespace INGECO.DriversControl
{
    partial class FrmNewDriver
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
            System.Windows.Forms.Label label10;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label2;
            this.txtPersonalId = new System.Windows.Forms.TextBox();
            this.txtPosition = new System.Windows.Forms.TextBox();
            this.txtFullname = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnLicenseRenewal = new System.Windows.Forms.Button();
            label10 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new System.Drawing.Font("Segoe UI Semibold", 14F);
            label10.Location = new System.Drawing.Point(12, 9);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(129, 25);
            label10.TabIndex = 19;
            label10.Text = "Nuevo chofer";
            // 
            // txtPersonalId
            // 
            this.txtPersonalId.Location = new System.Drawing.Point(120, 100);
            this.txtPersonalId.Name = "txtPersonalId";
            this.txtPersonalId.Size = new System.Drawing.Size(240, 22);
            this.txtPersonalId.TabIndex = 17;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(15, 75);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(38, 13);
            label4.TabIndex = 16;
            label4.Text = "Cargo:";
            // 
            // txtPosition
            // 
            this.txtPosition.Location = new System.Drawing.Point(120, 72);
            this.txtPosition.Name = "txtPosition";
            this.txtPosition.Size = new System.Drawing.Size(240, 22);
            this.txtPosition.TabIndex = 15;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(15, 103);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(99, 13);
            label3.TabIndex = 14;
            label3.Text = "Carné de identidad:";
            // 
            // txtFullname
            // 
            this.txtFullname.Location = new System.Drawing.Point(120, 44);
            this.txtFullname.Name = "txtFullname";
            this.txtFullname.Size = new System.Drawing.Size(240, 22);
            this.txtFullname.TabIndex = 13;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(15, 47);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(94, 13);
            label2.TabIndex = 12;
            label2.Text = "Nombre completo:";
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(276, 128);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(84, 23);
            this.btnCancel.TabIndex = 21;
            this.btnCancel.Text = "&Cancelar";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnLicenseRenewal
            // 
            this.btnLicenseRenewal.Location = new System.Drawing.Point(186, 128);
            this.btnLicenseRenewal.Name = "btnLicenseRenewal";
            this.btnLicenseRenewal.Size = new System.Drawing.Size(84, 23);
            this.btnLicenseRenewal.TabIndex = 22;
            this.btnLicenseRenewal.Text = "&Crear";
            this.btnLicenseRenewal.UseVisualStyleBackColor = true;
            // 
            // FrmNewDriver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 164);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnLicenseRenewal);
            this.Controls.Add(label10);
            this.Controls.Add(this.txtPersonalId);
            this.Controls.Add(label4);
            this.Controls.Add(this.txtPosition);
            this.Controls.Add(label3);
            this.Controls.Add(this.txtFullname);
            this.Controls.Add(label2);
            this.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmNewDriver";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Nuevo chofer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtPersonalId;
        private System.Windows.Forms.TextBox txtPosition;
        private System.Windows.Forms.TextBox txtFullname;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnLicenseRenewal;
    }
}