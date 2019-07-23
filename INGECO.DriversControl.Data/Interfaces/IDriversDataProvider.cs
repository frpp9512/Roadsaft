using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INGECO.DriversControl.Data
{
    /// <summary>
    /// Represents a manager of the drivers data.
    /// </summary>
    public interface IDriversDataProvider
    {
        /// <summary>
        /// Initializes the connection to the data provider.
        /// </summary>
        /// <param name="parameters">The parameters needed to establish the data connection.</param>
        void InitializeDataConnection(params object[] parameters);

        /// <summary>
        /// Get the list of drivers stored in the system.
        /// </summary>
        /// <returns>The list of drivers.</returns>
        List<Driver> GetDrivers();

        /// <summary>
        /// Get the history of all driver's licenses.
        /// </summary>
        /// <returns>List of driver's licenses history.</returns>
        List<DriverLicense> GetDriverLicenseHistory(Driver driver);
    }
}
