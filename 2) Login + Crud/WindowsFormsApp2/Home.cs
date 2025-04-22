using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp2.Model;

namespace WindowsFormsApp2
{
    public partial class Home : Form
    {
        private DatabaseEntities _entity = new DatabaseEntities();
        private User loggedinUser = Program.loggedinUser;

        public Home()
        {
            InitializeComponent();
            userName.Text = loggedinUser.Name;

            userCount.Text = _entity.Users.Count(x => x.IsActive == 1).ToString();
            //userCount.Left = (panel1.Width - userCount.Width) / 2; //aligning text center
        }

        private void menuAddUser_Click(object sender, EventArgs e)
        {
            AddUserForm addUserForm = new AddUserForm(null, 1);
            addUserForm.Show();
            this.Hide();
        }

        private void menuViewUser_Click(object sender, EventArgs e)
        {
            ViewUserForm viewUserForm = new ViewUserForm();
            viewUserForm.Show();
            this.Hide();
        }

        private void menuUpdProfile_Click(object sender, EventArgs e)
        {
            AddUserForm addUserForm = new AddUserForm(loggedinUser, 5);
            addUserForm.Show();
            this.Hide();
        }

        private void menuUpdPassword_Click(object sender, EventArgs e)
        {
            TestForm testForm = new TestForm();
            testForm.Show();
        }

        private void menuLogout_Click(object sender, EventArgs e)
        {
            loggedinUser.IsLoggedIn = 0;
            _entity.Entry(loggedinUser).State = System.Data.Entity.EntityState.Modified;
            _entity.SaveChanges();

            LoginForm loginForm = new LoginForm();
            loginForm.Show();

            this.Close();
        }

        private void graphsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GraphForm graphForm = new GraphForm();
            graphForm.Show();
        }

        private void SendEmail()
        {
            try
            {
                LoaderForm loaderForm = new LoaderForm();
                this.Invoke((MethodInvoker)delegate
                {
                    loaderForm.Show();
                    loaderForm.loaderLabel.Text = "Sending..,";
                });
                

                string MailBody = "<html>" +
                "<head></head>" +
                "<body>" +
                "<b>This is a test mail.</b> Sent at: " + DateTime.Now.ToString() +
                "</body>" +
                "</html>";

                MailMessage message = new MailMessage();
                SmtpClient smtp = new SmtpClient();

                message.From = new MailAddress("test.user.3244060943@gmail.com");
                message.To.Add(new MailAddress("waqaxahmed786@gmail.com"));
                message.Subject = "Windows Form || Test Mail";
                message.IsBodyHtml = true;
                message.Body = MailBody;

                smtp.Port = 587;
                smtp.Host = "smtp.gmail.com";
                smtp.EnableSsl = true;
                System.Net.ServicePointManager.SecurityProtocol = System.Net.SecurityProtocolType.Tls12;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new NetworkCredential("test.user.3244060943@gmail.com", "mkbenkspexjerytm");
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.Send(message);

                this.Invoke((MethodInvoker)delegate
                {
                    loaderForm.Close();
                });

                MessageBox.Show("Mail sent successfully");

            }
            catch (Exception ex)
            {
                MessageBox.Show("err: " + ex.Message);
            }
        }

        private void sendMailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Thread threadInput = new Thread(SendEmail);
            threadInput.Start();
        }

    }
}
