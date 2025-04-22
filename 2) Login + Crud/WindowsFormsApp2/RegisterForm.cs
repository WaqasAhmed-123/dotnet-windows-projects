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
    public partial class RegisterFrom : Form
    {
        private DatabaseEntities _entity = new DatabaseEntities();

        public RegisterFrom()
        {
            InitializeComponent();
            inpMale.Checked = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void buttonSub_Click(object sender, EventArgs e)
        {
            errorMsg.Text = "";
            if (string.IsNullOrEmpty(inpName.Text) || string.IsNullOrEmpty(inpContact.Text) || string.IsNullOrEmpty(inpEmail.Text) || string.IsNullOrEmpty(inpAddress.Text) || string.IsNullOrEmpty(inpPassword.Text) || string.IsNullOrEmpty(inpTerm.Text) || string.IsNullOrEmpty(inpRole.Text))
            {
                errorMsg.Text = "All fields are required.";
                return;
            }
            User obj = new User()
            {
                Name = inpName.Text.Trim(),
                Contact = inpContact.Text.Trim(),
                Email = inpEmail.Text.Trim(),
                Address = inpAddress.Text.Trim(),
                Password = inpPassword.Text.Trim(),
                Gender = "Male",
                Role = 3,
                Terms = 0,
                IsActive = 1,
                CreatedAt = DateTime.Now
            };

            if(inpFemale.Checked)
            {
                obj.Gender = "Female";
            }

            if(inpRole.Text == "Admin")
            {
                obj.Role = 1;
            }
            else if(inpRole.Text == "Manager")
            {
                obj.Role = 2;
            }

            if(inpTerm.Checked)
            {
                obj.Terms = 1;
            }

            _entity.Users.Add(obj);
            _entity.SaveChanges();

            MessageBox.Show("Singup successful, try login.");
            this.Close();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }

        private void linkLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            Hide();
        }
    }
}
