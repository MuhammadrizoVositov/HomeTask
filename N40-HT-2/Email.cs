using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N40_HT_2
{
    public class Email
    {
        public string To { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public Email(string to, string subject, string body)
        {
            To = to;
            Subject = subject;
            Body = body;

        }
    }
}
