using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N_20_H
{
    public class OnlineMarketServise
    {
        private readonly IPaymentProvide _provide;
        private readonly List<Product> _products;
        private readonly KapitalUzcard _uzcard;  // instance olish 
        private readonly IDebidCard _debidCard;
        

        public OnlineMarketServise(IPaymentProvide provide, List<Product> products)
        {
           _provide = provide;  // fild bolish 
            _products = products;
        }
        public void Add(Product product)
        {
            _products.Add(product);
        }
        public void Buy(string name, int number , IDebidCard myCarcd, IDebidCard youCard)
        {
            Product product=_products.FirstOrDefault(p => p.Name == name);
            if(product == null) 
            {
                Console.WriteLine($"Error: Product with name{name} not found");
                return; 
            }


            var amount = _products.Find(p => p.Name == name).Price * number;
            _provide.Transfer(myCarcd, youCard, amount);
        }

        IPaymentProvide payment=new PaymePaymentProvider();
       // OnlineMarketServise marketServise=new OnlineMarketServise(IPaymentProvide);
         

       
    }
}
