using EmailAlertSenderApp.Models;

namespace EmailAlertSenderApp.Services.EmailService
{
    public interface IEmailService
    {
        void SendEmail(EmailDTO RequestMail);
    }
}
