using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Mail
{
    public class SendMail
    {
       public void Send()
        {

            MailMessage mail = new MailMessage();
            SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

            mail.From = new MailAddress("damian.lewandowski.dev@gmail.com");
            mail.To.Add("damian.lewandowski.dev@gmail.com");
            mail.Subject = "Test Mail";
            mail.Body = "This is for testing SMTP mail from GMAIL";

            SmtpServer.Port = 587;
            SmtpServer.Credentials = new System.Net.NetworkCredential("damian.lewandowski.dev@gmail.com", "YourPassword");
            SmtpServer.EnableSsl = true;

            SmtpServer.Send(mail);
           

        }
    }
}
