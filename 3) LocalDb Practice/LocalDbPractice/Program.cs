using LocalDbPractice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LocalDbPractice
{
    //to add local database , go to add new item and select "Service-based Database"
    //than add "Ado.Net Entitiy Data Model"
    //Can get help from given link
    //https://www.youtube.com/watch?v=nOc1F5HHCIc


    //in case of local database you need to use sql server db for project debugging
    //and after that you can use local db for published project
    //connection string is placed in App.config file


    //How to publish
    //right click on project and go to "Properties"
    //select the "Publish" tab from left side bar and select target folder to publish
    //you can also set the "Options..." for published project

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
            loggedinUser = _entity.Users.FirstOrDefault(x => x.IsActive == 1 && x.IsLoggedin == 1);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
           
            if (loggedinUser != null)
            {
                if(loggedinUser.Role == 1)
                    Application.Run(new AdminHome());
                else
                    Application.Run(new UserHome());
            }
            else
            {
                Application.Run(new Login());
            }

        }
    }
}
