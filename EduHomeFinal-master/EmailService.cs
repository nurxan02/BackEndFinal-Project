using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace EduHomeFinal
{
    public class EmailService
    {
        public Task SendEmailAsync(string email, string subject, string message)
        {
            MailMessage mail = new MailMessage();
            mail.IsBodyHtml = true;
            mail.To.Add(email);
            mail.From = new MailAddress("faridsl19@gmail.com", "EDUHOME Corporation");
            mail.Subject = subject;
            mail.Body = message;
            SmtpClient smp = new SmtpClient();
            smp.UseDefaultCredentials = false;
            smp.Credentials = new NetworkCredential("faridsl19@gmail.com".Trim(), "19701970fz".Trim());
            smp.Port = 587;
            smp.Host = "smtp.gmail.com";
            smp.EnableSsl = true;


            smp.Send(mail);

            return Task.CompletedTask;
        }
    }
}
