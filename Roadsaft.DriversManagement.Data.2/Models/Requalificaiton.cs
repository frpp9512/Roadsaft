using System;

namespace Roadsaft.DriversManagement.Data
{
    /// <summary>
    /// Represents a re-qualification test of a driver.
    /// </summary>
    public class Requalificaiton
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

        public int Id { get; set; }

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
        /// A description of the Requalification.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// The date and time when the Requalification was archived.
        /// </summary>
        public DateTime Archived { get; set; }

        /// <summary>
        /// True when the re-qualification is active.
        /// </summary>
        public bool IsActive { get; set; }

        /// <summary>
        /// True when the re-qualification is expired.
        /// </summary>
        public bool IsExpired => Expires <= DateTime.Now;

        public int DriverId { get; set; }

        /// <summary>
        /// The driver that the re-qualification belongs to.
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
        {
            return (DateTime.Now + period) > Expires;
        }

        #endregion
    }
}