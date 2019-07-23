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
        /// True if the medical exams is active.
        /// </summary>
        public bool IsActive { get; set; }

        /// <summary>
        /// True if the medical exam is expired.
        /// </summary>
        public bool IsExpired => Expires > DateTime.Now;

        #endregion

        #region DBObject Implementation

        protected override object[] Values => new object[] { Type, Created, Expires, Result, IsActive, Driver?.PrimaryKeyValue };

        protected override void SetValues(DataResult dr)
        {
            Type = dr.GetValue<MedicalExamType>("med_exam_type");
            Created = dr.GetValue<DateTime>("med_exam_createddate");
            DateOfMaking = dr.GetValue<DateTime>("med_exam_dateofmaking");
            Expires = dr.GetValue<DateTime>("med_exam_expires");
            Result = dr.GetValue<MedicalExamResult>("med_exam_result");
            IsActive = dr.GetValue<bool>("med_exam_isactive");
            Driver = new Driver { PrimaryKeyValue = dr.GetValue<string>("driver_id") };
        }

        #endregion
    }
}