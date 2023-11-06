using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Identity.Application.Domain.Identity.Models
{
    public class LoginDetails
    {
        public string EmailAdress { get; set; }=string.Empty;
        public string Password { get; set; }=string.Empty;
    }
}
