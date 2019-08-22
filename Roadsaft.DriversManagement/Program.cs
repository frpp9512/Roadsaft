using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Roadsaft.DriversManagement
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if(LoadSettingsFromConfiguration())
            {
                IoCContainer.Configure();
                Application.Run(new FrmDriversMainForm());
            }
        }

        private static bool LoadSettingsFromConfiguration()
        {
            if (Configuration.ExistConfigurationFile())
            {
                Configuration.LoadFromFile();
                return true;
            }
            else
            {
                var frmwelcome = new FrmWelcomeScreen();
                if (frmwelcome.ShowDialog() == DialogResult.Cancel)
                {
                    return false;
                }
                else
                {
                    while (!Configuration.ExistConfigurationFile())
                    {
                        var frm = new FrmConfiguration();
                        _ = frm.ShowDialog();
                    }
                    return LoadSettingsFromConfiguration();
                }
            }
        }
    }
}
