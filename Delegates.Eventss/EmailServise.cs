using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates.Eventss
{
    public  class EmailServise
    {
        private readonly SendEvenEmail _sendEvenEmail;
        public EmailServise(SendEvenEmail sendEvenEmail)
        {
            _sendEvenEmail = sendEvenEmail;
        }
        public async ValueTask<Email>SendCreate(Email email) 
        {
            await _sendEvenEmail.CreateEmailStoreAsync(email);
            return email;
        }
    }
}
