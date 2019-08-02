﻿namespace INGECO.DriversControl
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
            System.Windows.Forms.Label label21;
            this.dtMedicalExamExpires = new System.Windows.Forms.DateTimePicker();
            this.dtMedicalExamDateOfMaking = new System.Windows.Forms.DateTimePicker();
            this.cbxMedicalExamType = new System.Windows.Forms.ComboBox();
            this.cbxMedicalExamResult = new System.Windows.Forms.ComboBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnLicenseRenewal = new System.Windows.Forms.Button();
            this.txtMedicalExamDescription = new System.Windows.Forms.TextBox();
            label13 = new System.Windows.Forms.Label();
            label11 = new System.Windows.Forms.Label();
            label18 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label21 = new System.Windows.Forms.Label();
            this.SuspendLayout();
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(14, 106);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(85, 13);
            label1.TabIndex = 40;
            label1.Text = "Tipo de examen:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(14, 133);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(112, 13);
            label2.TabIndex = 40;
            label2.Text = "Resultado del exámen:";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new System.Drawing.Point(14, 160);
            label21.Name = "label21";
            label21.Size = new System.Drawing.Size(63, 13);
            label21.TabIndex = 43;
            label21.Text = "Descripción:";
            // 
            // dtMedicalExamExpires
            // 
            this.dtMedicalExamExpires.Location = new System.Drawing.Point(130, 75);
            this.dtMedicalExamExpires.Name = "dtMedicalExamExpires";
            this.dtMedicalExamExpires.Size = new System.Drawing.Size(240, 22);
            this.dtMedicalExamExpires.TabIndex = 2;
            // 
            // dtMedicalExamDateOfMaking
            // 
            this.dtMedicalExamDateOfMaking.Location = new System.Drawing.Point(130, 47);
            this.dtMedicalExamDateOfMaking.Name = "dtMedicalExamDateOfMaking";
            this.dtMedicalExamDateOfMaking.Size = new System.Drawing.Size(240, 22);
            this.dtMedicalExamDateOfMaking.TabIndex = 1;
            // 
            // cbxMedicalExamType
            // 
            this.cbxMedicalExamType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxMedicalExamType.FormattingEnabled = true;
            this.cbxMedicalExamType.Location = new System.Drawing.Point(130, 103);
            this.cbxMedicalExamType.Name = "cbxMedicalExamType";
            this.cbxMedicalExamType.Size = new System.Drawing.Size(240, 21);
            this.cbxMedicalExamType.TabIndex = 3;
            // 
            // cbxMedicalExamResult
            // 
            this.cbxMedicalExamResult.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxMedicalExamResult.FormattingEnabled = true;
            this.cbxMedicalExamResult.Location = new System.Drawing.Point(130, 130);
            this.cbxMedicalExamResult.Name = "cbxMedicalExamResult";
            this.cbxMedicalExamResult.Size = new System.Drawing.Size(240, 21);
            this.cbxMedicalExamResult.TabIndex = 4;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.MediumSeaGreen;
            this.btnCancel.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightGreen;
            this.btnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SeaGreen;
            this.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleGreen;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnCancel.Location = new System.Drawing.Point(286, 208);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(84, 23);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "&Cancelar";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // btnLicenseRenewal
            // 
            this.btnLicenseRenewal.FlatAppearance.BorderColor = System.Drawing.Color.MediumSeaGreen;
            this.btnLicenseRenewal.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightGreen;
            this.btnLicenseRenewal.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SeaGreen;
            this.btnLicenseRenewal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleGreen;
            this.btnLicenseRenewal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLicenseRenewal.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnLicenseRenewal.Location = new System.Drawing.Point(196, 208);
            this.btnLicenseRenewal.Name = "btnLicenseRenewal";
            this.btnLicenseRenewal.Size = new System.Drawing.Size(84, 23);
            this.btnLicenseRenewal.TabIndex = 6;
            this.btnLicenseRenewal.Text = "&Crear";
            this.btnLicenseRenewal.UseVisualStyleBackColor = true;
            this.btnLicenseRenewal.Click += new System.EventHandler(this.BtnLicenseRenewal_Click);
            // 
            // txtMedicalExamDescription
            // 
            this.txtMedicalExamDescription.Location = new System.Drawing.Point(130, 157);
            this.txtMedicalExamDescription.Multiline = true;
            this.txtMedicalExamDescription.Name = "txtMedicalExamDescription";
            this.txtMedicalExamDescription.Size = new System.Drawing.Size(240, 45);
            this.txtMedicalExamDescription.TabIndex = 5;
            // 
            // FrmNewMedicalExam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 243);
            this.Controls.Add(this.txtMedicalExamDescription);
            this.Controls.Add(label21);
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
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private System.Windows.Forms.TextBox txtMedicalExamDescription;
    }
}