using PatronesComportamiento._6._1Observer.SubjectPublisher.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesComportamiento._6._1Observer.SubjectPublisher.Concrete
{
   
    public class IBM : Stock
    {
        // Constructor
        public IBM(string symbol, double price)
            : base(symbol, price)
        {
        }
    }
}
