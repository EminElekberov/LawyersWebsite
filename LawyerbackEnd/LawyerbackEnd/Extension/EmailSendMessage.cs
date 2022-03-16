using MailKit.Net.Smtp;
using MailKit.Security;
using MimeKit;
using MimeKit.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LawyerbackEnd.Extension
{
    public interface IEmailSendMessage
    {
        void SendMEssage(string to, string subject, string html);
    }
    public class EmailSendMessage : IEmailSendMessage
    {
        public void SendMEssage(string to, string subject, string html)
        {
            MimeMessage mime = new MimeMessage();
            mime.From.Add(MailboxAddress.Parse("aspporto99@gmail.com"));
            mime.To.Add(MailboxAddress.Parse(to));
            mime.Subject = subject;
            mime.Body = new TextPart(TextFormat.Text) { Text=html };
            SmtpClient smtpClient = new SmtpClient();
            smtpClient.Connect("smtp.gmail.com", 587, SecureSocketOptions.StartTls);
            smtpClient.Authenticate("aspporto99@gmail.com", "aspnetc638");
            smtpClient.Send(mime);
            smtpClient.Disconnect(true);
            
        }
    }
}
