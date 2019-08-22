using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmartB1t.Database;

namespace Roadsaft.DriversManagement.Data
{
    /// <summary>
    /// A controller for the drivers data stored in a MySQL/MariaDB database.
    /// </summary>
    public class DriversDatabaseController : IDriversDataProvider
    {
        /// <summary>
        /// The actual database connector.
        /// </summary>
        private IDatabaseConnector DatabaseConnector { get; set; }

        public DriversDatabaseController(IDatabaseConnector databaseConnector)
        {
            DatabaseConnector = databaseConnector;
        }
        
        public List<DriverLicense> GetDriverLicenseHistory(Driver driver)
        {
            var lics = DatabaseConnector.ExecuteStoredProcedure("GetLicensesHistoryForDriver", new Parameter("driver_id", driver.PrimaryKeyValue)).GetList<DriverLicense>();
            lics.ForEach(l => l.Driver = driver);
            return lics;
        }

        public List<Driver> GetDrivers()
        {
            var drivers = DatabaseConnector.ExecuteStoredProcedure("GetDrivers").GetList<Driver>();
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
            var licenseId = DatabaseConnector.ExecuteFunction<int>("GetActiveLicenseIdForDriver", driver_id);
            if(licenseId > 0)
            {
                license = new DriverLicense { PrimaryKeyValue = licenseId };
                license = DatabaseConnector.SelectDBObject(license).GetDBObject<DriverLicense>();
            }
            var requalificationId = DatabaseConnector.ExecuteFunction<int>("GetActiveRequalificationIdForDriver", driver_id);
            if(requalificationId> 0)
            {
                requalification = new Requalificaiton { PrimaryKeyValue = requalificationId };
                requalification = DatabaseConnector.SelectDBObject(requalification).GetDBObject<Requalificaiton>();
            }
            var medexams = DatabaseConnector.ExecuteStoredProcedure("GetActiveMedExamsForDriver", driver_id).GetList<MedicalExam>();
            driver.DriverLicense = license;
            driver.Requalificaiton = requalification;
            driver.MedicalExams = medexams;
        }

        public void InitializeDataConnection(params object[] parameters)
        {
            DatabaseConnector.SetConnection(
                (string)parameters[0],
                (string)parameters[1],
                (string)parameters[2],
                (string)parameters[3]
                );
        }

        public List<Requalificaiton> GetDriverRequalificationHistory(Driver driver)
        {
            var reqs = DatabaseConnector.ExecuteStoredProcedure("GetRequalificationsHistoryForDriver", new Parameter("driver_id", driver.PrimaryKeyValue)).GetList<Requalificaiton>();
            reqs.ForEach(r => r.Driver = driver);
            return reqs;
        }

        public List<MedicalExam> GetDriverMedicalExamsHistory(Driver driver)
        {
            var medexams = DatabaseConnector.ExecuteStoredProcedure("GetMedicalExamsHistoryForDriver", new Parameter("driver_id", driver.PrimaryKeyValue)).GetList<MedicalExam>();
            medexams.ForEach(m => m.Driver = driver);
            return medexams;
        }

        public bool AddNewDriver(Driver driver)
        {
            try
            {
                driver.Registered = DateTime.Now;
                DatabaseConnector.InsertDBObject(driver);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool RenewalLicense(Driver driver, DriverLicense newLicense)
        {
            try
            {
                if (driver.DriverLicense != null)
                {
                    driver.DriverLicense.IsActive = false;
                    driver.DriverLicense.Archived = DateTime.Now;
                    DatabaseConnector.UpdateDBObject(driver.DriverLicense);
                }
                newLicense.IsActive = true;
                if(!AddNewDriverLicense(driver, newLicense))
                {
                    throw new Exception("Error adding new driver's license.");
                }
                driver.DriverLicense = newLicense;
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool RenewalRequalification(Driver driver, Requalificaiton requalificaiton)
        {
            try
            {
                if (driver.Requalificaiton != null)
                {
                    driver.Requalificaiton.IsActive = false;
                    driver.Requalificaiton.Archived = DateTime.Now;
                    DatabaseConnector.UpdateDBObject(driver.Requalificaiton);
                }
                requalificaiton.IsActive = true;
                if (!AddNewRequalification(driver, requalificaiton))
                {
                    throw new Exception("Error adding new driver's requalification.");
                }
                driver.Requalificaiton = requalificaiton;
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool AddNewDriverLicense(Driver driver, DriverLicense license)
        {
            try
            {
                license.Driver = driver;
                DatabaseConnector.InsertDBObject(license);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool AddNewRequalification(Driver driver, Requalificaiton requalification)
        {
            try
            {
                requalification.Driver = driver;
                DatabaseConnector.InsertDBObject(requalification);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool AddNewMedicalExam(Driver driver, MedicalExam medicalExam)
        {
            try
            {
                medicalExam.Driver = driver;
                DatabaseConnector.InsertDBObject(medicalExam);
                driver.MedicalExams.Add(medicalExam);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool ArchiveMedicalExam(Driver driver, MedicalExam medicalExam)
        {
            try
            {
                medicalExam.IsActive = false;
                medicalExam.Archived = DateTime.Now;
                _ = driver.MedicalExams.Remove(medicalExam);
                DatabaseConnector.UpdateDBObject(medicalExam);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public List<Driver> GetDriversWithoutIssues(TimeSpan licenseExpireWarning, TimeSpan requalificationExpireWarning, TimeSpan medicalExamExpireWarning)
        {
            var drivers = DatabaseConnector
                .ExecuteStoredProcedure
                (
                "GetDriversWithoutIssues",
                new Parameter("maximalDateForLicense", DateTime.Now + licenseExpireWarning),
                new Parameter("maximalDateForRequalification", DateTime.Now + requalificationExpireWarning),
                new Parameter("maximalDateForMedExams", DateTime.Now + medicalExamExpireWarning)
                ).GetList<Driver>();
            drivers.ForEach(d => SetDriverDependencies(d));
            return drivers;
        }

        public List<Driver> GetDriversWithWarnings(TimeSpan licenseExpireWarning, TimeSpan requalificationExpireWarning, TimeSpan medicalExamExpireWarning)
        {
            var drivers = DatabaseConnector
                .ExecuteStoredProcedure
                (
                "GetDriversWithWarnings",
                new Parameter("maximalDateForLicense", DateTime.Now + licenseExpireWarning),
                new Parameter("maximalDateForRequalification", DateTime.Now + requalificationExpireWarning),
                new Parameter("maximalDateForMedExams", DateTime.Now + medicalExamExpireWarning)
                ).GetList<Driver>();
            drivers.ForEach(d => SetDriverDependencies(d));
            return drivers;
        }

        public List<Driver> GetDriverWithExpiredAttributes(TimeSpan licenseExpireWarning, TimeSpan requalificationExpireWarning, TimeSpan medicalExamExpireWarning)
        {
            var drivers = DatabaseConnector
                .ExecuteStoredProcedure
                (
                "GetDriversWithExpiredAttributes",
                new Parameter("maximalDateForLicense", DateTime.Now + licenseExpireWarning),
                new Parameter("maximalDateForRequalification", DateTime.Now + requalificationExpireWarning),
                new Parameter("maximalDateForMedExams", DateTime.Now + medicalExamExpireWarning)
                ).GetList<Driver>();
            drivers.ForEach(d => SetDriverDependencies(d));
            return drivers;
        }

        public bool DeactivateDriver(Driver driver)
        {
            try
            {
                driver.IsActive = false;
                driver.Archived = DateTime.Now;
                DatabaseConnector.UpdateDBObject(driver);
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }

        public bool UpdateDriverInfo(Driver driver)
        {
            try
            {
                DatabaseConnector.UpdateDBObject(driver);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool RemoveDriverLicense(DriverLicense driverLicense)
        {
            try
            {
                DatabaseConnector.DeleteDBObject(driverLicense);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool RemoveRequalification(Requalificaiton requalificaiton)
        {
            try
            {
                DatabaseConnector.DeleteDBObject(requalificaiton);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool RemoveMedicalExam(MedicalExam medicalExam)
        {

            try
            {
                DatabaseConnector.DeleteDBObject(medicalExam);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public List<Driver> GetDriversHistory()
        {
            List<Driver> drivers;
            try
            {
                drivers = DatabaseConnector.ExecuteStoredProcedure("GetInactiveDrivers").GetList<Driver>();
            }
            catch (Exception)
            {
                throw;
            }
            return drivers;
        }
    }
}