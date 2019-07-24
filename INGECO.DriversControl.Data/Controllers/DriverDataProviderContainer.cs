using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INGECO.DriversControl.Data
{
    public static class DriverDataProviderContainer
    {
        /// <summary>
        /// Gets the current instance for <see cref="IDriversDataProvider"/>.
        /// </summary>
        public static IDriversDataProvider Controller { get; private set; }

        /// <summary>
        /// Initializes the <see cref="IDriversDataProvider"/> with a <see cref="DriversDatabaseController"/> instance
        /// with the default connection values:
        /// host: localhost
        /// user: root
        /// password:
        /// database name: ingeco_driverscontrol
        /// </summary>
        public static void InitializeWithDatabaseProvider()
        {
            Controller = new DriversDatabaseController();
            Controller.InitializeDataConnection("localhost", "root", "", "ingeco_driverscontrol");
        }

        /// <summary>
        /// Initializes the <see cref="IDriversDataProvider"/> with a <see cref="DriversDatabaseController"/> instance.
        /// </summary>
        /// <param name="parameters">The connection parameters.</param>
        public static void InitializeWithDatabaseProvider(params object[] parameters)
        {
            Controller = new DriversDatabaseController();
            Controller.InitializeDataConnection(parameters[0], parameters[1], parameters[2], parameters[3]);
        }
    }
}
