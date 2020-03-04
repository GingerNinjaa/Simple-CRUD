using Data;
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
        public string UserName { get; set; }
        public string UserEmail { get; set; }
        public string Password { get; set; }

        public SendMail(string user)
        {
            this.UserName = user;
        }

        public void Send()
        {

            using (DbModel db = new DbModel())
            {
                 this.UserEmail = db.Users
                                  .Where(x => x.UserName == this.UserName)
                                  .Select(x => x.Email)
                                  .FirstOrDefault();

                 this.Password = db.Users
                                      .Where(x => x.UserName == this.UserName)
                                      .Select(x => x.Password)
                                      .FirstOrDefault();

            }

            MailMessage mail = new MailMessage();
            SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

            mail.From = new MailAddress("damian.lewandowski.dev@gmail.com");
            mail.To.Add(this.UserEmail);
            mail.Subject = "Test Mail";
            mail.Body = $"It looks like you've forgotten your password. \n\n\n" +
                        $"Here is your password " + this.Password;

            SmtpServer.Port = 587;
            SmtpServer.Credentials = new System.Net.NetworkCredential("damian.lewandowski.dev@gmail.com", "YourPassword");
            SmtpServer.EnableSsl = true;

            SmtpServer.Send(mail);
        }


    }
}
