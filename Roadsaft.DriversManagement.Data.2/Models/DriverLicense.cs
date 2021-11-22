using System;
using System.ComponentModel.DataAnnotations;

namespace Roadsaft.DriversManagement.Data
{
    public class DriverLicense
    {
        #region Constructor

        /// <summary>
        /// Default constructor.
        /// </summary>
        public DriverLicense()
        { }

        #endregion

        #region Properties

        [Key]
        public int Id { get; set; }

        /// <summary>
        /// The driver's license number.
        /// </summary>
        public string Number { get; set; }

        /// <summary>
        /// The driver's license category.
        /// </summary>
        public string Category { get; set; }

        /// <summary>
        /// The date when the driver's license was registered in the system.
        /// </summary>
        public DateTime Created { get; set; } = DateTime.Now;

        /// <summary>
        /// The date when the driver's license was maked.
        /// </summary>
        public DateTime DateOfMaking { get; set; }

        /// <summary>
        /// The driver's license expiration date.
        /// </summary>
        public DateTime Expires { get; set; }

        /// <summary>
        /// A description of the driver's license.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// The date and time when the Driver License was archived.
        /// </summary>
        public DateTime Archived { get; set; }

        /// <summary>
        /// True if the driver's license is active.
        /// </summary>
        public bool IsActive { get; set; }

        public int DriverId { get; set; }

        /// <summary>
        /// The driver that the driver's license belongs to.
        /// </summary>
        public Driver Driver { get; set; }

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
        public bool GetIfExpirationDateIsInPeriod(TimeSpan period) => (DateTime.Now + period) > Expires;

        #endregion
    }
}