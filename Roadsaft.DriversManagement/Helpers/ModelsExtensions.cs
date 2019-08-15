using Roadsaft.DriversManagement.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Roadsaft.DriversManagement
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

        /// <summary>
        /// Converts the <see cref="Driver"/> stored in the list to <see cref="ReportingDriver"/>.
        /// </summary>
        /// <param name="drivers">The drivers to convert.</param>
        /// <returns>A list of converted <see cref="ReportingDriver"/></returns>
        public static List<ReportingDriver> GetReportingDrivers(this List<Driver> drivers)
        {
            return drivers.Select(d => new ReportingDriver
            {
                FullName = d.FullName,
                PersonalId = d.PersonalId,
                Category = d.Category,
                DriverLicense = d.DriverLicense,
                Description = d.Description,
                MedicalExams = d.MedicalExams,
                Position = d.Position,
                Requalificaiton = d.Requalificaiton,
                Registered = d.Registered,
                Archived = d.Archived
            }).ToList();
        }

        /// <summary>
        /// Replaces all the spanish's accented vowels with normal ones.
        /// </summary>
        /// <param name="value">The value to remove accents.</param>
        /// <returns>The value without spanish's accent vowels.</returns>
        public static string RemoveAccents(this string value)
        {
            return value
                .Replace('á', 'a')
                .Replace('é', 'e')
                .Replace('í', 'i')
                .Replace('ó', 'o')
                .Replace('ú', 'u');
        }
    }
}
