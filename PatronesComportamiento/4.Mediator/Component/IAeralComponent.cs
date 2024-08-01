namespace PatronesComportamiento._4.Mediator.Component
{
    public interface IAeralComponent
    {
        void ReciveMessage(string message);

        void EnviarMensajeGeneral(string mensaje, int destinatario);

        int id { get; }

        string name { get; }
    }
}