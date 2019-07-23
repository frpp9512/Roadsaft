using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmartB1t.Database;

namespace INGECO.DriversControl.Data
{
    /// <summary>
    /// A controller for the drivers data stored in a MySQL/MariaDB database.
    /// </summary>
    class DriversDatabaseController : IDriversDataProvider
    {
        public List<DriverLicense> GetDriverLicenseHistory(Driver driver)
        {
            return MySQLConnector.CurrentConnection.ExecuteStoredProcedure("GetLicensesHistoryForDriver", new Parameter("driver_id", driver.PrimaryKeyValue)).GetList<DriverLicense>();
        }

        public List<Driver> GetDrivers()
        {
            var drivers = MySQLConnector.CurrentConnection.ExecuteStoredProcedure("GetDrivers").GetList<Driver>();
            drivers.ForEach(d => SetDriverDependencies(d));
            return drivers;
        }

        private void SetDriverDependencies(Driver driver)
        {
            var driver_id = new Parameter("driver_id", driver.PrimaryKeyValue);
            var license = new DriverLicense { PrimaryKeyValue = MySQLConnector.CurrentConnection.ExecuteFunction<string>("GetActiveLicenseIdForDriver", driver_id) };
            license.LoadMe();
            var requalification = new Requalificaiton { PrimaryKeyValue = MySQLConnector.CurrentConnection.ExecuteFunction<string>("GetActiveDriverRequalificationId", driver_id) };
            requalification.LoadMe();
            var medexams = MySQLConnector.CurrentConnection.ExecuteStoredProcedure("GetActiveMedExamsForDriver", driver_id).GetList<MedicalExam>();
            driver.DriverLicense = license;
            driver.Requalificaiton = requalification;
            driver.MedicalExams = medexams;
        }

        public void InitializeDataConnection(params object[] parameters)
        {
            MySQLConnector.CurrentConnection.SetConnection(
                (string)parameters[0],
                (string)parameters[1],
                (string)parameters[2],
                (string)parameters[3]
                );
        }
    }
}
