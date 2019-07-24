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
        public static string GetShowText(this MedicalExamResult medicalExamResult)
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

        public static string GetShowText(this MedicalExamType medicalExamType)
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
    }
}
