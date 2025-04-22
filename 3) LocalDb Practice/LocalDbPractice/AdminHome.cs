using LocalDbPractice.BL;
using LocalDbPractice.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LocalDbPractice
{
    public partial class AdminHome : Form
    {
        private DatabaseEntities _entity = new DatabaseEntities();

        public AdminHome()
        {
            InitializeComponent();
            profileLink.Text = Program.loggedinUser.Name;
        }

        private void addUserLink_Click(object sender, EventArgs e)
        {
            ManageUser obj = new ManageUser("adduser");
            obj.Show();
        }

        private void viewUserLink_Click(object sender, EventArgs e)
        {
            ViewUser obj = new ViewUser();
            obj.Show();
        }

        private void expensesLink_Click(object sender, EventArgs e)
        {
            ViewExpense obj = new ViewExpense();
            obj.Show();
        }

        private void updateProfileLink_Click(object sender, EventArgs e)
        {
            Hide();
            ManageUser obj = new ManageUser("updateprofile");
            obj.Show();
        }

        private void logoutLink_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            Hide();
            if (Program.loggedinUser.IsLoggedin == 1)
            {
                User obj = new UserBL().GetUserById(Program.loggedinUser.Id, _entity);
                obj.IsLoggedin = 0;

                new UserBL().UpdateUser(obj, _entity);
            }

            Close();
        }

    }
}
