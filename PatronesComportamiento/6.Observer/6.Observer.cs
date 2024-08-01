using PatronesComportamiento._6.Observer.Publisher;
using PatronesComportamiento._6.Observer.Suscribers;

namespace PatronesComportamiento
{
    public class Observer
    {

        public static void ejecutarClienteObserver()
        {
            var subject = new TiendaPublisher();

            ClienteEmail email1 = new ClienteEmail();

            subject.Atach(email1);

            ClienteSMS clienteSms1 = new ClienteSMS();

            subject.Atach(clienteSms1);

            for (int i = 0; i < 5; i++)
            {
                //hago un if por el condicional que tiene state dentro de cada Observador
                subject.SomeBusinessLogic();
            }
           
            subject.Detach(clienteSms1);

            subject.SomeBusinessLogic();
        }
    }
}