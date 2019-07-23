using SmartB1t.Database;
using System;

namespace INGECO.DriversControl.Data
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
            : base ("requalification",
                  new string[] 
                  {
                      "requalification_id",
                      "req_createddate",
                      "req_dateofmaking",
                      "req_expires",
                      "volume",
                      "page",
                      "req_isactive",
                      "driver_id"
                  })
        {

        }

        #endregion

        #region Properties

        /// <summary>
        /// The driver that the re-qualification belongs to.
        /// </summary>
        public Driver Driver { get; set; }

        /// <summary>
        /// The date when the requalification was registered in the system.
        /// </summary>
        public DateTime Created { get; set; }

        /// <summary>
        /// The date of making of the re-qualification.
        /// </summary>
        public DateTime DateOfMaking { get; set; }

        /// <summary>
        /// The expiration date of the re-qualification.
        /// </summary>
        public DateTime Expires { get; set; }

        /// <summary>
        /// The volume where the re-qualification is registered.
        /// </summary>
        public string Volume { get; set; }

        /// <summary>
        /// The page of the volume where the re-qualification is registered.
        /// </summary>
        public string Page { get; set; }

        /// <summary>
        /// True when the re-qualification is active.
        /// </summary>
        public bool IsActive { get; set; }

        /// <summary>
        /// True when the re-qualification is expired.
        /// </summary>
        public bool IsExpired => Expires > DateTime.Now;

        #endregion

        #region DBObject Implementation

        protected override object[] Values => new object[] { Created, DateOfMaking, Expires, Volume, Page, IsActive, Driver.PrimaryKeyValue };

        protected override void SetValues(DataResult dr)
        {
            Created = dr.GetValue<DateTime>("req_createddate");
            DateOfMaking = dr.GetValue<DateTime>("req_dateofmaking");
            Expires = dr.GetValue<DateTime>("req_expires");
            Volume = dr.GetValue<string>("volume");
            Page = dr.GetValue<string>("page");
            IsActive = dr.GetValue<bool>("req_isactive");
            Driver = new Driver { PrimaryKeyValue = dr.GetValue<string>("driver_id") };
        }

        #endregion
    }
}