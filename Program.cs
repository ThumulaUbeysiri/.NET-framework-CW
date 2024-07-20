using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeManagement
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
            Application.Run(new AdminLogin());
            //Application.Run(new AdminMainMenue());
            //Application.Run(new Dashboard());
            //Application.Run(new AddEmployee());
            //Application.Run(new SetSalary());
            //Application.Run(new SetTasks());
            //Application.Run(new ViewProfiles());
            //Application.Run(new Department());

        }
    }
}
