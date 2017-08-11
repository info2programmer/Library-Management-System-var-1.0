using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Microsoft.Win32;

namespace LibreryManagmentSystem
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
            RegistryKey key = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\info2programmer");
            if (key != null)
            {
                Application.Run(new Authentication.frmLogin());
            }
            else
            {
                Application.Run(new LibraryManagmentPRO.frmLicence());
            }
            
        }
    }
}
