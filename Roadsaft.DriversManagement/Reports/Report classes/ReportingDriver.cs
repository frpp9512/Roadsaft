using Roadsaft.DriversManagement.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roadsaft.DriversManagement
{
    /// <summary>
    /// Represents a driver with custom properties for showing in a report.
    /// </summary>
    class ReportingDriver : Driver
    {
        /// <summary>
        /// The license number.
        /// </summary>
        public string LicenseNumber => ActiveDriverLicense == null ? "No tiene licencia activa." : ActiveDriverLicense.Number;

        /// <summary>
        /// The date when the license expires.
        /// </summary>
        public DateTime LicenseExpires => ActiveDriverLicense == null ? DateTime.MinValue : ActiveDriverLicense.Expires;

        /// <summary>
        /// The volume where driver's requalification is registered.
        /// </summary>
        public string RequalificationVolume => ActiveRequalificaiton?.Volume;

        /// <summary>
        /// The volume's page where driver's requalification is registered.
        /// </summary>
        public string RequalificationPage => ActiveRequalificaiton?.Page;

        /// <summary>
        /// The summary of requalification data to be dislpayed in UI or report.
        /// </summary>
        public string RequalificationSummary => ActiveRequalificaiton == null ? "No tiene recalificación activa." : $"Tomo: {RequalificationVolume}\r\nFolio: {RequalificationPage}";
        /// <summary>
        /// The date when the requalification expires.
        /// </summary>
        public DateTime RequalificationExpires => ActiveRequalificaiton == null ? DateTime.MinValue : ActiveRequalificaiton.Expires;

        /// <summary>
        /// The medical exam's state resume.
        /// </summary>
        public string MedicalExamsResume => MedicalExams.Count == 0 ? "No tiene chequeos médicos activos." : string.Join("\r\n", MedicalExams.Select(me => $"Exámen: {me.Type.GetDisplayText()}\r\nRealizado: {me.DateOfMaking.ToShortDateString()} Vence: {me.Expires.ToShortDateString()} Resultado: {me.Result.GetDisplayText()}"));

        /// <summary>
        /// The display text for the Driver's category.
        /// </summary>
        public string CategoryDisplayText => Category.GetDisplayText();

        /// <summary>
        /// <see langword="true"/> if the license has a expiration warning.
        /// </summary>
        public bool LicenseWarning => ActiveDriverLicense?.GetIfExpirationDateIsInPeriod(Configuration.ExpireWarningForLicense) == true;

        /// <summary>
        /// <see langword="true"/> if the requalification has a expiration warning.
        /// </summary>
        public bool RequalificationWarning => ActiveRequalificaiton?.GetIfExpirationDateIsInPeriod(Configuration.ExpireWarningForRequalification) == true;

        /// <summary>
        /// <see langword="true"/> if any medical exam has a warning.
        /// </summary>
        public bool MedExamsWarning => MedicalExams.Count(me => me.GetIfExpirationDateIsInPeriod(Configuration.ExpireWarningForMedicalExam)) > 0;
    }
}
