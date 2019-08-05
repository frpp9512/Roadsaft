using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Drawing;

namespace Roadsaft.DriversManagement
{
    /// <summary>
    /// The configuration settings of the application.
    /// </summary>
    static class Configuration
    {
        /// <summary>
        /// The path of the application configuration file.
        /// </summary>
        private static string ConfigurationFilePath => AppDomain.CurrentDomain.BaseDirectory + "config.cfg";

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
        /// The last view used in the user interface.
        /// </summary>
        public static View LastUsedView { get; set; } = View.Details;

        /// <summary>
        /// The last selected DriversView option.
        /// </summary>
        public static DriversView LastDriversView { get; set; } = DriversView.AllDrivers;

        /// <summary>
        /// The last used filter by driver category.
        /// </summary>
        public static DriverCategoryFilter LastDriverCategoryFilter { get; set; } = DriverCategoryFilter.All;

        /// <summary>
        /// The last Window's State that the form was when closed.
        /// </summary>
        public static FormWindowState LastWindowState { get; set; } = FormWindowState.Normal;

        /// <summary>
        /// The last Window's height that the form had when closed.
        /// </summary>
        public static int WindowHeight { get; set; } = 575;

        /// <summary>
        /// The last Window's width that form had when closed.
        /// </summary>
        public static int WindowWidth { get; set; } = 880;

        /// <summary>
        /// The last Window's size that the form had when closed.
        /// </summary>
        public static Size WindowSize
        {
            get { return new Size(WindowWidth, WindowHeight); }
            set { WindowHeight = value.Height; WindowWidth = value.Width; }
        }

        /// <summary>
        /// The X coordinates of last location of the window.
        /// </summary>
        public static int PositionX { get; set; } = 0;

        /// <summary>
        /// The Y coordinates of last location of the window.
        /// </summary>
        public static int PositionY { get; set; } = 0;

        /// <summary>
        /// The last position of the window when closed.
        /// </summary>
        public static Point LastLocation
        {
            get => new Point(PositionX, PositionY);
            set { PositionX = value.X; PositionY = value.Y; }
        }

        /// <summary>
        /// Check if exists the configuration file.
        /// </summary>
        /// <returns><see langword="true"/> if configuration file exists.</returns>
        public static bool ExistConfigurationFile()
        {
            return File.Exists(ConfigurationFilePath);
        }

        /// <summary>
        /// Save the configuration to file.
        /// </summary>
        public static void SaveToFile()
        {
            var fields = typeof(Configuration).GetProperties().ToList();
            using (var sw = new StreamWriter(ConfigurationFilePath))
            {
                fields.ForEach(f => sw.WriteLine($"{f.Name}={f.GetValue(null)}"));
            }
        }

        /// <summary>
        /// Loads the configuration from file.
        /// </summary>
        public static void LoadFromFile()
        {
            using (var sr = new StreamReader(ConfigurationFilePath))
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
                            case nameof(LastUsedView):
                                LastUsedView = (View)Enum.Parse(typeof(View), values[1]);
                                continue;
                            case nameof(LastDriversView):
                                LastDriversView = (DriversView)Enum.Parse(typeof(DriversView), values[1]);
                                continue;
                            case nameof(LastDriverCategoryFilter):
                                LastDriverCategoryFilter = (DriverCategoryFilter)Enum.Parse(typeof(DriverCategoryFilter), values[1]);
                                continue;
                            case nameof(LastWindowState):
                                LastWindowState = (FormWindowState)Enum.Parse(typeof(FormWindowState), values[1]);
                                continue;
                            case nameof(WindowWidth):
                                WindowWidth = int.Parse(values[1]);
                                continue;
                            case nameof(WindowHeight):
                                WindowHeight = int.Parse(values[1]);
                                continue;
                            case nameof(PositionX):
                                PositionX = int.Parse(values[1]);
                                continue;
                            case nameof(PositionY):
                                PositionY = int.Parse(values[1]);
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