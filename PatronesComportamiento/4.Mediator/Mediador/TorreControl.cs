using PatronesComportamiento._4.Mediator.Component;

namespace PatronesComportamiento._4.Mediator.Mediador
{
    public class TorreControl : IMediator
    {
        private readonly Dictionary<int, IAeralComponent> _aviones = new Dictionary<int, IAeralComponent>();

        public void notify(int sender, int receiver, string message)
        {
            if (_aviones.TryGetValue(receiver, out var Receiver))
            {
                message = $"TORRE DE CONTROL INFORMA: {_aviones[sender].name} send to {_aviones[receiver].name}"
                + message;
                Receiver.ReciveMessage(message);
            }
            else
            {
                Console.WriteLine($"{Receiver.id} no se ha encontrado");
            }
        }

        public void addAeroCrafts(IAeralComponent flymachine)
        {
            _aviones[flymachine.id] = flymachine;
        }
    }
}