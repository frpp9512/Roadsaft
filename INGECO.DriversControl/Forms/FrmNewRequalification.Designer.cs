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
            System.Windows.Forms.Label label15;
            System.Windows.Forms.Label label14;
            System.Windows.Forms.Label label13;
            System.Windows.Forms.Label label11;
            System.Windows.Forms.Label label12;
            System.Windows.Forms.Label label20;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNewRequalification));
            this.txtRequalificationPage = new System.Windows.Forms.TextBox();
            this.txtRequalificationVolume = new System.Windows.Forms.TextBox();
            this.dtRequalificationExpires = new System.Windows.Forms.DateTimePicker();
            this.dtRequalificationDateOfMaking = new System.Windows.Forms.DateTimePicker();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnRequalificaitonRenewal = new System.Windows.Forms.Button();
            this.txtRequalificationDescription = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            label15 = new System.Windows.Forms.Label();
            label14 = new System.Windows.Forms.Label();
            label13 = new System.Windows.Forms.Label();
            label11 = new System.Windows.Forms.Label();
            label12 = new System.Windows.Forms.Label();
            label20 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new System.Drawing.Point(226, 129);
            label15.Name = "label15";
            label15.Size = new System.Drawing.Size(30, 13);
            label15.TabIndex = 36;
            label15.Text = "Folio:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new System.Drawing.Point(117, 129);
            label14.Name = "label14";
            label14.Size = new System.Drawing.Size(35, 13);
            label14.TabIndex = 34;
            label14.Text = "Tomo:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new System.Drawing.Point(9, 101);
            label13.Name = "label13";
            label13.Size = new System.Drawing.Size(103, 13);
            label13.TabIndex = 32;
            label13.Text = "Fecha de expiración:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new System.Drawing.Point(9, 73);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(83, 13);
            label11.TabIndex = 30;
            label11.Text = "Fecha realizada:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new System.Drawing.Font("Segoe UI Semibold", 14F);
            label12.Location = new System.Drawing.Point(65, 12);
            label12.Name = "label12";
            label12.Size = new System.Drawing.Size(186, 25);
            label12.TabIndex = 28;
            label12.Text = "Nueva recalificación";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new System.Drawing.Point(9, 157);
            label20.Name = "label20";
            label20.Size = new System.Drawing.Size(63, 13);
            label20.TabIndex = 41;
            label20.Text = "Descripción:";
            // 
            // txtRequalificationPage
            // 
            this.txtRequalificationPage.Location = new System.Drawing.Point(267, 126);
            this.txtRequalificationPage.Name = "txtRequalificationPage";
            this.txtRequalificationPage.Size = new System.Drawing.Size(62, 22);
            this.txtRequalificationPage.TabIndex = 3;
            // 
            // txtRequalificationVolume
            // 
            this.txtRequalificationVolume.Location = new System.Drawing.Point(158, 126);
            this.txtRequalificationVolume.Name = "txtRequalificationVolume";
            this.txtRequalificationVolume.Size = new System.Drawing.Size(62, 22);
            this.txtRequalificationVolume.TabIndex = 2;
            // 
            // dtRequalificationExpires
            // 
            this.dtRequalificationExpires.Location = new System.Drawing.Point(118, 98);
            this.dtRequalificationExpires.Name = "dtRequalificationExpires";
            this.dtRequalificationExpires.Size = new System.Drawing.Size(240, 22);
            this.dtRequalificationExpires.TabIndex = 1;
            // 
            // dtRequalificationDateOfMaking
            // 
            this.dtRequalificationDateOfMaking.Location = new System.Drawing.Point(118, 70);
            this.dtRequalificationDateOfMaking.Name = "dtRequalificationDateOfMaking";
            this.dtRequalificationDateOfMaking.Size = new System.Drawing.Size(240, 22);
            this.dtRequalificationDateOfMaking.TabIndex = 0;
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
            this.btnCancel.Image = global::INGECO.DriversControl.Properties.Resources.error_verysmall;
            this.btnCancel.Location = new System.Drawing.Point(274, 205);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(84, 28);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "&Cancelar";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnRequalificaitonRenewal
            // 
            this.btnRequalificaitonRenewal.FlatAppearance.BorderColor = System.Drawing.Color.MediumSeaGreen;
            this.btnRequalificaitonRenewal.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightGreen;
            this.btnRequalificaitonRenewal.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SeaGreen;
            this.btnRequalificaitonRenewal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleGreen;
            this.btnRequalificaitonRenewal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRequalificaitonRenewal.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnRequalificaitonRenewal.Image = global::INGECO.DriversControl.Properties.Resources.ok_verysmall;
            this.btnRequalificaitonRenewal.Location = new System.Drawing.Point(184, 205);
            this.btnRequalificaitonRenewal.Name = "btnRequalificaitonRenewal";
            this.btnRequalificaitonRenewal.Size = new System.Drawing.Size(84, 28);
            this.btnRequalificaitonRenewal.TabIndex = 5;
            this.btnRequalificaitonRenewal.Text = "&Crear";
            this.btnRequalificaitonRenewal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRequalificaitonRenewal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRequalificaitonRenewal.UseVisualStyleBackColor = true;
            this.btnRequalificaitonRenewal.Click += new System.EventHandler(this.BtnRequalificaitonRenewal_Click);
            // 
            // txtRequalificationDescription
            // 
            this.txtRequalificationDescription.Location = new System.Drawing.Point(118, 154);
            this.txtRequalificationDescription.Multiline = true;
            this.txtRequalificationDescription.Name = "txtRequalificationDescription";
            this.txtRequalificationDescription.Size = new System.Drawing.Size(240, 45);
            this.txtRequalificationDescription.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::INGECO.DriversControl.Properties.Resources.requalification_add;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(47, 38);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 42;
            this.pictureBox1.TabStop = false;
            // 
            // FrmNewRequalification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 242);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtRequalificationDescription);
            this.Controls.Add(label20);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnRequalificaitonRenewal);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmNewRequalification";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Nueva recalificación";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtRequalificationPage;
        private System.Windows.Forms.TextBox txtRequalificationVolume;
        private System.Windows.Forms.DateTimePicker dtRequalificationExpires;
        private System.Windows.Forms.DateTimePicker dtRequalificationDateOfMaking;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnRequalificaitonRenewal;
        private System.Windows.Forms.TextBox txtRequalificationDescription;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}