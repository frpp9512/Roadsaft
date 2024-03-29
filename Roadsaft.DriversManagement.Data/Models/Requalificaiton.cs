﻿using SmartB1t.Next.Database;
using System;

namespace Roadsaft.DriversManagement.Data
{
    /// <summary>
    /// Represents a re-qualification test of a driver.
    /// </summary>
    public class Requalificaiton : DBObject
    {
        #region Constructor

        /// <summary>
        /// Default constructor.
        /// </summary>
        public Requalificaiton()
        {

        }

        #endregion

        #region Properties

        [DBTableField("requalification_id", IsPrimaryKey = true)]
        public int Id { get; set; }

        /// <summary>
        /// The driver that the re-qualification belongs to.
        /// </summary>
        [DBTableField("driver_id")]
        public Driver Driver { get; set; }

        /// <summary>
        /// The date when the requalification was registered in the system.
        /// </summary>
        [DBTableField("req_createddate")]
        public DateTime Created { get; set; }

        /// <summary>
        /// The date of making of the re-qualification.
        /// </summary>
        [DBTableField("req_dateofmaking")]
        public DateTime DateOfMaking { get; set; }

        /// <summary>
        /// The expiration date of the re-qualification.
        /// </summary>
        [DBTableField("req_expires")]
        public DateTime Expires { get; set; }

        /// <summary>
        /// The volume where the re-qualification is registered.
        /// </summary>
        [DBTableField("volume")]
        public string Volume { get; set; }

        /// <summary>
        /// The page of the volume where the re-qualification is registered.
        /// </summary>
        [DBTableField("page")]
        public string Page { get; set; }

        /// <summary>
        /// A description of the Requalification.
        /// </summary>
        [DBTableField("req_description")]
        public string Description { get; set; }

        /// <summary>
        /// The date and time when the Requalification was archived.
        /// </summary>
        [DBTableField("req_archived")]
        public DateTime Archived { get; set; }

        /// <summary>
        /// True when the re-qualification is active.
        /// </summary>
        [DBTableField("req_isactive")]
        public bool IsActive { get; set; }

        /// <summary>
        /// True when the re-qualification is expired.
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