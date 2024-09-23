using PatronesComportamiento._6.Observer.Suscribers;

namespace PatronesComportamiento._6.Observer.Publisher
{
    public class TiendaPublisher : ISubject
    {
        public int state { get; set; } = 0;

        private readonly List<IObserverT> _observers = new List<IObserverT>();

        public void Atach(IObserverT observer)
        {
            _observers.Add(observer);
            Console.WriteLine($"Tienda: Observador Asignado");
        }

        public void Detach(IObserverT observer)
        {
            _observers.Remove(observer);
            Console.WriteLine($"Tienda: Observador DesAsignado");
        }

        public void notify()
        {
            Console.WriteLine("Tienda: Notifying observers...");
            foreach (var observer in _observers)
            {
                observer.update(this);
            }
        }

        public void SomeBusinessLogic()
        {
            Console.WriteLine("\nTiendaPublisher: Estoy trabajando en otra cosa");
            this.state = new Random().Next(0, 10);

            Thread.Sleep(15);

            Console.WriteLine("TiendaPublisher: Mi estado cambio a: " + this.state);
            this.notify();
        }
    }
}
