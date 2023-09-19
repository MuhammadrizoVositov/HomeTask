using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Orders
    {
        public record Order(int Id, string costumer, string Product);
    }
}
