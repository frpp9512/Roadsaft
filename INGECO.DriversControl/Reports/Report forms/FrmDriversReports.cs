using INGECO.DriversControl.Data;
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

namespace INGECO.DriversControl
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

        public FrmDriversReports(List<Driver> drivers, DriversView driversView)
        {
            InitializeComponent();
            ReportingDrivers = drivers.Select(d => new ReportingDriver
            {
                FullName = d.FullName,
                PersonalId = d.PersonalId,
                Category = d.Category,
                DriverLicense = d.DriverLicense,
                Description = d.Description,
                MedicalExams = d.MedicalExams,
                Position = d.Position,
                Requalificaiton = d.Requalificaiton,
            }).ToList();
            DriversView = driversView;
        }

        private void FrmDriversReports_Load(object sender, EventArgs e)
        {
            reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
            reportViewer1.ZoomMode = ZoomMode.PageWidth;
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("Drivers", ReportingDrivers));
            reportViewer1.RefreshReport();            
        }
    }
}
