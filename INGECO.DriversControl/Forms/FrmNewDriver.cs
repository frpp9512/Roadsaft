﻿using INGECO.DriversControl.Data;
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
        }

        private void BtnNewDriver_Click(object sender, EventArgs e)
        {
            if (txtFullname.TextLength > 0 && txtPersonalId.TextLength == 11 && txtPosition.TextLength > 0)
            {
                var driver = new Driver
                {
                    FullName = txtFullname.Text,
                    PersonalId = txtPersonalId.Text,
                    Position = txtPosition.Text
                };
                if (NewDriverAdded?.Invoke(driver) == true)
                {
                    _ = MessageBox.Show("Chofer agregado satisfactoriamente.", "Nuevo chofer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearFields();
                }
            }
            else
            {
                _ = MessageBox.Show("Rellene los campos debidamente.", "Error en el formulario", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearFields()
        {
            txtFullname.Text = txtPersonalId.Text = txtPosition.Text = string.Empty;
            txtFullname.Select();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
