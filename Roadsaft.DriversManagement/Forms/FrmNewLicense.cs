using Roadsaft.DriversManagement.Data;
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
    public partial class FrmNewLicense : Form
    {
        public event NewEntityEventHandler<DriverLicense> NewLicenseForRenewal = null;

        public FrmNewLicense()
        {
            InitializeComponent();
            SetTimeInterval();
        }

        public FrmNewLicense(DriverLicense currentLicense)
        {
            InitializeComponent();
            SetTimeInterval();
            txtLicenseNumber.Text = currentLicense.Number;
            txtLicenseCategory.Text = currentLicense.Category;
        }

        private void SetTimeInterval()
        {
            dtDateOfMaking.Value = DateTime.Now;
            dtLicenseExpires.Value = dtDateOfMaking.Value.AddYears(2);
        }

        private void BtnLicenseRenewal_Click(object sender, EventArgs e)
        {
            if (txtLicenseCategory.TextLength > 0 && txtLicenseNumber.TextLength > 0)
            {
                var license = new DriverLicense
                {
                    Created = DateTime.Now,
                    Number = txtLicenseNumber.Text,
                    Category = txtLicenseCategory.Text,
                    DateOfMaking = dtDateOfMaking.Value,
                    Expires = dtLicenseExpires.Value,
                    Description = txtDriverLicenseDescription.Text
                };
                _ = NewLicenseForRenewal?.Invoke(license);
                _ = MessageBox.Show("Licencia renovada satisfactoriamente.", "Renovar licencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            else
            {
                _ = MessageBox.Show("Rellene los campos debidamente.", "Error en el formulario", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
