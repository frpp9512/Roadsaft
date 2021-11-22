using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Roadsaft.DriversManagement.Data;
using Roadsaft.DriversManagement.Data.DataContext;
using Roadsaft.DriversManagement.Data.Posgresql;
using Roadsaft.DriversManagement.Data.Posgresql.Helpers;
using SmartB1t.DI;

namespace Roadsaft.DriversManagement
{
    static class IoCContainer
    {
        public static IContainer Container { get; private set; }

        public static void Configure()
        {
            Container = new DIContainer();
            Container.RegisterSinglenton(typeof(RoadsaftDbContext),
                                         new RoadsaftPostgresqlDbContext(
                                             ConnectionHelper.BuildConnectionString(Configuration.DatabaseHostName,
                                                                                    Configuration.DatabaseUserName,
                                                                                    Configuration.DatabasePassword,
                                                                                    Configuration.DatabaseName)));
            Container.RegisterSingleton<IDriversDataProvider, DriversDatabaseController>();
        }
    }
}
