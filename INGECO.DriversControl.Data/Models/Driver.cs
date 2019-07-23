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
                      "fullname",
                      "position",
                      "personal_id"
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

        #endregion

        #region DBObject Implementation

        protected override object[] Values => new object[] { FullName, Position, PersonalId };

        protected override void SetValues(DataResult dr)
        {
            FullName = dr.GetValue<string>("fullname");
            Position = dr.GetValue<string>("position");
            PersonalId = dr.GetValue<string>("personal_id");
        }

        #endregion
    }
}
