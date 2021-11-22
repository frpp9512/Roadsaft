using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace Roadsaft.DriversManagement.Data.Posgresql.Helpers
{
    public static class ConnectionHelper
    {
        public static string BuildConnectionString(string host, string username, string password, string database)
        {
            var builder = new NpgsqlConnectionStringBuilder
            {
                Host = host,
                Username = username,
                Password = password,
                Database = database
            };
            return builder.ConnectionString;
        }
    }
}