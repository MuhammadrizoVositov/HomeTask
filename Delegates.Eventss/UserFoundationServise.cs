using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates.Eventss
{
    public class UserFoundationServise
    {
        private readonly SendEvenEmail _sendEvenEmail;

        public UserFoundationServise(SendEvenEmail sendEvenEmail)
        {
            _sendEvenEmail = sendEvenEmail;
        }

    }
}
