using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Roadsaft.DriversManagement
{
    public partial class FrmConfiguration : Form
    {
        public FrmConfiguration()
        {
            InitializeComponent();
            LoadConfiguration();
        }

        private void LoadConfiguration()
        {
            nudRefreshTime.Value = Configuration.RefreshInterval;
            nudLicenseTimePeriod.Value = Configuration.ExpireWarningForLicense.Days;
            nudRequalificationTimePeriod.Value = Configuration.ExpireWarningForRequalification.Days;
            nudMedExamsTimePeriod.Value = Configuration.ExpireWarningForMedicalExam.Days;
            txtDatabaseHost.Text = Configuration.DatabaseHostName;
            txtDatabaseUser.Text = Configuration.DatabaseUserName;
            txtDatabasePassword.Text = "xxxxxxx";
            txtDatabaseName.Text = Configuration.DatabaseName;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            SaveConfiguration();
        }

        private void SaveConfiguration()
        {
            Configuration.DatabaseHostName = txtDatabaseHost.Text;
            Configuration.DatabaseUserName = txtDatabaseUser.Text;
            Configuration.DatabasePassword = txtDatabasePassword.Text == "xxxxxxx" ? Configuration.DatabasePassword : txtDatabasePassword.Text;
            Configuration.DatabaseName = txtDatabaseName.Text;
            Configuration.RefreshInterval = Convert.ToInt32(nudRefreshTime.Value);
            Configuration.ExpireWarningForLicense = new TimeSpan(Convert.ToInt32(nudLicenseTimePeriod.Value), 0, 0, 0);
            Configuration.ExpireWarningForRequalification = new TimeSpan(Convert.ToInt32(nudRequalificationTimePeriod.Value), 0, 0, 0);
            Configuration.ExpireWarningForMedicalExam = new TimeSpan(Convert.ToInt32(nudMedExamsTimePeriod.Value), 0, 0, 0);
            Configuration.SaveToFile();
            _ = MessageBox.Show("Configuración guardada satisfactoriamente.", "Configuración guardada", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnTestConnection_Click(object sender, EventArgs e)
        {
            
        }

        private void FrmConfiguration_Load(object sender, EventArgs e)
        {

        }
    }
}
