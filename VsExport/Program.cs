using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VsExport
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            NameValueCollection sAll;
            sAll = ConfigurationManager.AppSettings;
            foreach (string s in sAll.AllKeys)
                System.Diagnostics.Debug.WriteLine("Key: " + s + " Value: " + sAll.Get(s));

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            FrmLogin frmlogin = new FrmLogin();

            frmlogin.Server = ConfigurationManager.AppSettings.Get("Server");
            frmlogin.Database = ConfigurationManager.AppSettings.Get("Database");
            frmlogin.Login = ConfigurationManager.AppSettings.Get("Login");
            frmlogin.Password = ConfigurationManager.AppSettings.Get("Password");

            Application.Run(frmlogin);
            if (frmlogin.LoginSuccess)
            {
                Application.Run(new FrmMain());
            }

            
        }
    }
}
