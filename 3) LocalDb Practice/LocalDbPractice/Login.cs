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
    public partial class Login : Form
    {
        private ErrorProvider errorProvider = new ErrorProvider();
        private DatabaseEntities _entity = new DatabaseEntities();

        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtEmail.Text))
            {
                txtEmail.Focus();
                errorProvider.SetError(txtEmail, "Please Enter Your Email");
                return;
            }

            if (string.IsNullOrEmpty(txtPassword.Text))
            {
                txtPassword.Focus();
                errorProvider.SetError(txtPassword, "Please Enter Your Password");
                return;
            }

            btnLogin.Enabled = false;
            User user = new UserBL().GetUserByLogin(txtEmail.Text, txtPassword.Text, _entity);

            if (user == null)
            {
                MessageBox.Show("Invalid Email/Password");
                btnLogin.Enabled = true;

                return;
            }

            Program.loggedinUser = user;

            if (remember.Checked)
            {
                user.IsLoggedin = 1;
                new UserBL().UpdateUser(user, _entity);
            }

            btnLogin.Enabled = true;

            if(user.Role == 1)
            {
                AdminHome home = new AdminHome();
                home.Show();
            }
            else
            {
                UserHome home = new UserHome();
                home.Show();
            }
            Hide();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Signup signup = new Signup();
            signup.Show();
            Hide();
        }

        private void forgotLink_Click(object sender, EventArgs e)
        {
            ForgotPassword forgot = new ForgotPassword();
            forgot.Show();
            Hide();
        }
    }
}
