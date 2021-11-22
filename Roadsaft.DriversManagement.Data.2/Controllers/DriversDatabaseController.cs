using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Roadsaft.DriversManagement.Data.DataContext;

namespace Roadsaft.DriversManagement.Data
{
    /// <summary>
    /// A controller for the drivers data stored in a MySQL/MariaDB database.
    /// </summary>
    public class DriversDatabaseController : IDriversDataProvider
    {
        private readonly RoadsaftDbContext _dataContext;

        public DriversDatabaseController(RoadsaftDbContext dataContext)
        {
            _dataContext = dataContext;
            _dataContext.Database.EnsureCreated();
        }

        public async Task<List<DriverLicense>> GetDriverLicenseHistoryAsync(Driver driver)
        {
            var lics = await _dataContext.DriverLicenses.Where(d => !d.IsActive).OrderByDescending(d => d.Created).ToListAsync();
            lics.ForEach(l => l.Driver = driver);
            return lics;
        }

        public async Task<List<Driver>> GetDriversAsync()
        {
            var drivers = await _dataContext.Drivers.Where(d => d.IsActive).ToListAsync();
            drivers.ForEach(async d => await SetDriverDependenciesAsync(d));
            return drivers;
        }

        /// <summary>
        /// Loads the DriverLicense, Requalification and MedicalExam list for the specified driver.
        /// </summary>
        /// <param name="driver">The driver to be updated.</param>
        private async Task SetDriverDependenciesAsync(Driver driver)
        {
            var license = await _dataContext.DriverLicenses
                                            .Where(l => l.IsActive).ToListAsync();
            var requalification = await _dataContext.Requalificaitons
                                                    .Where(r => r.IsActive)
                                                    .ToListAsync();
            var medexams = await _dataContext.MedicalExams.Where(m => m.IsActive).ToListAsync();

            driver.DriverLicenses = license;
            driver.Requalificaitons = requalification;
            driver.MedicalExams = medexams;
        }

        public async Task<List<Requalificaiton>> GetDriverRequalificationHistoryAsync(Driver driver)
        {
            var reqs = await _dataContext.Requalificaitons
                                         .Where(r => !r.IsActive)
                                         .OrderByDescending(r => r.DateOfMaking)
                                         .ToListAsync();
            reqs.ForEach(r => r.Driver = driver);
            return reqs;
        }

        public async Task<List<MedicalExam>> GetDriverMedicalExamsHistoryAsync(Driver driver)
        {
            var medexams = await _dataContext.MedicalExams
                                             .Where(m => !m.IsActive)
                                             .OrderByDescending(m => m.DateOfMaking)
                                             .ToListAsync();
            medexams.ForEach(m => m.Driver = driver);
            return medexams;
        }

        public async Task<bool> AddNewDriverAsync(Driver driver)
        {
            try
            {
                driver.Registered = DateTime.Now;
                await _dataContext.Drivers.AddAsync(driver);
                _dataContext.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public async Task<bool> RenewalLicenseAsync(Driver driver, DriverLicense newLicense)
        {
            try
            {
                if (driver.ActiveDriverLicense != null)
                {
                    driver.ActiveDriverLicense.IsActive = false;
                    driver.ActiveDriverLicense.Archived = DateTime.Now;
                    _dataContext.Update(driver.ActiveDriverLicense);
                }
                newLicense.IsActive = true;
                if (!await AddNewDriverLicenseAsync(driver, newLicense))
                {
                    throw new Exception("Error adding new driver's license.");
                }
                driver.DriverLicenses = new List<DriverLicense> { newLicense };
                _dataContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<bool> RenewalRequalificationAsync(Driver driver, Requalificaiton requalificaiton)
        {
            try
            {
                if (driver.ActiveRequalificaiton != null)
                {
                    driver.ActiveRequalificaiton.IsActive = false;
                    driver.ActiveRequalificaiton.Archived = DateTime.Now;
                    _dataContext.Update(driver.ActiveRequalificaiton);
                }
                requalificaiton.IsActive = true;
                if (!await AddNewRequalificationAsync(driver, requalificaiton))
                {
                    throw new Exception("Error adding new driver's requalification.");
                }
                driver.Requalificaitons = new List<Requalificaiton> { requalificaiton };
                _dataContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<bool> AddNewDriverLicenseAsync(Driver driver, DriverLicense license)
        {
            try
            {
                license.Driver = driver;
                await _dataContext.DriverLicenses.AddAsync(license);
                _dataContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<bool> AddNewRequalificationAsync(Driver driver, Requalificaiton requalification)
        {
            try
            {
                requalification.Driver = driver;
                await _dataContext.Requalificaitons.AddAsync(requalification);
                _dataContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<bool> AddNewMedicalExamAsync(Driver driver, MedicalExam medicalExam)
        {
            try
            {
                medicalExam.Driver = driver;
                await _dataContext.MedicalExams.AddAsync(medicalExam);
                _dataContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<bool> ArchiveMedicalExamAsync(Driver driver, MedicalExam medicalExam)
        {
            try
            {
                medicalExam.IsActive = false;
                medicalExam.Archived = DateTime.Now;
                _ = driver.ActiveMedicalExams.Remove(medicalExam);
                _dataContext.Update(medicalExam);
                _dataContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<List<Driver>> GetDriversWithoutIssuesAsync(TimeSpan licenseExpireWarning, 
                                                                     TimeSpan requalificationExpireWarning,
                                                                     TimeSpan medicalExamExpireWarning)
        {
            var drivers = await _dataContext.Drivers.Where(d => !d.HasExpiredLicense
                                                           && !d.HasExpiredRequalification
                                                           && !d.HasExpiredMedicalExam
                                                           && !(d.HasActiveLicense && DateTime.Now + licenseExpireWarning > d.ActiveDriverLicense.Expires)
                                                           && !(d.HasActiveRequalification && DateTime.Now + requalificationExpireWarning > d.ActiveRequalificaiton.Expires)
                                                           && !(d.HasMedicalExams && d.MedicalExams.Any(m => DateTime.Now + medicalExamExpireWarning > m.Expires)))
                                                     .ToListAsync();
            drivers.ForEach(async d => await SetDriverDependenciesAsync(d));
            return drivers;
        }

        public async Task<List<Driver>> GetDriversWithWarningsAsync(TimeSpan licenseExpireWarning,
                                                                    TimeSpan requalificationExpireWarning,
                                                                    TimeSpan medicalExamExpireWarning)
        {
            var drivers = await _dataContext.Drivers.Where(d => (d.HasActiveLicense && DateTime.Now + licenseExpireWarning > d.ActiveDriverLicense.Expires)
                                                           || (d.HasActiveRequalification && DateTime.Now + requalificationExpireWarning > d.ActiveRequalificaiton.Expires)
                                                           || (d.HasMedicalExams && d.MedicalExams.Any(m => DateTime.Now + medicalExamExpireWarning > m.Expires)))
                                                     .ToListAsync();
            drivers.ForEach(async d => await SetDriverDependenciesAsync(d));
            return drivers;
        }

        public async Task<List<Driver>> GetDriverWithExpiredAttributesAsync(TimeSpan licenseExpireWarning, TimeSpan requalificationExpireWarning, TimeSpan medicalExamExpireWarning)
        {
            var drivers = await _dataContext.Drivers.Where(d => d.HasExpiredLicense
                                                           || d.HasExpiredRequalification
                                                           || d.HasExpiredMedicalExam)
                                                     .ToListAsync();
            drivers.ForEach(async d => await SetDriverDependenciesAsync(d));
            return drivers;
        }

        public async Task<bool> DeactivateDriverAsync(Driver driver)
        {
            try
            {
                driver.IsActive = false;
                driver.Archived = DateTime.Now;
                _dataContext.Update(driver);
                _dataContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }

        public async Task<bool> UpdateDriverInfoAsync(Driver driver)
        {
            try
            {
                _dataContext.Update(driver);
                _dataContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<bool> RemoveDriverLicenseAsync(DriverLicense driverLicense)
        {
            try
            {
                _dataContext.Remove(driverLicense);
                _dataContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<bool> RemoveRequalificationAsync(Requalificaiton requalificaiton)
        {
            try
            {
                _dataContext.Remove(requalificaiton);
                _dataContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<bool> RemoveMedicalExamAsync(MedicalExam medicalExam)
        {
            try
            {
                _dataContext.Remove(medicalExam);
                _dataContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<List<Driver>> GetDriversHistoryAsync()
        {
            List<Driver> drivers;
            try
            {
                drivers = await _dataContext.Drivers.Where(d => !d.IsActive).ToListAsync();
            }
            catch (Exception)
            {
                throw;
            }
            return drivers;
        }
    }
}