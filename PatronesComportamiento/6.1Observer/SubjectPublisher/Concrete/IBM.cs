using PatronesComportamiento._6._1Observer.SubjectPublisher.Abstract;

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
