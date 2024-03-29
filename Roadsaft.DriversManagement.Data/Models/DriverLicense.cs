﻿using SmartB1t.Next.Database;
using System;

namespace Roadsaft.DriversManagement.Data
{
    [DBEntity("driver_license")]
    public class DriverLicense : DBObject
    {
        #region Constructor

        /// <summary>
        /// Default constructor.
        /// </summary>
        public DriverLicense()
        { }

        #endregion

        #region Properties

        [DBTableField("driver_license_id", IsPrimaryKey = true)]
        public int Id { get; set; }

        /// <summary>
        /// The driver that the driver's license belongs to.
        /// </summary>
        [DBTableField("driver_id")]
        public Driver Driver { get; set; }

        /// <summary>
        /// The driver's license number.
        /// </summary>
        [DBTableField("dl_number")]
        public string Number { get; set; }

        /// <summary>
        /// The driver's license category.
        /// </summary>
        [DBTableField("dl_category")]
        public string Category { get; set; }

        /// <summary>
        /// The date when the driver's license was registered in the system.
        /// </summary>
        [DBTableField("dl_createddate")]
        public DateTime Created { get; set; } = DateTime.Now;

        /// <summary>
        /// The date when the driver's license was maked.
        /// </summary>
        [DBTableField("dl_dateofmaking")]
        public DateTime DateOfMaking { get; set; }

        /// <summary>
        /// The driver's license expiration date.
        /// </summary>
        [DBTableField("dl_expires")]
        public DateTime Expires { get; set; }

        /// <summary>
        /// A description of the driver's license.
        /// </summary>
        [DBTableField("dl_description")]
        public string Description { get; set; }

        /// <summary>
        /// The date and time when the Driver License was archived.
        /// </summary>
        [DBTableField("dl_archived")]
        public DateTime Archived { get; set; }

        /// <summary>
        /// True if the driver's license is active.
        /// </summary>
        [DBTableField("dl_isactive")]
        public bool IsActive { get; set; }

        /// <summary>
        /// True if the driver's license is expired.
        /// </summary>
        public bool IsExpired => Expires <= DateTime.Now;

        #endregion

        #region Methods

        /// <summary>
        /// Determines if the expiration date is in the specified period.
        /// </summary>
        /// <param name="period">The specified period</param>
        /// <returns>True if expiration date is in the period.</returns>
        public bool GetIfExpirationDateIsInPeriod(TimeSpan period)
        {
            return (DateTime.Now + period) > Expires;
        }

        #endregion
    }
}