﻿using SmartB1t.Next.Database;
using System;

namespace Roadsaft.DriversManagement.Data
{
    /// <summary>
    /// Represents a medical exam done to the driver.
    /// </summary>
    [DBEntity("med_exam")]
    public class MedicalExam : DBObject
    {
        #region Constructor

        /// <summary>
        /// Default constructor
        /// </summary>
        public MedicalExam()
        { }

        #endregion

        #region Properties

        [DBTableField("med_exam_id", IsPrimaryKey = true)]
        public int Id { get; set; }

        /// <summary>
        /// The driver that the medical exam belongs to.
        /// </summary>
        [DBTableField("driver_id")]
        public Driver Driver { get; set; }

        /// <summary>
        /// The medical exam's type.
        /// </summary>
        [DBTableField("med_exam_type")]
        public MedicalExamType Type { get; set; }

        /// <summary>
        /// The date when the medical exam was registered in the system.
        /// </summary>
        [DBTableField("med_exam_createddate")]
        public DateTime Created { get; set; }

        /// <summary>
        /// The medical exam's date of making.
        /// </summary>
        [DBTableField("med_exam_dateofmaking")]
        public DateTime DateOfMaking { get; set; }

        /// <summary>
        /// The medical exam's date of expiration.
        /// </summary>
        [DBTableField("med_exam_expires")]
        public DateTime Expires { get; set; }

        /// <summary>
        /// The medical exam's result.
        /// </summary>
        [DBTableField("med_exam_result")]
        public MedicalExamResult Result { get; set; }

        /// <summary>
        /// A descrption of the Medical Exam.
        /// </summary>
        [DBTableField("med_exam_description")]
        public string Description { get; set; }

        /// <summary>
        /// The date and time when the Medical Exam was archived.
        /// </summary>
        [DBTableField("med_exam_archived")]
        public DateTime Archived { get; set; }

        /// <summary>
        /// True if the medical exams is active.
        /// </summary>
        [DBTableField("med_exam_isactive")]
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
    }
}