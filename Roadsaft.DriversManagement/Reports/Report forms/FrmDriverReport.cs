using Roadsaft.DriversManagement.Data;
using Microsoft.Reporting.WinForms;
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
    public partial class FrmDriverReport : Form
    {
        /// <summary>
        /// The list of drivers to show in report.
        /// </summary>
        internal List<ReportingDriver> ReportingDrivers { get; set; }

        public FrmDriverReport(List<Driver> drivers)
        {
            InitializeComponent();
            ReportingDrivers = drivers.GetReportingDrivers();
        }

        private void FrmDriverReport_Load(object sender, EventArgs e)
        {
            reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
            reportViewer1.ZoomMode = ZoomMode.PageWidth;
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("Driver", ReportingDrivers));
            reportViewer1.RefreshReport();
        }
    }
}
