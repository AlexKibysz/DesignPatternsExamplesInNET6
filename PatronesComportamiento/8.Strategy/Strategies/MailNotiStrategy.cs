using PatronesComportamiento._8.Strategy.Context;

namespace PatronesComportamiento._8.Strategy.Strategies
{
    public class MailNotiStrategy : INotificationStrategy
    {
        public void enviarNoticacion(string msg)
        {
            Console.WriteLine($"Correo enviado efectivamente: {msg}");
        }
    }
}