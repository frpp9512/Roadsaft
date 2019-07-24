using INGECO.DriversControl.Data;
using System;
using System.Linq;
using System.Text;

namespace INGECO.DriversControl
{
    internal static class ModelsExtensions
    {
        public static string GetStatusToolTip(this Driver driver)
        {
            var sb = new StringBuilder();
            if (driver.HasActiveLicense)
            {
                if (driver.HasExpiredLicense)
                {
                    sb.AppendLine("La licencia de conducción ha expirado.");
                }
                else
                {
                    if (driver.DriverLicense.GetIfExpirationDateIsInPeriod(Configuration.ExpireWarningForLicense))
                    {
                        sb.AppendLine($"La licencia esta próxima a vencerse. Faltan: {(driver.DriverLicense.Expires - DateTime.Now).Days} día(s).");
                    }
                }
            }
            else
            {
                sb.AppendLine("No tiene licencia de conducir activa.");
            }
            if (driver.HasActiveRequalification)
            {
                if (driver.HasExpiredRequalification)
                {
                    sb.AppendLine("La recalificación ha expirado.");
                }
                else
                {
                    if (driver.Requalificaiton.GetIfExpirationDateIsInPeriod(Configuration.ExpireWarningForRequalification))
                    {
                        sb.AppendLine($"La recalificación esta próxima a vencerse. Faltan: {(driver.Requalificaiton.Expires - DateTime.Now).Days} día(s).");
                    }
                }
            }
            else
            {
                sb.AppendLine("No tiene recalificación activa.");
            }
            if (driver.HasMedicalExams)
            {
                if (driver.HasExpiredMedicalExam)
                {
                    sb.AppendLine("Tiene chequeos médicos vencidos.");
                }
                else
                {
                    if (driver.MedicalExams.Count(me => me.GetIfExpirationDateIsInPeriod(Configuration.ExpireWarningForMedicalExam)) > 0)
                    {
                        sb.AppendLine($"Existen chequeos médicos próximos a vencerse.");
                    }
                }
            }
            else
            {
                sb.AppendLine("No tiene chequeos médicos activos.");
            }
            if (sb.Length == 0)
            {
                sb.AppendLine("Todo esta en orden.");
            }
            return sb.ToString();
        }
    }
}
