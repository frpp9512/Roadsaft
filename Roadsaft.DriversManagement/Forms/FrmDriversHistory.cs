using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Roadsaft.DriversManagement.Data;

namespace Roadsaft.DriversManagement
{
    public partial class FrmDriversHistory : Form
    {
        public FrmDriversHistory()
        {
            InitializeComponent();
        }

        private void FrmDriversHistory_Load(object sender, EventArgs e)
        {
            dgvDriversHistory.DataSource = IoCContainer.Container.Get<IDriversDataProvider>().GetDriversHistory();
        }
    }
}
