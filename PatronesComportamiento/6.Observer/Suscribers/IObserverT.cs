using PatronesComportamiento._6.Observer.Publisher;

namespace PatronesComportamiento._6.Observer.Suscribers
{
    public interface IObserverT
    {
        void update(ISubject subject);
    }
}
