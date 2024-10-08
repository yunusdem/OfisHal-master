using MailKit.Net.Smtp;
using MailKit.Security;
using MimeKit;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace OfisHal.Services
{
    public interface ISmtpService
    {
        void SendMail(string subject, string body, string toAddress, string toName = null, string fileName = null, byte[] fileContents = null, CancellationToken cancellationToken = default);

        Task SendMailAsync(string subject, string body, string toAddress, string toName = null, string fileName = null, byte[] fileContents = null, CancellationToken cancellationToken = default);
    }

    public class SmtpService : ISmtpService
    {
        private readonly string _host;
        private readonly int _port;
        private readonly bool _ssl;
        private readonly string _userName;
        private readonly string _password;
        private readonly MailboxAddress _from;

        public SmtpService()
        {
            _host = "smtp.gmail.com";
            _port = 587;
            _ssl = true;
            _userName = "esgirisfatura@gmail.com";
            _password = "btzm mfvg mbcv wjla".Trim(); // Deneme12#
            _from = new MailboxAddress(Encoding.UTF8, "EsGiris.com - Fatura", _userName);
        }

        public Task SendMailAsync(string subject, string body, string toAddress, string toName = null, string fileName = null, byte[] fileContents = null, CancellationToken cancellationToken = default)
        {
            using (var smtp = new SmtpClient())
            {
                var mm = BuildMailMessage(subject, body, toAddress, toName, fileName, fileContents);

                smtp.ConnectAsync(_host, _port, _ssl ? SecureSocketOptions.StartTls : SecureSocketOptions.None, cancellationToken);
                smtp.AuthenticateAsync(_userName, _password, cancellationToken);
                smtp.SendAsync(mm, cancellationToken);
                return smtp.DisconnectAsync(true, cancellationToken);
            }
        }

        public void SendMail(string subject, string body, string toAddress, string toName = null, string fileName = null, byte[] fileContents = null, CancellationToken cancellationToken = default)
        {
            using (var smtp = new SmtpClient())
            {
                var mm = BuildMailMessage(subject, body, toAddress, toName, fileName, fileContents);

                smtp.Connect(_host, _port, _ssl ? SecureSocketOptions.StartTls : SecureSocketOptions.None, cancellationToken);
                smtp.Authenticate(_userName, _password, cancellationToken);
                smtp.Send(mm, cancellationToken);
                smtp.Disconnect(true, cancellationToken);
            }
        }
        private MimeMessage BuildMailMessage(string subject, string body, string toAddress, string toName, string fileName, byte[] fileContents)
        {
            var builder = new BodyBuilder
            {
                HtmlBody = body
            };

            if (fileContents != null && fileContents.Length > 0)
                builder.Attachments.Add(fileName ?? "File", fileContents);

            var mm = new MimeMessage()
            {
                Body = builder.ToMessageBody(),
                Subject = subject,
                Priority = MessagePriority.Normal
            };

            mm.To.Add(new MailboxAddress(Encoding.UTF8, toName, toAddress));
            mm.From.Add(_from);
            return mm;
        }
    }
}
