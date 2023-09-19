using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HT_1.Models
{
    public class EmailMessage
    {
        internal string ReceiverAddress;

        public string Subject { get; set; }
        public string Body { get; set; }
        public string SenderAdress { get; set; }
        public string ReciverAdress { get; set; }

        public EmailMessage(string subject, string body, string senderAdress, string reciverAdress)
        {
            Subject = subject;
            Body = body;
            SenderAdress = senderAdress;
            ReciverAdress = reciverAdress;
        }

     
    }
}
