using PatronesComportamiento._6._1Observer.SubjectPublisher.Abstract;
using PatronesComportamiento._6._1Observer.Subscriber.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesComportamiento._6._1Observer.Subscriber.Concrete
{
    public class Investor : IInvestor
    {
        private string name;
        private Stock stock;
        // Constructor
        public Investor(string name)
        {
            this.name = name;
        }
        public void Update(Stock stock)
        {
            Console.WriteLine("Notified {0} of {1}'s " +
                "change to {2:C}", name, stock.Symbol, stock.Price);
        }
        // Gets or sets the stock
        public Stock Stock
        {
            get { return stock; }
            set { stock = value; }
        }
    }
}
