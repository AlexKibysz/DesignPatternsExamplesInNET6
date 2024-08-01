using PatronesComportamiento._6.Observer.Publisher;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesComportamiento._6.Observer.Suscribers
{
    public class ClienteEmail : IObserverT
    {
        
        public void update(ISubject subject)
        {
            if ((subject).state < 3)
            {
                Console.WriteLine("ClienteEmail: Reacted to the event.");
            }
        }
    }
}
