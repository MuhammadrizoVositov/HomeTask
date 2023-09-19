using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    internal class Companys
    {
        public record Company(string CompanyName, string Adress, string PhoneNumber);
    }
}
