using System.Net.Mail;
using System.Net;

using Microsoft.AspNetCore.Identity.UI.Services;

namespace MVCDev
{
    public class EmailService : IEmailSender
    {
        private readonly IConfiguration _configuration;

        public EmailService(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task SendEmailAsync(string email, string subject, string message)
        {
            using var client = new SmtpClient
            {
                Host = _configuration["Email:Host"]!,

                Port = int.Parse(_configuration["Email:Port"]!),

                Credentials = new NetworkCredential(
                    _configuration["Email:Username"],
                    _configuration["Email:Password"]
                ),
                EnableSsl = true
            };

            var mailMessage = new MailMessage(
                _configuration["Email:From"]!,
                email,
                subject,
                message
            );

            await client.SendMailAsync(mailMessage);
        }
    }
}
