namespace INGECO.DriversControl
{
    partial class FrmNewMedicalExam
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
            System.Windows.Forms.Label label13;
            System.Windows.Forms.Label label11;
            System.Windows.Forms.Label label18;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            this.dtMedicalExamExpires = new System.Windows.Forms.DateTimePicker();
            this.dtMedicalExamDateOfMaking = new System.Windows.Forms.DateTimePicker();
            this.cbxMedicalExamType = new System.Windows.Forms.ComboBox();
            this.cbxMedicalExamResult = new System.Windows.Forms.ComboBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnLicenseRenewal = new System.Windows.Forms.Button();
            label13 = new System.Windows.Forms.Label();
            label11 = new System.Windows.Forms.Label();
            label18 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dtMedicalExamExpires
            // 
            this.dtMedicalExamExpires.Location = new System.Drawing.Point(130, 75);
            this.dtMedicalExamExpires.Name = "dtMedicalExamExpires";
            this.dtMedicalExamExpires.Size = new System.Drawing.Size(240, 22);
            this.dtMedicalExamExpires.TabIndex = 37;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new System.Drawing.Point(14, 78);
            label13.Name = "label13";
            label13.Size = new System.Drawing.Size(103, 13);
            label13.TabIndex = 36;
            label13.Text = "Fecha de expiración:";
            // 
            // dtMedicalExamDateOfMaking
            // 
            this.dtMedicalExamDateOfMaking.Location = new System.Drawing.Point(130, 47);
            this.dtMedicalExamDateOfMaking.Name = "dtMedicalExamDateOfMaking";
            this.dtMedicalExamDateOfMaking.Size = new System.Drawing.Size(240, 22);
            this.dtMedicalExamDateOfMaking.TabIndex = 35;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new System.Drawing.Point(14, 50);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(83, 13);
            label11.TabIndex = 34;
            label11.Text = "Fecha realizado:";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new System.Drawing.Font("Segoe UI Semibold", 14F);
            label18.Location = new System.Drawing.Point(12, 9);
            label18.Name = "label18";
            label18.Size = new System.Drawing.Size(210, 25);
            label18.TabIndex = 38;
            label18.Text = "Nuevo examen médico";
            // 
            // cbxMedicalExamType
            // 
            this.cbxMedicalExamType.FormattingEnabled = true;
            this.cbxMedicalExamType.Location = new System.Drawing.Point(130, 103);
            this.cbxMedicalExamType.Name = "cbxMedicalExamType";
            this.cbxMedicalExamType.Size = new System.Drawing.Size(240, 21);
            this.cbxMedicalExamType.TabIndex = 39;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(14, 106);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(85, 13);
            label1.TabIndex = 40;
            label1.Text = "Tipo de examen:";
            // 
            // cbxMedicalExamResult
            // 
            this.cbxMedicalExamResult.FormattingEnabled = true;
            this.cbxMedicalExamResult.Location = new System.Drawing.Point(130, 130);
            this.cbxMedicalExamResult.Name = "cbxMedicalExamResult";
            this.cbxMedicalExamResult.Size = new System.Drawing.Size(240, 21);
            this.cbxMedicalExamResult.TabIndex = 39;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(12, 133);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(112, 13);
            label2.TabIndex = 40;
            label2.Text = "Resultado del exámen:";
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(286, 157);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(84, 23);
            this.btnCancel.TabIndex = 41;
            this.btnCancel.Text = "&Cancelar";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnLicenseRenewal
            // 
            this.btnLicenseRenewal.Location = new System.Drawing.Point(196, 157);
            this.btnLicenseRenewal.Name = "btnLicenseRenewal";
            this.btnLicenseRenewal.Size = new System.Drawing.Size(84, 23);
            this.btnLicenseRenewal.TabIndex = 42;
            this.btnLicenseRenewal.Text = "&Crear";
            this.btnLicenseRenewal.UseVisualStyleBackColor = true;
            // 
            // FrmNewMedicalExam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 190);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnLicenseRenewal);
            this.Controls.Add(label2);
            this.Controls.Add(label1);
            this.Controls.Add(this.cbxMedicalExamResult);
            this.Controls.Add(this.cbxMedicalExamType);
            this.Controls.Add(label18);
            this.Controls.Add(this.dtMedicalExamExpires);
            this.Controls.Add(label13);
            this.Controls.Add(this.dtMedicalExamDateOfMaking);
            this.Controls.Add(label11);
            this.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmNewMedicalExam";
            this.Text = "Nuevo examen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtMedicalExamExpires;
        private System.Windows.Forms.DateTimePicker dtMedicalExamDateOfMaking;
        private System.Windows.Forms.ComboBox cbxMedicalExamType;
        private System.Windows.Forms.ComboBox cbxMedicalExamResult;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnLicenseRenewal;
    }
}