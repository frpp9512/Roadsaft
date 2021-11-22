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
        /// Gets the list of <see cref="Driver"/> stored in the system.
        /// </summary>
        /// <returns>The list of drivers.</returns>
        Task<List<Driver>> GetDriversAsync();

        /// <summary>
        /// Gets the list of <see cref="Driver"/> without any warning or expired attribute.
        /// </summary>
        /// <returns>A list of <see cref="Driver"/> without any warning or expired attribute.</returns>
        Task<List<Driver>> GetDriversWithoutIssuesAsync(TimeSpan licenseExpireWarning, TimeSpan requalificationExpireWarning, TimeSpan medicalExamExpireWarning);

        /// <summary>
        /// Gets the list of <see cref="Driver"/> with warnings on any attribute.
        /// </summary>
        /// <param name="licenseExpireWarning">Time period for determine license expiration warning.</param>
        /// <param name="requalificationExpireWarning">Time period for determine requalification expiration warning.</param>
        /// <param name="medicalExamExpireWarning">Time period for determine medical exam expiration warning.</param>
        /// <returns>A list of <see cref="Driver"/> with warnings on any attribute.</returns>
        Task<List<Driver>> GetDriversWithWarningsAsync(TimeSpan licenseExpireWarning, TimeSpan requalificationExpireWarning, TimeSpan medicalExamExpireWarning);

        /// <summary>
        /// Gets the list of <see cref="Driver"/> with expired attributes.
        /// </summary>
        /// <param name="licenseExpireWarning">Time period for determine license expiration warning.</param>
        /// <param name="requalificationExpireWarning">Time period for determine requalification expiration warning.</param>
        /// <param name="medicalExamExpireWarning">Time period for determine medical exam expiration warning.</param>
        /// <returns>A list of <see cref="Driver"/> with expired attributes.</returns>
        Task<List<Driver>> GetDriverWithExpiredAttributesAsync(TimeSpan licenseExpireWarning, TimeSpan requalificationExpireWarning, TimeSpan medicalExamExpireWarning);

        /// <summary>
        /// Gets the list of <see cref="Driver"/> that has been deactivated in the system.
        /// </summary>
        /// <returns>The list of deactivated drivers.</returns>
        Task<List<Driver>> GetDriversHistoryAsync();

        /// <summary>
        /// Get the history of all driver's licenses.
        /// </summary>
        /// <param name="driver">The driver to get license history.</param>
        /// <returns>List of driver's licenses history.</returns>
        Task<List<DriverLicense>> GetDriverLicenseHistoryAsync(Driver driver);

        /// <summary>
        /// Get the history of all requalifications made to the driver.
        /// </summary>
        /// <param name="driver">The driver to get requalification history.</param>
        /// <returns>List of driver's requalifications history.</returns>
        Task<List<Requalificaiton>> GetDriverRequalificationHistoryAsync(Driver driver);

        /// <summary>
        /// Get the history of all medical exams made to the driver.
        /// </summary>
        /// <param name="driver">The driver to get medical exams history.</param>
        /// <returns>List of driver's medical exams history.</returns>
        Task<List<MedicalExam>> GetDriverMedicalExamsHistoryAsync(Driver driver);

        /// <summary>
        /// Deativate the driver in the system.
        /// </summary>
        /// <param name="driver">The driver to deativate.</param>
        /// <returns><see langword="true"/> if the driver was deativated successfully.</returns>
        Task<bool> DeactivateDriverAsync(Driver driver);

        /// <summary>
        /// Register a driver in the system.
        /// </summary>
        /// <param name="driver">The driver to register.</param>
        /// <returns>True if driver was registered successfully.</returns>
        Task<bool> AddNewDriverAsync(Driver driver);

        /// <summary>
        /// Register a driver's license in the system.
        /// </summary>
        /// <param name="driver">The driver to register to the license.</param>
        /// <param name="license">The license to register.</param>
        /// <returns>True if driver's license was registered successfully.</returns>
        Task<bool> AddNewDriverLicenseAsync(Driver driver, DriverLicense license);

        /// <summary>
        /// Register a driver's requalification in the system.
        /// </summary>
        /// <param name="driver">The driver to register to the requalification.</param>
        /// <param name="requalificaiton">The recalification to register.</param>
        /// <returns>True if driver's requalification was registered successfully.</returns>
        Task<bool> AddNewRequalificationAsync(Driver driver, Requalificaiton requalificaiton);

        /// <summary>
        /// Register a driver's medical exam in the system.
        /// </summary>
        /// <param name="driver">The driver to register to the medical exam.</param>
        /// <param name="medicalExam">The medical exam to register.</param>
        /// <returns>True if driver's medical exam was registerd successfully.</returns>
        Task<bool> AddNewMedicalExamAsync(Driver driver, MedicalExam medicalExam);

        /// <summary>
        /// Updates the info of the specified driver.
        /// </summary>
        /// <param name="driver">The driver with the modified properties.</param>
        /// <returns><see langword="true"/> if the driver was modified successfully.</returns>
        Task<bool> UpdateDriverInfoAsync(Driver driver);

        /// <summary>
        /// Archives the medical exam in the system.
        /// </summary>
        /// <param name="driver">The medical exam's driver.</param>
        /// <param name="medicalExam">The medical exam to archive.</param>
        /// <returns>True if the medical exam was archived successfully.</returns>
        Task<bool> ArchiveMedicalExamAsync(Driver driver, MedicalExam medicalExam);

        /// <summary>
        /// Renew the current driver's license, deactivating the current one and setting like active the new.
        /// </summary>
        /// <param name="driver">The driver to update driver's license.</param>
        /// <param name="newLicense">The new driver's license.</param>
        /// <returns>True if the process finish successfully.</returns>
        Task<bool> RenewalLicenseAsync(Driver driver, DriverLicense newLicense);

        /// <summary>
        /// Renew the current driver's requalification, deactivating the current one and setting like active the new.
        /// </summary>
        /// <param name="driver">The driver to update requalificaiton.</param>
        /// <param name="requalificaiton">The new driver's requalification</param>
        /// <returns>True if the process finish successfully.</returns>
        Task<bool> RenewalRequalificationAsync(Driver driver, Requalificaiton requalificaiton);

        /// <summary>
        /// Removes the speciefied driver license from the system.
        /// </summary>
        /// <param name="driverLicense">The driver license to remove.</param>
        /// <returns><see langword="true"/> if the license was removed successfully.</returns>
        Task<bool> RemoveDriverLicenseAsync(DriverLicense driverLicense);

        /// <summary>
        /// Removes the specified requalification from the system.
        /// </summary>
        /// <param name="requalificaiton">The requalification to remove.</param>
        /// <returns><see langword="true"/> if the requalification was removed successfully.</returns>
        Task<bool> RemoveRequalificationAsync(Requalificaiton requalificaiton);

        /// <summary>
        /// Removes the specified medical exam from the system.
        /// </summary>
        /// <param name="medicalExam">The medical exam to remove.</param>
        /// <returns><see langword="true"/> if the medical exam was successfully removed.</returns>
        Task<bool> RemoveMedicalExamAsync(MedicalExam medicalExam);
    }
}
