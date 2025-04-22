using LocalDbPractice.BL;
using LocalDbPractice.HelpingClasses;
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
    public partial class ForgotPassword : Form
    {
        private ErrorProvider errorProvider = new ErrorProvider();
        private DatabaseEntities _entity = new DatabaseEntities();

        public ForgotPassword()
        {
            InitializeComponent();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtEmail.Text))
            {
                txtEmail.Focus();
                errorProvider.SetError(txtEmail, "Please Enter Your Email");
                return;
            }

            Loader loaderForm = new Loader();
            loaderForm.Show();
            loaderForm.loaderLabel.Text = "Sending..,";
            Application.DoEvents();

            btnSend.Enabled = false;

            User user = new UserBL().GetUserByEmail(txtEmail.Text, _entity);
            
            if(user != null)
            {
                MailSender.SendEmail(user.Email, user.Password);
                Login login = new Login();
                login.Show();
                Close();
                
                MessageBox.Show("Please check at " + user.Email);
            }
            else
            {
                MessageBox.Show("Email does not belongs to our record.");
            }

            btnSend.Enabled = true;
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
