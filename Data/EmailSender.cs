using Güzellik_Merkezi.Models;
using Microsoft.AspNetCore.Identity.UI.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace Güzellik_Merkezi.Data
{
    public class EmailSender : IEmailSender
    {

        public Task SendEmailAsync(string email, string subject, string htmlMessage)
        {

            MailMessage mail = new MailMessage();
            mail.IsBodyHtml = true;
            mail.To.Add(email);
            //mail.From = new MailAddress("noreply@optikanaliz.email", "Yönetim", System.Text.Encoding.UTF8);
            mail.Subject = subject;
            mail.Body = htmlMessage;
            mail.IsBodyHtml = true;
            SmtpClient smp = new SmtpClient();
            //smp.Credentials = new NetworkCredential("noreply@optikanaliz.email", "ER.kan13");
            smp.Port = 587;
            //smp.Host = "mail.optikanaliz.email";
            smp.EnableSsl = false;
            smp.Send(mail);
            return Task.CompletedTask;
        }
    }
}
