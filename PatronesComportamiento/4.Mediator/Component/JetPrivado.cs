using PatronesComportamiento._4.Mediator.Mediador;

namespace PatronesComportamiento._4.Mediator.Component
{
    public class JetPrivado : IAeralComponent
    {
        public int id { get; set; }

        public string name { get; set; }

        public IMediator _mediator;

        public JetPrivado(int id, string name, IMediator MyMediator)
        {
            this.id = id;
            this.name = name;
        }

        public void EnviarMensajeGeneral(string mensaje, int destinatario)
        {
            _mediator.notify(this.id, destinatario, mensaje);
        }

        public void ReciveMessage(string message)
        {
            Console.WriteLine($"Mensaje Recibido: " + message);
        }
    }
}