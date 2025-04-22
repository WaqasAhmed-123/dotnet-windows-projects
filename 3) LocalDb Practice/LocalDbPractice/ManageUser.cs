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
    public partial class ManageUser : Form
    {
        private ErrorProvider _errorProvider = new ErrorProvider();
        private DatabaseEntities _entity = new DatabaseEntities();
        private string _way;
        public ManageUser(string way, int userId = -1)
        {
            _way = way;
            InitializeComponent();
            if(way == "adduser")
            {
                Text = "New User";
                groupBox1.Text = "Add User";
                btnSubmit.Text = "Add";
            }
            else if(way == "updateprofile")
            {
                User user = Program.loggedinUser;
                
                Text = "Profile";
                groupBox1.Text = "Update Profile";
                btnSubmit.Text = "Update";
                txtId.Text = user.Id.ToString();
                txtName.Text = user.Name;
                txtEmail.Text = user.Email;
                txtPassword.Text = user.Password;
            }
            else if(way == "updateuser")
            {
                User user = new UserBL().GetUserById(userId, _entity);

                Text = "Update";
                groupBox1.Text = "Update User";
                btnSubmit.Text = "Update";
                txtId.Text = user.Id.ToString();
                txtName.Text = user.Name;
                txtEmail.Text = user.Email;
                txtPassword.Text = user.Password;
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text))
            {
                txtName.Focus();
                _errorProvider.SetError(txtName, "Name is required.");
                return;
            }

            if (string.IsNullOrEmpty(txtEmail.Text))
            {
                txtEmail.Focus();
                _errorProvider.SetError(txtEmail, "Email is required.");
                return;
            }

            if (string.IsNullOrEmpty(txtPassword.Text))
            {
                txtPassword.Focus();
                _errorProvider.SetError(txtPassword, "Password is required.");
                return;
            }

            Loader loaderForm = new Loader();
            loaderForm.Show();
            loaderForm.loaderLabel.Text = "Processing..,";
            Application.DoEvents();

            if (_way == "adduser")
            {
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

                if (!new UserBL().AddUser(obj, _entity))
                {
                    MessageBox.Show("Database insertion failed, please try again.");
                    loaderForm.Close();
                    return;
                }

                MessageBox.Show("User inserted successfully.");
            }
            else
            {
                User user = new UserBL().GetUserById(Convert.ToInt32(txtId.Text), _entity);
                if (!new UserBL().ValidateUser(txtEmail.Text, user.Id, _entity))
                {
                    MessageBox.Show("Duplicate email, please try another.");
                    loaderForm.Close();

                    return;
                }

                user.Name = txtName.Text.Trim();
                user.Email = txtEmail.Text.Trim();
                user.Password = txtPassword.Text.Trim();

                if (!new UserBL().UpdateUser(user, _entity))
                {
                    MessageBox.Show("Database updation failed, please try again.");
                    loaderForm.Close();
                    return;
                }

                if (_way == "updateuser")
                {
                    MessageBox.Show("Record updated successfully.");
                }
                else
                {
                    Program.loggedinUser = user;
                    if(user.Role == 1)
                    {
                        AdminHome obj = new AdminHome();
                        obj.Show();
                    }
                    else
                    {
                        UserHome obj = new UserHome();
                        obj.Show();
                    }
                    MessageBox.Show("Profile updated successfully.");
                }
            }

            loaderForm.Close();
            Close();

        }
    }
}
