using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace N40_HT_2
{
    public class EmailSenderServise
    {
        private readonly Queue<Email>_emailQueue=new Queue<Email>();
        private readonly object _lock = new object();
        private bool _isSending=false;
        private readonly SmtpClient _smtpClient;
        private readonly NetworkCredential Credential;

        public bool Enable { get; }

        public EmailSenderServise(string smtpServer,int smtpPost,string smtpUsername,string smtpPassword,bool isSending)
        {
            _smtpClient = new SmtpClient(smtpServer,smtpPost);
            {
                Credential = new NetworkCredential(smtpUsername, smtpPassword);
                Enable=true;
            };
        }
        public void SendEmailAsync(Email email, bool _isSending) 
        {
            lock (_lock)
            {
                _emailQueue.Enqueue(email);
                if (!_isSending)

                {
                    _isSending = true;
                    Task.Run(() => SendEmail());
                }
            }
        }
        public void SendEmail()
        {
            while(true) 
            {
                Email email;
                lock(_lock) 
                {
                    if(_emailQueue.Count==0)
                    {
                        _isSending = false;
                        break;

                    }
                    email = _emailQueue.Dequeue();
                }
                using (var messega=new MailMessage(" ",email.To,email.Subject,email.Body))
                {
                    _smtpClient.Send(messega);
                    Console.WriteLine($"Send email to{email.To} with Subject{email.Subject} and body{email.Body}");
                }
            }
        }
        
            

    }
}
