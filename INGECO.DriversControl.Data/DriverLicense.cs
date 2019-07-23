﻿using SmartB1t.Database;
using System;

namespace INGECO.DriversControl.Data
{
    public class DriverLicense : DBObject
    {
        #region Constructor

        /// <summary>
        /// Default constructor.
        /// </summary>
        public DriverLicense()
            : base("driver_license",
                  new string[] 
                  {
                      "driver_license_id",
                      "dl_category",
                      "dl_expires",
                      "dl_isactive",
                      "driver_id"
                  })
        { }

        #endregion

        #region Properties

        /// <summary>
        /// The driver that the driver's license belongs to.
        /// </summary>
        public Driver Driver { get; set; }

        /// <summary>
        /// The driver's license number.
        /// </summary>
        public string Number { get; set; }

        /// <summary>
        /// The driver's license category.
        /// </summary>
        public string Category { get; set; }

        /// <summary>
        /// The driver's license expiration date.
        /// </summary>
        public DateTime Expires { get; set; }

        /// <summary>
        /// True if the driver's license is active.
        /// </summary>
        public bool IsActive { get; set; }

        /// <summary>
        /// True if the driver's license is expired.
        /// </summary>
        public bool IsExpired => Expires > DateTime.Now;

        #endregion

        #region DBObject Implementation

        protected override object[] Values => new object[] { Category, Expires, IsActive, Driver.PrimaryKeyValue };

        protected override void SetValues(DataResult dr)
        {
            Category = dr.GetValue<string>("dl_category");
            Expires = dr.GetValue<DateTime>("dl_expires");
            IsActive = dr.GetValue<bool>("dl_isactive");
            Driver = new Driver { PrimaryKeyValue = dr.GetValue<string>("driver_id") };
        }

        #endregion
    }
}