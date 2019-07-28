using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

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
        /// The time interval (in minutes) taked for refresh drivers data.
        /// </summary>
        public static int RefreshInterval { get; set; } = 2;

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

        /// <summary>
        /// Save the configuration to file.
        /// </summary>
        public static void SaveToFile()
        {
            var fields = typeof(Configuration).GetProperties().ToList();
            using (var sw = new StreamWriter(AppDomain.CurrentDomain.BaseDirectory + "config.cfg"))
            {
                fields.ForEach(f => sw.WriteLine($"{f.Name}={f.GetValue(null)}"));
            }
        }

        /// <summary>
        /// Loads the configuration from file.
        /// </summary>
        public static void LoadFromFile()
        {
            using (var sr = new StreamReader(AppDomain.CurrentDomain.BaseDirectory + "config.cfg"))
            {
                while (!sr.EndOfStream)
                {
                    var readedline = sr.ReadLine();
                    if (readedline.Contains('='))
                    {
                        var values = readedline.Split('=');
                        switch (values[0])
                        {
                            case nameof(DatabaseHostName):
                                DatabaseHostName = values[1];
                                continue;
                            case nameof(DatabaseUserName):
                                DatabaseUserName = values[1];
                                continue;
                            case nameof(DatabasePassword):
                                DatabasePassword = values[1];
                                continue;
                            case nameof(DatabaseName):
                                DatabaseName = values[1];
                                continue;
                            case nameof(RefreshInterval):
                                RefreshInterval = int.Parse(values[1]);
                                continue;
                            case nameof(ExpireWarningForLicense):
                                ExpireWarningForLicense = TimeSpan.Parse(values[1]);
                                continue;
                            case nameof(ExpireWarningForRequalification):
                                ExpireWarningForMedicalExam = TimeSpan.Parse(values[1]);
                                continue;
                            default:
                                break;
                        }
                    }
                }
            }
        }
    }
}