using PatronesComportamiento._8.Strategy.Context;
using PatronesComportamiento._8.Strategy.Strategies;

namespace PatronesComportamiento
{
    public static class Strategy
    {
        public static void ejecutarClienteStrategy()
        {
            PushNotificationStrategy pushNoti = new PushNotificationStrategy();

            SistemaGestionTareas Sistema = new SistemaGestionTareas(pushNoti);

            Sistema.notificar();

            MailNotiStrategy mailNotiStrategy = new MailNotiStrategy();

            Sistema.changeStrategy(mailNotiStrategy);

            Sistema.notificar();
        }
    }
}