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
    public partial class Signup : Form
    {
        private ErrorProvider errorProvider = new ErrorProvider();
        private DatabaseEntities _entity = new DatabaseEntities();

        public Signup()
        {
            InitializeComponent();
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text))
            {
                txtName.Focus();
                errorProvider.SetError(txtName, "Please Enter Your Name");
                return;
            }

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

            Loader loaderForm = new Loader();
            loaderForm.Show();
            loaderForm.loaderLabel.Text = "Processing..,";
            Application.DoEvents();

            if (!new UserBL().ValidateUser(txtEmail.Text, -1, _entity))
            {
                MessageBox.Show("Duplicate email, please try another.");
                loaderForm.Close();

                return;
            }

            User obj = new User()
            {
                Name = txtName.Text.Trim(),
                Email = txtEmail.Text.Trim(),
                Password = txtPassword.Text.Trim(),
                Role = 2,
                IsActive = 1,
                CreatedAt = DateTime.Now
            };

            if(!new UserBL().AddUser(obj, _entity))
            {
                MessageBox.Show("Singup failed, please try again.");
                loaderForm.Close();
                return;
            }
             
            MessageBox.Show("Singup successful, try login.");
            Close();
            Login login= new Login();
            login.Show();

            loaderForm.Close();
        }

        private void loginLink_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            Close();
        }
    }
}
