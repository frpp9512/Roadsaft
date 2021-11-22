using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace Roadsaft.DriversManagement.Data
{
    /// <summary>
    /// Represents a driver working in the bussiness.
    /// </summary>
    public class Driver
    {
        #region Constructor

        /// <summary>
        /// Default constructor.
        /// </summary>
        public Driver()
        { }

        #endregion

        #region Properties

        [Key]
        public int Id { get; set; }

        /// <summary>
        /// The full name of the driver.
        /// </summary>
        public string FullName { get; set; }

        /// <summary>
        /// The position of the driver.
        /// </summary>
        public string Position { get; set; }

        /// <summary>
        /// The personal id of the driver.
        /// </summary>
        public string PersonalId { get; set; }

        /// <summary>
        /// The category of the driver.
        /// </summary>
        public DriverCategory Category { get; set; }

        /// <summary>
        /// The birthday of the driver calculated by the personal id.
        /// </summary>
        public DateTime Birthday
        {
            get
            {
                _ = int.TryParse(PersonalId.Substring(4, 2), out var day);
                _ = int.TryParse(PersonalId.Substring(2, 2), out var month);
                _ = int.TryParse(PersonalId.Substring(0, 2), out var partYear);
                _ = int.TryParse(DateTime.Now.Year.ToString().Substring(2, 2), out var currentPartYear);
                _ = partYear > currentPartYear
                    ? int.TryParse($"19{(partYear < 10 ? $"0{partYear}" : partYear.ToString())}", out var year)
                    : int.TryParse($"20{(partYear < 10 ? $"0{partYear}" : partYear.ToString())}", out year);
                return new DateTime(year, (month == 0 || month > 12) ? 1 : month, (day == 0 || day > 31) ? 1 : day);
            }
        }

        /// <summary>
        /// The current age of the driver calculated with the birthday.
        /// </summary>
        public int Age => (DateTime.Now - Birthday).Days / 365;

        /// <summary>
        /// A description of the driver.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// The date and time when the driver was registered in the system.
        /// </summary>
        public DateTime Registered { get; set; }

        /// <summary>
        /// The date and time when the driver was deactivated.
        /// </summary>
        public DateTime Archived { get; set; }

        /// <summary>
        /// <see langword="true"/> if driver is active in the system.
        /// </summary>
        public bool IsActive { get; set; } = true;

        /// <summary>
        /// The current active requalification of the driver
        /// </summary>
        public Requalificaiton ActiveRequalificaiton => Requalificaitons?.FirstOrDefault(r => r?.IsActive == true);

        /// <summary>
        /// The current active driver license of the driver
        /// </summary>
        public DriverLicense ActiveDriverLicense => DriverLicenses?.FirstOrDefault(l => l?.IsActive == true);

        /// <summary>
        /// The current active medical exams of the driver
        /// </summary>
        public List<MedicalExam> ActiveMedicalExams => MedicalExams?.Where(m => m?.IsActive == true).ToList();

        public List<DriverLicense> DriverLicenses { get; set; }

        public List<Requalificaiton> Requalificaitons { get; set; }

        public List<MedicalExam> MedicalExams { get; set; }

        /// <summary>
        /// False if DriverLicense, Requalification or any MedicalExam has expired.
        /// </summary>
        public bool HasExpiredParameters =>
            ActiveDriverLicense == null
            || ActiveRequalificaiton == null
            || ActiveMedicalExams == null
            || ActiveMedicalExams.Count == 0
            || ActiveDriverLicense.IsExpired 
            || ActiveRequalificaiton.IsExpired 
            || ActiveMedicalExams.Any(me => me.IsExpired);

        /// <summary>
        /// Returns <see langword="true"/> if the driver has a setted Driver's License.
        /// </summary>
        public bool HasActiveLicense => ActiveDriverLicense != null;

        /// <summary>
        /// Returns <see langword="true"/> if the active driver's license is expired. If the driver's license is not setted returns <see langword="false"/>.
        /// </summary>
        public bool HasExpiredLicense => HasActiveLicense && ActiveDriverLicense.IsExpired;

        /// <summary>
        /// Returns <see langword="true"/> if the driver has a setted Requalification.
        /// </summary>
        public bool HasActiveRequalification => ActiveRequalificaiton != null;

        /// <summary>
        /// Returns <see langword="true"/> if the active Requalification is expired. If the Requalification is not setted returns <see langword="false"/>
        /// </summary>
        public bool HasExpiredRequalification => HasActiveRequalification && ActiveRequalificaiton.IsExpired;

        /// <summary>
        /// Returns <see langword="true"/> if the driver have at least one active Medical Exam.
        /// </summary>
        public bool HasMedicalExams => ActiveMedicalExams?.Count > 0;

        /// <summary>
        /// Returns <see langword="true"/> if the driver have at least one Medical Exam expired. If have no Medical Exam returns <see langword="false"/>.
        /// </summary>
        public bool HasExpiredMedicalExam => HasMedicalExams && ActiveMedicalExams.Any(me => me.IsExpired);

        /// <summary>
        /// The time elapsed since the driver was registered in the system.
        /// </summary>
        public TimeSpan RegisteredTime => DateTime.Now - Registered;

        #endregion

        #region Methods

        /// <summary>
        /// Determines if any of the expiration dates of Driver's License, Requalification or Medical Exams are in the specified period.
        /// </summary>
        /// <param name="periodForLicense">The specified period for driver's license.</param>
        /// <param name="periodForRequalification">The specified period for driver's requalification.</param>
        /// <param name="periodForMedicalExam">The specified period for a driver's medical examl.</param>
        /// <returns>True if expiration date is in the period.</returns>
        public bool GetIfAnyParameterExpireDateIsInPeriod(TimeSpan periodForLicense, TimeSpan periodForRequalification, TimeSpan periodForMedicalExam) 
            => ActiveDriverLicense != null 
               && ActiveRequalificaiton != null 
               && ActiveMedicalExams != null 
               && (ActiveDriverLicense.GetIfExpirationDateIsInPeriod(periodForLicense) 
               || ActiveRequalificaiton.GetIfExpirationDateIsInPeriod(periodForRequalification) 
               || ActiveMedicalExams.Any(me => me.GetIfExpirationDateIsInPeriod(periodForMedicalExam)));

        #endregion
    }
}
