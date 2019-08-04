namespace INGECO.DriversControl
{
    partial class FrmDriversHistory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDriversHistory));
            this.dgvDriversHistory = new System.Windows.Forms.DataGridView();
            this.fullNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.positionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personalIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.registeredDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Archived = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.driverBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDriversHistory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.driverBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDriversHistory
            // 
            this.dgvDriversHistory.AllowUserToAddRows = false;
            this.dgvDriversHistory.AllowUserToDeleteRows = false;
            this.dgvDriversHistory.AllowUserToResizeRows = false;
            this.dgvDriversHistory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDriversHistory.AutoGenerateColumns = false;
            this.dgvDriversHistory.BackgroundColor = System.Drawing.Color.White;
            this.dgvDriversHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDriversHistory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fullNameDataGridViewTextBoxColumn,
            this.positionDataGridViewTextBoxColumn,
            this.personalIdDataGridViewTextBoxColumn,
            this.categoryDataGridViewTextBoxColumn,
            this.registeredDataGridViewTextBoxColumn,
            this.Archived});
            this.dgvDriversHistory.DataSource = this.driverBindingSource;
            this.dgvDriversHistory.Location = new System.Drawing.Point(12, 57);
            this.dgvDriversHistory.MultiSelect = false;
            this.dgvDriversHistory.Name = "dgvDriversHistory";
            this.dgvDriversHistory.ReadOnly = true;
            this.dgvDriversHistory.RowHeadersVisible = false;
            this.dgvDriversHistory.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.MediumSeaGreen;
            this.dgvDriversHistory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDriversHistory.Size = new System.Drawing.Size(730, 353);
            this.dgvDriversHistory.TabIndex = 0;
            // 
            // fullNameDataGridViewTextBoxColumn
            // 
            this.fullNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.fullNameDataGridViewTextBoxColumn.DataPropertyName = "FullName";
            this.fullNameDataGridViewTextBoxColumn.HeaderText = "Nombre completo";
            this.fullNameDataGridViewTextBoxColumn.Name = "fullNameDataGridViewTextBoxColumn";
            this.fullNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // positionDataGridViewTextBoxColumn
            // 
            this.positionDataGridViewTextBoxColumn.DataPropertyName = "Position";
            this.positionDataGridViewTextBoxColumn.HeaderText = "Cargo";
            this.positionDataGridViewTextBoxColumn.Name = "positionDataGridViewTextBoxColumn";
            this.positionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // personalIdDataGridViewTextBoxColumn
            // 
            this.personalIdDataGridViewTextBoxColumn.DataPropertyName = "PersonalId";
            this.personalIdDataGridViewTextBoxColumn.HeaderText = "Carné identidad";
            this.personalIdDataGridViewTextBoxColumn.Name = "personalIdDataGridViewTextBoxColumn";
            this.personalIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // categoryDataGridViewTextBoxColumn
            // 
            this.categoryDataGridViewTextBoxColumn.DataPropertyName = "Category";
            this.categoryDataGridViewTextBoxColumn.HeaderText = "Categoría";
            this.categoryDataGridViewTextBoxColumn.Name = "categoryDataGridViewTextBoxColumn";
            this.categoryDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // registeredDataGridViewTextBoxColumn
            // 
            this.registeredDataGridViewTextBoxColumn.DataPropertyName = "Registered";
            this.registeredDataGridViewTextBoxColumn.HeaderText = "Registrado";
            this.registeredDataGridViewTextBoxColumn.Name = "registeredDataGridViewTextBoxColumn";
            this.registeredDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Archived
            // 
            this.Archived.DataPropertyName = "Archived";
            this.Archived.HeaderText = "Baja";
            this.Archived.Name = "Archived";
            this.Archived.ReadOnly = true;
            // 
            // driverBindingSource
            // 
            this.driverBindingSource.DataSource = typeof(INGECO.DriversControl.Data.Driver);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 24F);
            this.label1.ForeColor = System.Drawing.Color.ForestGreen;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(319, 45);
            this.label1.TabIndex = 2;
            this.label1.Text = "Historial de choferes";
            // 
            // FrmDriversHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 422);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvDriversHistory);
            this.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmDriversHistory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Historial de choferes";
            this.Load += new System.EventHandler(this.FrmDriversHistory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDriversHistory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.driverBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDriversHistory;
        private System.Windows.Forms.BindingSource driverBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn positionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personalIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn registeredDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Archived;
        private System.Windows.Forms.Label label1;
    }
}