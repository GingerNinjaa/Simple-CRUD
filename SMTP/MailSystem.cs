using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Mail
{
    class MailSystem
    {

        public MailSystem()
        {
            SmtpClient smtp = new SmtpClient("smtp.gmail.com");

            smtp.Port = 587;
            smtp.EnableSsl = true;

            var credential = new NetworkCredential
            {
                UserName = "damian.lewandowski.dev@gmail.com",
                Password = "Lato2019!!"
            };
            smtp.Credentials = credential;

            var message = new MailMessage();
            message.To.Add(new MailAddress("damian.lewandowski.dev@gmail.com"));  // replace with valid value   "recipient@gmail.com" nadawca
            message.From = new MailAddress("damian.lewandowski.dev@gmail.com");  // replace with valid value odbiorca
            message.Subject = "Z formularza kontaktowego - " ; //temat wiadomości
            message.Body = "SPRAWDZAM"; // Zawartość wiadomośći
            message.IsBodyHtml = true;

            smtp.SendMailAsync(message);

        }
    }
}
