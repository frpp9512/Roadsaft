using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roadsaft.DriversManagement.Data.DataContext
{
    public abstract class RoadsaftDbContext : DbContext
    {
        public DbSet<Driver> Drivers { get; set; }
        public DbSet<DriverLicense> DriverLicenses { get; set; }
        public DbSet<Requalificaiton> Requalificaitons { get; set; }
        public DbSet<MedicalExam> MedicalExams { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Driver>()
                        .HasMany(x => x.DriverLicenses)
                        .WithOne(y => y.Driver)
                        .HasForeignKey(y => y.DriverId)
                        .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Driver>()
                        .HasMany(x => x.Requalificaitons)
                        .WithOne(y => y.Driver)
                        .HasForeignKey(y => y.DriverId)
                        .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Driver>()
                        .HasMany(x => x.MedicalExams)
                        .WithOne(y => y.Driver)
                        .HasForeignKey(y => y.DriverId)
                        .OnDelete(DeleteBehavior.Cascade);

            base.OnModelCreating(modelBuilder);
        }
    }
}
