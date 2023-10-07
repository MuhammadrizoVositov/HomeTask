using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N45_HT_1
{
    public class Order
    {
        public int Id {  get; set; }
        public decimal Amount { get; set; }
        public int UserId { get; set; }

        public Order(int id, decimal amount, int userId)
        {
            Id = id;
            Amount = amount;
            UserId = userId;
        }
    }
   
}
