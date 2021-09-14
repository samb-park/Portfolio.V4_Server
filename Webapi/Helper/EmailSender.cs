using System;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.Extensions.Options;
using System.Threading.Tasks;
using SendGrid;
using SendGrid.Helpers.Mail;

namespace Webapi.Helper
{
    public class EmailSender : IEmailSender
    {
        private readonly MailJetSettings _mailJetSettings;

        public EmailSender(IOptions<MailJetSettings> mailjetSettings)
        {
            _mailJetSettings = mailjetSettings.Value;
        }

        public async Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            var apiKey = "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";
            var client = new SendGridClient(apiKey);
            var from = new EmailAddress("sangbong.park@outlook.com.com", "Example User");
            var Subject = "Sending with SendGrid is Fun";
            var to = new EmailAddress("sangbong.park@outlook.com.com", "Example User");
            var plainTextContent = "and easy to do anywhere, even with C#";
            var htmlContent = "<strong>and easy to do anywhere, even with C#</strong>";
            var msg = MailHelper.CreateSingleEmail(from, to, Subject, plainTextContent, htmlContent);
            var response = await client.SendEmailAsync(msg);
        }
    }
}