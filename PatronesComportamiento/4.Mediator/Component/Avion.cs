using PatronesComportamiento._4.Mediator.Mediador;

namespace PatronesComportamiento._4.Mediator.Component
{
    public class Avion : IAeralComponent
    {
        public int id { get; set; }

        public string name { get; set; }

        private IMediator _mediator;

        public Avion(int id, string name, IMediator mediator)
        {
            this.id = id;
            this.name = name;
            this._mediator = mediator;
        }

        public void ReciveMessage(string message)
        {
            Console.WriteLine($"Mensaje Recibido:" + message);
        }

        public void EnviarMensajeGeneral(string mensaje, int destinatario)
        {
            _mediator.notify(this.id, destinatario, mensaje);
        }
    }
}