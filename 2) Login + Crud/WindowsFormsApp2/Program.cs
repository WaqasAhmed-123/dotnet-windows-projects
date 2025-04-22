using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp2.Model;

namespace WindowsFormsApp2
{
    internal static class Program
    {
        public static User loggedinUser;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            DatabaseEntities _entity = new DatabaseEntities();
            loggedinUser = _entity.Users.FirstOrDefault(x => x.IsActive == 1 && x.IsLoggedIn == 1);
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (loggedinUser != null)
            {
                Application.Run(new Home());
            }
            else
            {
                Application.Run(new LoginForm());
            }
        }
    }
}
