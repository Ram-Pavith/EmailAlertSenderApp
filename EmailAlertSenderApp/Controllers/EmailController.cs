using MailKit.Net.Smtp;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MimeKit;

namespace EmailAlertSenderApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmailController : ControllerBase
    {
        [HttpPost]
        public IActionResult SendEmail(string body)
        {
            var email = new MimeMessage();
            email.From.Add(MailboxAddress.Parse("cindy.denesik@ethereal.email"));
            email.To.Add(MailboxAddress.Parse("cindy.denesik@ethereal.email"));
            email.Subject = "Testing MimeKit To Send a Test Email From Dotnet Web API";
            email.Body = new TextPart(MimeKit.Text.TextFormat.Html) { Text = body };

            using var smtp = new SmtpClient();
            smtp.Connect("smtp.ethereal.email", 597, MailKit.Security.SecureSocketOptions.StartTls);
            smtp.Authenticate("cindy.denesik@ethereal.email", "6vrQh6GyUURr4jBRJe");
            smtp.Send(email);
            smtp.Disconnect(true);
            return Ok();


        }
    }
}