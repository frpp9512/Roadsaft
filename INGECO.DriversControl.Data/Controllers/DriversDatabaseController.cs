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
    public class DriversDatabaseController : IDriversDataProvider
    {
        #region Singlenton

        /// <summary>
        /// The current instance for <see cref="DriversDatabaseController"/>.
        /// </summary>
        static DriversDatabaseController controller = null;

        /// <summary>
        /// Gets the current instance for <see cref="DriversDatabaseController"/> or a new one by default.
        /// </summary>
        public static DriversDatabaseController Controller => controller ?? new DriversDatabaseController();

        #endregion

        public List<DriverLicense> GetDriverLicenseHistory(Driver driver)
        {
            var lics = MySQLConnector.CurrentConnection.ExecuteStoredProcedure("GetLicensesHistoryForDriver", new Parameter("driver_id", driver.PrimaryKeyValue)).GetList<DriverLicense>();
            lics.ForEach(l => l.Driver = driver);
            return lics;
        }

        public List<Driver> GetDrivers()
        {
            var drivers = MySQLConnector.CurrentConnection.ExecuteStoredProcedure("GetDrivers").GetList<Driver>();
            drivers.ForEach(d => SetDriverDependencies(d));
            return drivers;
        }

        /// <summary>
        /// Loads the DriverLicense, Requalification and MedicalExam list for the specified driver.
        /// </summary>
        /// <param name="driver">The driver to be updated.</param>
        private void SetDriverDependencies(Driver driver)
        {
            DriverLicense license = null;
            Requalificaiton requalification = null;
            var driver_id = new Parameter("driver_id", driver.PrimaryKeyValue);
            var licenseId = MySQLConnector.CurrentConnection.ExecuteFunction<int>("GetActiveLicenseIdForDriver", driver_id);
            if(licenseId > 0)
            {
                license = new DriverLicense { PrimaryKeyValue = licenseId };
                license.LoadMe();
            }
            var requalificationId = MySQLConnector.CurrentConnection.ExecuteFunction<int>("GetActiveRequalificationIdForDriver", driver_id);
            if(requalificationId> 0)
            {
                requalification = new Requalificaiton { PrimaryKeyValue = requalificationId };
                requalification.LoadMe();
            }
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

        public List<Requalificaiton> GetDriverRequalificationHistory(Driver driver)
        {
            var reqs = MySQLConnector.CurrentConnection.ExecuteStoredProcedure("GetRequalificationsHistoryForDriver", new Parameter("driver_id", driver.PrimaryKeyValue)).GetList<Requalificaiton>();
            reqs.ForEach(r => r.Driver = driver);
            return reqs;
        }

        public List<MedicalExam> GetDriverMedicalExamsHistory(Driver driver)
        {
            var medexams = MySQLConnector.CurrentConnection.ExecuteStoredProcedure("GetMedicalExamsHistoryForDriver", new Parameter("driver_id", driver.PrimaryKeyValue)).GetList<MedicalExam>();
            medexams.ForEach(m => m.Driver = driver);
            return medexams;
        }

        public bool AddNewDriver(Driver driver)
        {
            try
            {
                driver.InsertMe();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
