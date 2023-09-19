using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Exeption
{
    public class EmailCheckServise
    {
        private List<EmailAdress> _emails = new List<EmailAdress>();


        public void Register(EmailAdress emailAdress)
        {
            if (!IsValid(emailAdress))
                throw new ArgumentException();
            if(IsUnique(emailAdress))
                throw new ArgumentException();
            
        }

        private bool IsValid(EmailAdress emailAdress)
        {
            throw new NotImplementedException();
        }

        private bool IsUnique(EmailAdress emailAdress) => _emails.Any(email => email.Equals(emailAdress));

       private bool IsValid(string emailAdress) => string.IsNullOrWhiteSpace(emailAdress)
              && Regex.IsMatch(emailAdress, @"^[\w\.-]+@[\w\.-]+\.\w+$");
        
        
            
             
            
        
          
        
    }
}
