using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diagnostic_Center_Management_System
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            LoginForm newLogin = new LoginForm();
            newLogin.Show();
            Application.Run();   
          //  Application.Run(new AdminDashboard());
           // Application.Run(new ReceptionistDashboard());

        }
    }
}
