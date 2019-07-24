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
    public partial class FrmNewRequalification : Form
    {
        public event NewEntityEventHandler<Requalificaiton> NewRequalificaitonAdded = null;

        public FrmNewRequalification()
        {
            InitializeComponent();
            dtRequalificationDateOfMaking.Value = DateTime.Now;
            dtRequalificationExpires.Value = dtRequalificationDateOfMaking.Value.AddYears(2);
        }

        private void BtnRequalificaitonRenewal_Click(object sender, EventArgs e)
        {
            if (txtRequalificationPage.TextLength > 0 && txtRequalificationVolume.TextLength > 0)
            {
                var req = new Requalificaiton
                {
                    Created = DateTime.Now,
                    DateOfMaking = dtRequalificationDateOfMaking.Value,
                    Expires = dtRequalificationExpires.Value,
                    Volume = txtRequalificationVolume.Text,
                    Page = txtRequalificationPage.Text,
                    Description = txtRequalificationDescription.Text
                };
                if (NewRequalificaitonAdded?.Invoke(req) == true)
                {
                    _ = MessageBox.Show("Recalificaión renovada satisfactoriamente.", "Renovar recalificación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DialogResult = DialogResult.OK;
                    Close();
                }
            }
            else
            {
                _ = MessageBox.Show("Rellene los campos debidamente.", "Error en el formulario", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
