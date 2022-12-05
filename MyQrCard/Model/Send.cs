using MailKit.Net.Smtp;
using MailKit.Security;
using MimeKit;

namespace MyQrCard.Model
{
    static class Send
    {
        public static async void SendEmail(string email, string fio, string phone)
        {
            var emailMessage = new MimeMessage();

            emailMessage.From.Add(new MailboxAddress("Администрация", "smuromtzev@yandex.ru"));
            emailMessage.To.Add(new MailboxAddress("", email));
            emailMessage.Subject = fio;
            emailMessage.Body = new TextPart(MimeKit.Text.TextFormat.Html)
            {
                Text = phone
            };

            using (var client = new SmtpClient())
            {
                client.CheckCertificateRevocation = false;
                await client.ConnectAsync("smtp.yandex.ru", 465, true);
                
                await client.AuthenticateAsync("smuromtzev", "vxgtvcxznfcytnvw");
                await client.SendAsync(emailMessage);

                await client.DisconnectAsync(true);
            }
        }
    }
}
