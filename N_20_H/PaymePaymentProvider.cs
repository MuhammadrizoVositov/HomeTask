using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N_20_H
{
    public class PaymePaymentProvider : IPaymentProvide
    {
        public decimal TransferInteres { get; init; }
        public void Transfer(IDebidCard sourcecard, IDebidCard destination, decimal amount)
        {
            decimal transferfee = amount * TransferInteres;
            decimal totalamount = amount + transferfee;
            
            
        }
    }
}
