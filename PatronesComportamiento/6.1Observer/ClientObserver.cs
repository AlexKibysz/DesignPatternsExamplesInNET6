using PatronesComportamiento._6._1Observer.SubjectPublisher.Concrete;
using PatronesComportamiento._6._1Observer.Subscriber.Concrete;

namespace PatronesComportamiento._6._1Observer
{
    public static class ClientObserver
    {
        public static void test()
        {
            IBM ibm = new IBM("IBM", 120.00);
            ibm.Attach(new Investor("Sorros"));
            ibm.Attach(new Investor("Berkshire"));
            // Fluctuating prices will notify investors
            ibm.Price = 120.10;
            ibm.Price = 121.00;
            ibm.Price = 120.50;
            ibm.Price = 120.75;
            // Wait for user
            Console.ReadKey();
        }



    }
}
