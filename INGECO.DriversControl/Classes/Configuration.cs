using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INGECO.DriversControl
{
    /// <summary>
    /// The configuration settings of the application.
    /// </summary>
    static class Configuration
    {
        /// <summary>
        /// The address of the database server where is stored the system data.
        /// </summary>
        public static string DatabaseHostName { get; set; }

        /// <summary>
        /// The username used for log in the database server.
        /// </summary>
        public static string DatabaseUserName { get; set; }

        /// <summary>
        /// The password used to log in the database server.
        /// </summary>
        public static string DatabasePassword { get; set; }

        /// <summary>
        /// The name of the database where the data of the system is stored.
        /// </summary>
        public static string DatabaseName { get; set; }

        /// <summary>
        /// The time before expiration to be warned for driver's license expiration.
        /// </summary>
        public static TimeSpan ExpireWarningForLicense { get; set; } = new TimeSpan(30, 0, 0, 0);

        /// <summary>
        /// The time before expiration to be warned for driver's requalification expiration.
        /// </summary>
        public static TimeSpan ExpireWarningForRequalification { get; set; } = new TimeSpan(30, 0, 0, 0);

        /// <summary>
        /// The time before expiration to be warned for a driver's medical exam expiration.
        /// </summary>
        public static TimeSpan ExpireWarningForMedicalExam { get; set; } = new TimeSpan(30, 0, 0, 0);

    }
}
