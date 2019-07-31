using INGECO.DriversControl.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INGECO.DriversControl
{
    /// <summary>
    /// Represents a driver with custom properties for showing in a report.
    /// </summary>
    class ReportingDriver : Driver
    {
        /// <summary>
        /// The license number.
        /// </summary>
        public string LicenseNumber => DriverLicense == null ? "No tiene liencia activa." : DriverLicense.Number;

        /// <summary>
        /// The date when the license expires.
        /// </summary>
        public DateTime LicenseExpires => DriverLicense == null ? DateTime.MinValue : DriverLicense.Expires;

        /// <summary>
        /// The date when the requalification expires.
        /// </summary>
        public DateTime RequalificationExpires => Requalificaiton == null ? DateTime.MinValue : Requalificaiton.Expires;

        /// <summary>
        /// The medical exam's state resume.
        /// </summary>
        public string MedicalExamsResume => String.Join("\r\n", MedicalExams.Select(me => $"Exámen: {me.Type.GetDisplayText()}\r\nRealizado: {me.DateOfMaking.ToShortDateString()} Vence: {me.Expires.ToShortDateString()} Resultado: {me.Result.GetDisplayText()}"));

        /// <summary>
        /// The display text for the Driver's category.
        /// </summary>
        public string CategoryDisplayText => Category.GetDisplayText();

        /// <summary>
        /// <see langword="true"/> if the license has a expiration warning.
        /// </summary>
        public bool LicenseWarning => DriverLicense.GetIfExpirationDateIsInPeriod(Configuration.ExpireWarningForLicense);

        /// <summary>
        /// <see langword="true"/> if the requalification has a expiration warning.
        /// </summary>
        public bool RequalificationWarning => Requalificaiton.GetIfExpirationDateIsInPeriod(Configuration.ExpireWarningForRequalification);

        /// <summary>
        /// <see langword="true"/> if any medical exam has a warning.
        /// </summary>
        public bool MedExamsWarning => MedicalExams.Count(me => me.GetIfExpirationDateIsInPeriod(Configuration.ExpireWarningForMedicalExam)) > 0;
    }
}
