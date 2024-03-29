﻿using SmartB1t.Next.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roadsaft.DriversManagement.Data
{
    /// <summary>
    /// Represents a driver working in the bussiness.
    /// </summary>
    [DBEntity("driver")]
    public class Driver : DBObject
    {
        #region Constructor

        /// <summary>
        /// Default constructor.
        /// </summary>
        public Driver()
        { }

        #endregion

        #region Properties

        [DBTableField("driver_id", IsPrimaryKey = true)]
        public int Id { get; set; }

        /// <summary>
        /// The full name of the driver.
        /// </summary>
        [DBTableField("fullname")]
        public string FullName { get; set; }

        /// <summary>
        /// The position of the driver.
        /// </summary>
        [DBTableField("position")]
        public string Position { get; set; }

        /// <summary>
        /// The personal id of the driver.
        /// </summary>
        [DBTableField("personal_id")]
        public string PersonalId { get; set; }

        /// <summary>
        /// The category of the driver.
        /// </summary>
        [DBTableField("category")]
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
        [DBTableField("description")]
        public string Description { get; set; }

        /// <summary>
        /// The date and time when the driver was registered in the system.
        /// </summary>
        [DBTableField("registered")]
        public DateTime Registered { get; set; }

        /// <summary>
        /// The date and time when the driver was deactivated.
        /// </summary>
        [DBTableField("archived")]
        public DateTime Archived { get; set; }

        /// <summary>
        /// <see langword="true"/> if driver is active in the system.
        /// </summary>
        [DBTableField("isActive")]
        public bool IsActive { get; set; } = true;

        /// <summary>
        /// The current active requalification of the driver
        /// </summary>
        public Requalificaiton Requalificaiton { get; set; }

        /// <summary>
        /// The current active driver license of the driver
        /// </summary>
        public DriverLicense DriverLicense { get; set; }

        /// <summary>
        /// The current active medical exams of the driver
        /// </summary>
        public List<MedicalExam> MedicalExams { get; set; }

        /// <summary>
        /// False if DriverLicense, Requalification or any MedicalExam has expired.
        /// </summary>
        public bool HasExpiredParameters =>
            DriverLicense == null
            || Requalificaiton == null
            || MedicalExams == null
            || MedicalExams.Count == 0
                    ? true
                    : DriverLicense.IsExpired || Requalificaiton.IsExpired || MedicalExams.Count(me => me.IsExpired) > 0;

        /// <summary>
        /// Returns <see langword="true"/> if the driver has a setted Driver's License.
        /// </summary>
        public bool HasActiveLicense => DriverLicense != null;

        /// <summary>
        /// Returns <see langword="true"/> if the active driver's license is expired. If the driver's license is not setted returns <see langword="false"/>.
        /// </summary>
        public bool HasExpiredLicense => HasActiveLicense ? DriverLicense.IsExpired : false;

        /// <summary>
        /// Returns <see langword="true"/> if the driver has a setted Requalification.
        /// </summary>
        public bool HasActiveRequalification => Requalificaiton != null;

        /// <summary>
        /// Returns <see langword="true"/> if the active Requalification is expired. If the Requalification is not setted returns <see langword="false"/>
        /// </summary>
        public bool HasExpiredRequalification => HasActiveRequalification ? Requalificaiton.IsExpired : false;

        /// <summary>
        /// Returns <see langword="true"/> if the driver have at least one active Medical Exam.
        /// </summary>
        public bool HasMedicalExams => MedicalExams?.Count > 0;

        /// <summary>
        /// Returns <see langword="true"/> if the driver have at least one Medical Exam expired. If have no Medical Exam returns <see langword="false"/>.
        /// </summary>
        public bool HasExpiredMedicalExam => HasMedicalExams ? MedicalExams.Count(me => me.IsExpired) > 0 : false;

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
        {
            return DriverLicense == null || Requalificaiton == null || MedicalExams == null
                    ? false
                    : DriverLicense.GetIfExpirationDateIsInPeriod(periodForLicense) || Requalificaiton.GetIfExpirationDateIsInPeriod(periodForRequalification) || MedicalExams.Count(me => me.GetIfExpirationDateIsInPeriod(periodForMedicalExam)) > 0;
        }

        #endregion
    }
}
