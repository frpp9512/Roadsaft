using INGECO.DriversControl.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace INGECO.DriversControl
{
    /// <summary>
    /// Represents a method that will handle a event triggered when a new entity it's been added.
    /// </summary>
    /// <typeparam name="T">The type of the new entity.</typeparam>
    /// <param name="newEntity">The new entity.</param>
    public delegate bool NewEntityEventHandler<T>(T newEntity);
    public partial class FrmNewDriver : Form
    {
        public event NewEntityEventHandler<Driver> NewDriverAdded = null;

        public FrmNewDriver()
        {
            InitializeComponent();
            FillCombobox();
        }

        private void FillCombobox()
        {
            cbxDriverCategory.Items.Add(DriverCategory.Professional.GetDisplayText());
            cbxDriverCategory.Items.Add(DriverCategory.NonProfessional.GetDisplayText());
            cbxDriverCategory.SelectedIndex = 0;
        }

        private void BtnNewDriver_Click(object sender, EventArgs e)
        {
            if (txtFullname.TextLength > 0 && txtPersonalId.TextLength == 11 && txtPosition.TextLength > 0)
            {
                var driver = new Driver
                {
                    FullName = txtFullname.Text,
                    PersonalId = txtPersonalId.Text,
                    Position = txtPosition.Text,
                    Category = (DriverCategory)cbxDriverCategory.SelectedIndex,
                    Description = txtDescription.Text
                };
                if (NewDriverAdded?.Invoke(driver) == true)
                {
                    _ = MessageBox.Show("Chofer agregado satisfactoriamente.", "Nuevo chofer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearFields();
                }
                else
                {
                    _ = MessageBox.Show("Ha ocurrido un error registrando el chofer. Contacte al desarrollador para solicitar soporte acerca de este error.", "Error registrando chofer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    DialogResult = DialogResult.Cancel;
                    Close();
                }
            }
            else
            {
                _ = MessageBox.Show("Rellene los campos debidamente.", "Error en el formulario", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearFields()
        {
            txtFullname.Text = txtPersonalId.Text = txtPosition.Text = txtDescription.Text = string.Empty;
            txtFullname.Select();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
