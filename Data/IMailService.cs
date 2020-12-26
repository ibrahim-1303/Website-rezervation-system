//using Microsoft.AspNetCore.Identity.UI.Services;
//using Microsoft.Extensions.Configuration;
//using SendGrid;
//using SendGrid.Helpers.Mail;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;

//namespace Güzellik_Merkezi.Data
//{
//    public interface IEMailService
//    {
//        Task SendEmailAsync(string toEmail, string subject, string content);
//    }

//    public class SendGridMailService : IEMailService
//    {
//        private IConfiguration _configuration;

//        public SendGridMailService(IConfiguration configuration)
//        {
//            _configuration = configuration;
//        }
//        public async Task SendEmailAsync(string toEmail, string subject, string content)
//        {
//            var apiKey = _configuration["Mail Gönder"];
//            var client = new SendGridClient(apiKey);
//            var from = new EmailAddress("ibrahim.ayfer91@hotmail.com", "JWT Auth Demo");
//            var to = new EmailAddress(toEmail);
//            var msg = MailHelper.CreateSingleEmail(from, to, subject, content, content);
//            var response = await client.SendEmailAsync(msg);
//        }
//    }

//}


//Bu sayfa Azure Servisi için yapılmıştır