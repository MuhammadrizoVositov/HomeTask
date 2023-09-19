using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Adress
    {
        public record Adresss(string Adress_street, string City, string Sate, int ZipNumber);
    }
}
