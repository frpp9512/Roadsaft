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
    public partial class FrmNewMedicalExam : Form
    {
        public event NewEntityEventHandler<MedicalExam> NewMedicalExamAdded = null;

        public FrmNewMedicalExam()
        {
            InitializeComponent();
            FillComboboxes();
            SetTimeInterval();
        }

        private void SetTimeInterval()
        {
            dtMedicalExamDateOfMaking.Value = DateTime.Now;
            dtMedicalExamExpires.Value = dtMedicalExamDateOfMaking.Value.AddYears(2);
        }

        private void FillComboboxes()
        {
            _ = cbxMedicalExamResult.Items.Add(MedicalExamResult.Able.GetShowText());
            _ = cbxMedicalExamResult.Items.Add(MedicalExamResult.Disable.GetShowText());
            cbxMedicalExamResult.SelectedIndex = 0;

            _ = cbxMedicalExamType.Items.Add(MedicalExamType.General.GetShowText());
            _ = cbxMedicalExamType.Items.Add(MedicalExamType.Psychological.GetShowText());
            cbxMedicalExamType.SelectedIndex = 0;
        }

        private void BtnLicenseRenewal_Click(object sender, EventArgs e)
        {
            if (cbxMedicalExamResult.SelectedIndex >= 0 && cbxMedicalExamType.SelectedIndex >= 0)
            {
                var exam = new MedicalExam
                {
                    Created = DateTime.Now,
                    DateOfMaking = dtMedicalExamDateOfMaking.Value,
                    Expires = dtMedicalExamExpires.Value,
                    Result = (MedicalExamResult)cbxMedicalExamResult.SelectedIndex,
                    Type = (MedicalExamType)cbxMedicalExamType.SelectedIndex,
                    Description = txtMedicalExamDescription.Text,
                    IsActive = true
                };
                if (NewMedicalExamAdded?.Invoke(exam) == true)
                {
                    _ = MessageBox.Show("Examen médico registrado satisfactoriamente.", "Nuevo exámen médico", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearFields();
                    DialogResult = DialogResult.OK;
                }
                else
                {
                    _ = MessageBox.Show("Ha ocurrido un error registrando el chequeo médico. Contacte al desarrollador para solicitar soporte acerca de este error.", "Error registrando examen", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            txtMedicalExamDescription.Text = "";
            SetTimeInterval();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
