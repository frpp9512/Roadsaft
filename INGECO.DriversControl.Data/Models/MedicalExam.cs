using SmartB1t.Database;
using System;

namespace INGECO.DriversControl.Data
{
    /// <summary>
    /// Represents a medical exam done to the driver.
    /// </summary>
    public class MedicalExam : DBObject
    {
        #region Constructor

        /// <summary>
        /// Default constructor
        /// </summary>
        public MedicalExam()
            : base("med_exam",
                  new string[]
                  {
                      "med_exam_id",
                      "med_exam_type",
                      "med_exam_createddate",
                      "med_exam_dateofmaking",
                      "med_exam_expires",
                      "med_exam_result",
                      "med_exam_description",
                      "med_exam_archived",
                      "med_exam_isactive",
                      "driver_id"
                  })
        { }

        #endregion

        #region Properties

        /// <summary>
        /// The driver that the medical exam belongs to.
        /// </summary>
        public Driver Driver { get; set; }

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

        #endregion

        #region Methods

        /// <summary>
        /// Determines if the expiration date is in the specified period.
        /// </summary>
        /// <param name="period">The specified period.</param>
        /// <returns>True if expiration date is in the period.</returns>
        public bool GetIfExpirationDateIsInPeriod(TimeSpan period)
        {
            return (DateTime.Now + period) > Expires;
        }

        #endregion

        #region DBObject Implementation

        protected override object[] Values => new object[] { Type.ToString(), Created, DateOfMaking, Expires, Result.ToString(), Description, Archived, IsActive, Driver?.PrimaryKeyValue };

        protected override void SetValues(DataResult dr)
        {
            Type = dr.GetValue<MedicalExamType>("med_exam_type");
            Created = dr.GetValue<DateTime>("med_exam_createddate");
            DateOfMaking = dr.GetValue<DateTime>("med_exam_dateofmaking");
            Expires = dr.GetValue<DateTime>("med_exam_expires");
            Result = dr.GetValue<MedicalExamResult>("med_exam_result");
            Description = dr.GetValue<string>("med_exam_description");
            Archived = dr.GetValue<DateTime>("med_exam_archived");
            IsActive = dr.GetValue<bool>("med_exam_isactive");
            Driver = new Driver { PrimaryKeyValue = dr.GetValue<int>("driver_id") };
        }

        #endregion
    }
}