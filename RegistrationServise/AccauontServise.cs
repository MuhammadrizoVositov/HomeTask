using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegistrationServise
{
    public class AccauontServise
    {
        private readonly List<string> _emails;
        private readonly EmailSenderService _emailSenderService;
        public AccauontServise(EmailSenderService emailSenderService)
        {
            _emailSenderService = emailSenderService;
        }


        public AccauontServise()
        {
            _emails = new List<string>();
        }
        public void Register(string emailAdress,string Password)
        {
           if(!IsValid(emailAdress))
                throw new ArgumentException();
           if(!_emailSenderService.SendEmail(emailAdress))
               throw new InvalidOperationException();
            if (!IsUnique(emailAdress))
                throw new Exception();   
        }
        private bool IsUnique(string emailAddress) => _emails.Any(email => email.Equals(emailAddress));

        private bool IsValid(string emailAdress)=>string.IsNullOrWhiteSpace(emailAdress)
            &&Regex.IsMatch(emailAdress, @"^[\w\.-]+@[\w\.-]+\.\w+$");


    }
}
























