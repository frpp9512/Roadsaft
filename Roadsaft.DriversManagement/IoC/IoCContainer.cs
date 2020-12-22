using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Roadsaft.DriversManagement.Data;
using SmartB1t.Database;
using SmartB1t.DI;

namespace Roadsaft.DriversManagement
{
    static class IoCContainer
    {
        public static IContainer Container { get; private set; }

        public static void Configure()
        {
            Container = new DIContainer();
            Container.RegisterSinglenton(typeof(IDatabaseConnector),
                new MySQLConnector(
                    Configuration.DatabaseHostName,
                    Configuration.DatabaseUserName,
                    Configuration.DatabasePassword,
                    Configuration.DatabaseName));
            Container.Register<IDriversDataProvider, DriversDatabaseController>();
        }
    }
}
