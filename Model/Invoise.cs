using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Invoise
    {
        public record Invoisee(int Id, string Coustumer, decimal TotalAmount);
    }
}
