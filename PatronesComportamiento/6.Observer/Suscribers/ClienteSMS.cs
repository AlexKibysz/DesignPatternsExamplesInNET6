using PatronesComportamiento._6.Observer.Publisher;

namespace PatronesComportamiento._6.Observer.Suscribers
{
    public class ClienteSMS : IObserverT
    {
        public void update(ISubject subject)
        {
            if ((subject).state == 0 || (subject).state >= 2)
            {
                Console.WriteLine("Cliente SMS: Reacted to the event.");
            }
        }
    }
}
