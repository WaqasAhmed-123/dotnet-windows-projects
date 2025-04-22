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
    public partial class AddUserForm : Form
    {
        private DatabaseEntities _entity = new DatabaseEntities();
        private User user;
        private int way;

        public AddUserForm(User _user, int _way)
        {
            way = _way;
            user = _user;
            InitializeComponent();
            if(way == 2 || way == 5)
            {
                groupBoxUser.Text = "Update " + user.Name;
                Text = way == 2 ? "Update User" : "Update Profile";
                SetData();
            }
            else
            {
                groupBoxUser.Text = "Add User";
                Text = "New User";
            }
        }

        private void SetData()
        {
            inpId.Text = user.Id.ToString();
            inpName.Text = user.Name;
            inpContact.Text = user.Contact;
            inpEmail.Text = user.Email;
            inpAddress.Text = user.Address;
            inpPassword.Visible = false;
            labelPassword.Visible = false;
            inpRole.SelectedIndex = (int)user.Role-1;
            if(user.Gender == "Male")
            {
                inpMale.Select();
            }
            else
            {
                inpFemale.Select();
            }

            btnSubmit.Text = "Update";
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            errorMsg.Text = "";
            if (string.IsNullOrEmpty(inpName.Text) || string.IsNullOrEmpty(inpContact.Text) || string.IsNullOrEmpty(inpEmail.Text) || string.IsNullOrEmpty(inpAddress.Text) || string.IsNullOrEmpty(inpRole.Text))
            {
                errorMsg.Text = "All fields are required.";
                return;
            }

            if (way == 2 || way == 5)
            {
                int id = Convert.ToInt32(inpId.Text);
                User u = _entity.Users.FirstOrDefault(x => x.IsActive == 1 && x.Id == id);

                u.Name = inpName.Text.Trim();
                u.Contact = inpContact.Text.Trim();
                u.Email = inpEmail.Text.Trim();
                u.Address = inpAddress.Text.Trim();
                u.Gender = "Male";
                u.Role = 3;

                if (inpFemale.Checked)
                {
                    u.Gender = "Female";
                }

                if (inpRole.Text == "Admin")
                {
                    u.Role = 1;
                }
                else if (inpRole.Text == "Manager")
                {
                    u.Role = 2;
                }

                _entity.Entry(u).State = System.Data.Entity.EntityState.Modified;
                _entity.SaveChanges();

                MessageBox.Show("Record updated successfully.");
                if (way == 5)
                {
                    Home home = new Home();
                    home.Show();
                }
                else
                {
                    ViewUserForm viewUserForm = new ViewUserForm();
                    viewUserForm.Show();
                }
            }
            else
            {
                User obj = new User()
                {
                    Name = inpName.Text.Trim(),
                    Contact = inpContact.Text.Trim(),
                    Email = inpEmail.Text.Trim(),
                    Address = inpAddress.Text.Trim(),
                    Password = inpPassword.Text.Trim(),
                    Gender = "Male",
                    Role = 3,
                    Terms = 1,
                    IsActive = 1,
                    CreatedAt = DateTime.Now
                };

                if (inpFemale.Checked)
                {
                    obj.Gender = "Female";
                }

                if (inpRole.Text == "Admin")
                {
                    obj.Role = 1;
                }
                else if (inpRole.Text == "Manager")
                {
                    obj.Role = 2;
                }

                _entity.Users.Add(obj);
                _entity.SaveChanges();

                MessageBox.Show("User inserted successfully.");
                if(way == 2)
                {
                    Home home = new Home();
                    home.Show();
                }
                else
                {
                    ViewUserForm viewForm = new ViewUserForm();
                    viewForm.Show();
                }
            }
            
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (way == 1 || way == 5)
            {
                Home home = new Home();
                home.Show();
                Close();
            }
            else
            {
                ViewUserForm viewUserForm = new ViewUserForm();
                viewUserForm.Show();
                Close();
            }
        }

    }
}
