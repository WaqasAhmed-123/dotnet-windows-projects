using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp2.Model;

namespace WindowsFormsApp2
{
    public partial class LoginForm : Form
    {
        private DatabaseEntities _entity = new DatabaseEntities();
        private ErrorProvider errorProvider = new ErrorProvider();
        private Home home;
        public LoginForm()
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
                errorProvider.SetError(txtPassword, "Please Enter Your Email");
                return;
            }

            btnLogin.Enabled = false;
            User user = _entity.Users.FirstOrDefault(x => x.IsActive == 1 && x.Email.ToLower() == txtEmail.Text.Trim().ToLower() &&
            x.Password == txtPassword.Text.Trim());

            if(user == null)
            {
                MessageBox.Show("Invalid Credentials");
                btnLogin.Enabled = true;

                return;
            }

            user.IsLoggedIn = 1;
            _entity.Entry(user).State = System.Data.Entity.EntityState.Modified;
            _entity.SaveChanges();

            btnLogin.Enabled = true;
            
            home = new Home();
            this.Hide();
            home.Show();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            RegisterFrom addFrom = new RegisterFrom();
            addFrom.Show();
            Hide();
        }
    }
}
