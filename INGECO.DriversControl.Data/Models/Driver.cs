using SmartB1t.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INGECO.DriversControl.Data
{
    /// <summary>
    /// Represents a driver working in the bussiness.
    /// </summary>
    public class Driver : DBObject
    {
        #region Constructor

        /// <summary>
        /// Default constructor.
        /// </summary>
        public Driver()
            : base("driver",
                  new string[]
                  {
                      "driver_id",
                      "fullname",
                      "position",
                      "personal_id",
                      "description"
                  })
        { }

        #endregion

        #region Properties

        /// <summary>
        /// The full name of the driver.
        /// </summary>
        public string FullName { get; set; }

        /// <summary>
        /// The position of the driver.
        /// </summary>
        public string Position { get; set; }

        /// <summary>
        /// The personal id of the driver.
        /// </summary>
        public string PersonalId { get; set; }

        /// <summary>
        /// A description of the driver.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// The current active requalification of the driver
        /// </summary>
        public Requalificaiton Requalificaiton { get; set; }

        /// <summary>
        /// The current active driver license of the driver
        /// </summary>
        public DriverLicense DriverLicense { get; set; }

        /// <summary>
        /// The current active medical exams of the driver
        /// </summary>
        public List<MedicalExam> MedicalExams { get; set; }

        /// <summary>
        /// False if DriverLicense, Requalification or any MedicalExam has expired.
        /// </summary>
        public bool HasExpiredParameters
        {
            get
            {
                return DriverLicense == null || Requalificaiton == null || MedicalExams == null || MedicalExams.Count == 0
                    ? true
                    : DriverLicense.IsExpired || Requalificaiton.IsExpired || MedicalExams.Count(me => me.IsExpired) > 0;
            }
        }

        #endregion

        #region Methods

        /// <summary>
        /// Determines if any of the expiration dates of License, Requalification or Medical Exams are in the specified period.
        /// </summary>
        /// <param name="periodForLicense">The specified period for driver's license.</param>
        /// <param name="periodForRequalification">The specified period for driver's requalification.</param>
        /// <param name="periodForMedicalExam">The specified period for a driver's medical examl.</param>
        /// <returns>True if expiration date is in the period.</returns>
        public bool GetIfAnyParameterExpireDateIsInPeriod(TimeSpan periodForLicense, TimeSpan periodForRequalification, TimeSpan periodForMedicalExam)
        {
            return DriverLicense == null || Requalificaiton == null || MedicalExams == null
                    ? false
                    : DriverLicense.GetIfExpirationDateIsInPeriod(periodForLicense) || Requalificaiton.GetIfExpirationDateIsInPeriod(periodForRequalification) || MedicalExams.Count(me => me.GetIfExpirationDateIsInPeriod(periodForMedicalExam)) > 0;
        }

        #endregion

        #region DBObject Implementation

        protected override object[] Values => new object[] { FullName, Position, PersonalId, Description };

        protected override void SetValues(DataResult dr)
        {
            FullName = dr.GetValue<string>("fullname");
            Position = dr.GetValue<string>("position");
            PersonalId = dr.GetValue<string>("personal_id");
            Description = dr.GetValue<string>("description");
        }

        #endregion
    }
}
