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
    /// <summary>
    /// The form where the Drivers Report is showed.
    /// </summary>
    public partial class FrmDriversReports : Form
    {
        /// <summary>
        /// The list of <see cref="ReportingDriver"/> showed in the report.
        /// </summary>
        internal List<ReportingDriver> ReportingDrivers { get; private set; }

        /// <summary>
        /// The Drivers view used for generate the list of drivers.
        /// </summary>
        internal DriversView DriversView { get; private set; }

        /// <summary>
        /// The <see cref="DriverCategoryFilter"/> used for generate the list of drivers.
        /// </summary>
        public DriverCategoryFilter CategoryFilter { get; private set; }

        public FrmDriversReports(List<Driver> drivers, DriversView driversView, DriverCategoryFilter filter)
        {
            InitializeComponent();
            ReportingDrivers = drivers.GetReportingDrivers();
            DriversView = driversView;
            CategoryFilter = filter;
        }

        private void FrmDriversReports_Load(object sender, EventArgs e)
        {
            reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
            reportViewer1.ZoomMode = ZoomMode.PageWidth;
            reportViewer1.LocalReport.DataSources.Clear();
            /*reportViewer1.LocalReport.SetParameters(new List<ReportParameter>
            {
                new ReportParameter("DriversFilter", DriversView.GetDisplayText()),
                new ReportParameter("DriversCategoryFilter", CategoryFilter.GetDisplayText())
            });*/
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("Drivers", ReportingDrivers));
            reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }
    }
}
