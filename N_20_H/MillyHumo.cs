using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N_20_H
{
    public class MillyHumo : IDebidCard
    {
        public int CardNumber { get ; set ; }
     
        public string BankName { get; set; }
        
        public decimal Amount { get ; set; }

    }
}
