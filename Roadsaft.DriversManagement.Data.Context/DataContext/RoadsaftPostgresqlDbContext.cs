using Microsoft.EntityFrameworkCore;
using Roadsaft.DriversManagement.Data.DataContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roadsaft.DriversManagement.Data.Posgresql
{
    public class RoadsaftPostgresqlDbContext : RoadsaftDbContext
    {
        private readonly string _connectionString;

        public RoadsaftPostgresqlDbContext(string connectionString) => _connectionString = connectionString;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(_connectionString);

            base.OnConfiguring(optionsBuilder);
        }
    }
}
