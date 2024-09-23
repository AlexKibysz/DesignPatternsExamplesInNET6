using PatronesComportamiento._6.Observer.Suscribers;

namespace PatronesComportamiento._6.Observer.Publisher
{
    public interface ISubject
    {
        //asigna un observador a nuestro notificador
        void Atach(IObserverT observer);

        //desasigna un observador a nuestro notificador
        void Detach(IObserverT observer);
        void notify();

        public int state { get; }
    }
}
