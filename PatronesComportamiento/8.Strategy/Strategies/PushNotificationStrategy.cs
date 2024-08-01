using PatronesComportamiento._8.Strategy.Context;

namespace PatronesComportamiento._8.Strategy.Strategies
{
    public class PushNotificationStrategy : INotificationStrategy
    {
        public void enviarNoticacion(string m)
        {
            Console.WriteLine($"Notificacion Push: {m} Enviada!!!");
        }
    }
}