using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace LocalDbPractice.HelpingClasses
{
    public static class MailSender
    {
        public static bool SendEmail(string toEmail, string password)
        {
            try
            {
                string MailBody = "<html><head></head><body><nav class='navbar navbar-default'><div class='container-fluid'>" +
                            "</div> </nav><center><div><h1 class='text-center'>Password Reset!</h1>" +
                            "<p class='text-center'> Your login credentials are give below; </p><br>" +
                            "<b>Email : " + toEmail + "</b><br>" +
                            "<b>Password : " + password + "</b><br>" +
                            "<p style='color:red;'>If you dont requeest for password reset, please ignore this mail.</p></div></center>" +
                            "</body></html>";


                MailMessage message = new MailMessage();
                SmtpClient smtp = new SmtpClient();

                message.From = new MailAddress(ProjectVariables.FromEmail);
                message.To.Add(new MailAddress(toEmail));
                message.Subject = "Password Reset";
                message.IsBodyHtml = true;
                message.Body = MailBody;

                smtp.Port = 587;
                smtp.Host = "smtp.gmail.com";
                smtp.EnableSsl = true;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new NetworkCredential(ProjectVariables.FromEmail, ProjectVariables.FromPassword);
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.Send(message);

                return true;
            }
            catch
            {
                return false;
            }
        }

    }
}
