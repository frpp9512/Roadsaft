using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roadsaft.DriversManagement.Data
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
        /// Gets the list of <see cref="Driver"/> stored in the system.
        /// </summary>
        /// <returns>The list of drivers.</returns>
        List<Driver> GetDrivers();

        /// <summary>
        /// Gets the list of <see cref="Driver"/> without any warning or expired attribute.
        /// </summary>
        /// <returns>A list of <see cref="Driver"/> without any warning or expired attribute.</returns>
        List<Driver> GetDriversWithoutIssues(TimeSpan licenseExpireWarning, TimeSpan requalificationExpireWarning, TimeSpan medicalExamExpireWarning);

        /// <summary>
        /// Gets the list of <see cref="Driver"/> with warnings on any attribute.
        /// </summary>
        /// <param name="licenseExpireWarning">Time period for determine license expiration warning.</param>
        /// <param name="requalificationExpireWarning">Time period for determine requalification expiration warning.</param>
        /// <param name="medicalExamExpireWarning">Time period for determine medical exam expiration warning.</param>
        /// <returns>A list of <see cref="Driver"/> with warnings on any attribute.</returns>
        List<Driver> GetDriversWithWarnings(TimeSpan licenseExpireWarning, TimeSpan requalificationExpireWarning, TimeSpan medicalExamExpireWarning);

        /// <summary>
        /// Gets the list of <see cref="Driver"/> with expired attributes.
        /// </summary>
        /// <param name="licenseExpireWarning">Time period for determine license expiration warning.</param>
        /// <param name="requalificationExpireWarning">Time period for determine requalification expiration warning.</param>
        /// <param name="medicalExamExpireWarning">Time period for determine medical exam expiration warning.</param>
        /// <returns>A list of <see cref="Driver"/> with expired attributes.</returns>
        List<Driver> GetDriverWithExpiredAttributes(TimeSpan licenseExpireWarning, TimeSpan requalificationExpireWarning, TimeSpan medicalExamExpireWarning);

        /// <summary>
        /// Gets the list of <see cref="Driver"/> that has been deactivated in the system.
        /// </summary>
        /// <returns>The list of deactivated drivers.</returns>
        List<Driver> GetDriversHistory();

        /// <summary>
        /// Get the history of all driver's licenses.
        /// </summary>
        /// <param name="driver">The driver to get license history.</param>
        /// <returns>List of driver's licenses history.</returns>
        List<DriverLicense> GetDriverLicenseHistory(Driver driver);

        /// <summary>
        /// Get the history of all requalifications made to the driver.
        /// </summary>
        /// <param name="driver">The driver to get requalification history.</param>
        /// <returns>List of driver's requalifications history.</returns>
        List<Requalificaiton> GetDriverRequalificationHistory(Driver driver);

        /// <summary>
        /// Get the history of all medical exams made to the driver.
        /// </summary>
        /// <param name="driver">The driver to get medical exams history.</param>
        /// <returns>List of driver's medical exams history.</returns>
        List<MedicalExam> GetDriverMedicalExamsHistory(Driver driver);

        /// <summary>
        /// Deativate the driver in the system.
        /// </summary>
        /// <param name="driver">The driver to deativate.</param>
        /// <returns><see langword="true"/> if the driver was deativated successfully.</returns>
        bool DeactivateDriver(Driver driver);

        /// <summary>
        /// Register a driver in the system.
        /// </summary>
        /// <param name="driver">The driver to register.</param>
        /// <returns>True if driver was registered successfully.</returns>
        bool AddNewDriver(Driver driver);

        /// <summary>
        /// Register a driver's license in the system.
        /// </summary>
        /// <param name="driver">The driver to register to the license.</param>
        /// <param name="license">The license to register.</param>
        /// <returns>True if driver's license was registered successfully.</returns>
        bool AddNewDriverLicense(Driver driver, DriverLicense license);

        /// <summary>
        /// Register a driver's requalification in the system.
        /// </summary>
        /// <param name="driver">The driver to register to the requalification.</param>
        /// <param name="requalificaiton">The recalification to register.</param>
        /// <returns>True if driver's requalification was registered successfully.</returns>
        bool AddNewRequalification(Driver driver, Requalificaiton requalificaiton);

        /// <summary>
        /// Register a driver's medical exam in the system.
        /// </summary>
        /// <param name="driver">The driver to register to the medical exam.</param>
        /// <param name="medicalExam">The medical exam to register.</param>
        /// <returns>True if driver's medical exam was registerd successfully.</returns>
        bool AddNewMedicalExam(Driver driver, MedicalExam medicalExam);

        /// <summary>
        /// Updates the info of the specified driver.
        /// </summary>
        /// <param name="driver">The driver with the modified properties.</param>
        /// <returns><see langword="true"/> if the driver was modified successfully.</returns>
        bool UpdateDriverInfo(Driver driver);

        /// <summary>
        /// Archives the medical exam in the system.
        /// </summary>
        /// <param name="driver">The medical exam's driver.</param>
        /// <param name="medicalExam">The medical exam to archive.</param>
        /// <returns>True if the medical exam was archived successfully.</returns>
        bool ArchiveMedicalExam(Driver driver, MedicalExam medicalExam);

        /// <summary>
        /// Renew the current driver's license, deactivating the current one and setting like active the new.
        /// </summary>
        /// <param name="driver">The driver to update driver's license.</param>
        /// <param name="newLicense">The new driver's license.</param>
        /// <returns>True if the process finish successfully.</returns>
        bool RenewalLicense(Driver driver, DriverLicense newLicense);

        /// <summary>
        /// Renew the current driver's requalification, deactivating the current one and setting like active the new.
        /// </summary>
        /// <param name="driver">The driver to update requalificaiton.</param>
        /// <param name="requalificaiton">The new driver's requalification</param>
        /// <returns>True if the process finish successfully.</returns>
        bool RenewalRequalification(Driver driver, Requalificaiton requalificaiton);

        /// <summary>
        /// Removes the speciefied driver license from the system.
        /// </summary>
        /// <param name="driverLicense">The driver license to remove.</param>
        /// <returns><see langword="true"/> if the license was removed successfully.</returns>
        bool RemoveDriverLicense(DriverLicense driverLicense);

        /// <summary>
        /// Removes the specified requalification from the system.
        /// </summary>
        /// <param name="requalificaiton">The requalification to remove.</param>
        /// <returns><see langword="true"/> if the requalification was removed successfully.</returns>
        bool RemoveRequalification(Requalificaiton requalificaiton);

        /// <summary>
        /// Removes the specified medical exam from the system.
        /// </summary>
        /// <param name="medicalExam">The medical exam to remove.</param>
        /// <returns><see langword="true"/> if the medical exam was successfully removed.</returns>
        bool RemoveMedicalExam(MedicalExam medicalExam);
    }
}
