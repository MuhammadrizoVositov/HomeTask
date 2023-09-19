using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Model.Orders;

namespace Model
{
    internal class CostumerOrders
    {
        public record CustomerOrder(string Name, string Email, List<Order> Orders);
    }
}
