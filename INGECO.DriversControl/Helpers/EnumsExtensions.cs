using INGECO.DriversControl.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INGECO.DriversControl
{
    static class EnumsExtensions
    {
        /// <summary>
        /// Get the text to display in the user interface.
        /// </summary>
        /// <param name="medicalExamResult">The <see cref="MedicalExamResult"/> to determine display text.</param>
        /// <returns>The text to display in the user interface.</returns>
        public static string GetDisplayText(this MedicalExamResult medicalExamResult)
        {
            switch (medicalExamResult)
            {
                case MedicalExamResult.Able:
                    return "Apto";
                case MedicalExamResult.Disable:
                    return "No apto";
                default:
                    return "<No se encuentra el texto>";
            }
        }

        /// <summary>
        /// Get the text to display in the user interface.
        /// </summary>
        /// <param name="medicalExamType">The <see cref="MedicalExamType"/> to determine display text.</param>
        /// <returns>The text to display in the user interface.</returns>
        public static string GetDisplayText(this MedicalExamType medicalExamType)
        {
            switch (medicalExamType)
            {
                case MedicalExamType.General:
                    return "General";
                case MedicalExamType.Psychological:
                    return "Psicofisiológico";
                default:
                    return "<No se encuentra el texto>";
            }
        }

        /// <summary>
        /// Get the text to display in the user interface.
        /// </summary>
        /// <param name="driversView">The <see cref="DriversView"/> to determine display text.</param>
        /// <returns>The text to display in the user interface.</returns>
        public static string GetDisplayText(this DriversView driversView)
        {
            switch (driversView)
            {
                case DriversView.AllDrivers:
                    return "Todos los choferes";
                case DriversView.DriversWithoutIssues:
                    return "Choferes sin problemas";
                case DriversView.DriversWithWarnings:
                    return "Choferes con advertencias";
                case DriversView.DriversWithIssues:
                    return "Choferes con atributos expirados";
                default:
                    return "<No se encuentra el texto>";
            }
        }

        /// <summary>
        /// Get the text to display in the user interface.
        /// </summary>
        /// <param name="category">The <see cref="DriverCategory"/> to determine display text.</param>
        /// <returns>The text to display in the user interface.</returns>
        public static string GetDisplayText(this DriverCategory category)
        {
            switch (category)
            {
                case DriverCategory.Professional:
                    return "Profesional";
                case DriverCategory.NonProfessional:
                    return "No profesional";
                default:
                    return "<No se encuentra el texto>";
            }
        }

        /// <summary>
        /// Get the text to display in the user interface.
        /// </summary>
        /// <param name="filter">The <see cref="DriverCategoryFilter"/> to determine display text.</param>
        /// <returns>The text to display in the user interface.</returns>
        public static string GetDisplayText(this DriverCategoryFilter filter)
        {
            switch (filter)
            {
                case DriverCategoryFilter.All:
                    return "Todos los choferes";
                case DriverCategoryFilter.ProfessionalsOnly:
                    return "Solo profesionales";
                case DriverCategoryFilter.NonProfessionalsOnly:
                    return "Solo no profesionales";
                default:
                    return "<No se encuentra el texto>";
            }
        }
    }
}
