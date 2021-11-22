using System;
using System.ComponentModel.DataAnnotations;

namespace Roadsaft.DriversManagement.Data
{
    /// <summary>
    /// Represents a medical exam done to the driver.
    /// </summary>
    public class MedicalExam
    {
        #region Constructor

        /// <summary>
        /// Default constructor
        /// </summary>
        public MedicalExam()
        { }

        #endregion

        #region Properties

        [Key]
        public int Id { get; set; }

        /// <summary>
        /// The medical exam's type.
        /// </summary>
        public MedicalExamType Type { get; set; }

        /// <summary>
        /// The date when the medical exam was registered in the system.
        /// </summary>
        public DateTime Created { get; set; }

        /// <summary>
        /// The medical exam's date of making.
        /// </summary>
        public DateTime DateOfMaking { get; set; }

        /// <summary>
        /// The medical exam's date of expiration.
        /// </summary>
        public DateTime Expires { get; set; }

        /// <summary>
        /// The medical exam's result.
        /// </summary>
        public MedicalExamResult Result { get; set; }

        /// <summary>
        /// A descrption of the Medical Exam.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// The date and time when the Medical Exam was archived.
        /// </summary>
        public DateTime Archived { get; set; }

        /// <summary>
        /// True if the medical exams is active.
        /// </summary>
        public bool IsActive { get; set; }

        /// <summary>
        /// True if the medical exam is expired.
        /// </summary>
        public bool IsExpired => Expires <= DateTime.Now;

        public int DriverId { get; set; }

        /// <summary>
        /// The driver that the medical exam belongs to.
        /// </summary>
        public Driver Driver { get; set; }

        #endregion

        #region Methods

        /// <summary>
        /// Determines if the expiration date is in the specified period.
        /// </summary>
        /// <param name="period">The specified period.</param>
        /// <returns>True if expiration date is in the period.</returns>
        public bool GetIfExpirationDateIsInPeriod(TimeSpan period)
            => (DateTime.Now + period) > Expires;

        #endregion
    }
}