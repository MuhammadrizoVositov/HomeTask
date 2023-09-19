using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N_20_H
{
    public interface IPaymentProvide
    {
        public void Transfer(IDebidCard sourcecard,IDebidCard destination,decimal amount);
    }
}
