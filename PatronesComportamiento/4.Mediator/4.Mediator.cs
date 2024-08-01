using PatronesComportamiento._4.Mediator.Component;
using PatronesComportamiento._4.Mediator.Mediador;

namespace PatronesComportamiento
{
    public class Mediator
    {
        public static void EjecutarClienteMediador()
        {
            var TorreControl = new TorreControl();

            Avion avionFlybondy = new Avion(1, "Flybondy 1XL", TorreControl);

            JetPrivado jetPrivado = new JetPrivado(2, "JET MIST FXL504", TorreControl);

            TorreControl.addAeroCrafts(avionFlybondy);
            TorreControl.addAeroCrafts(jetPrivado);

            TorreControl.notify(1, 2, "El avion 1 cambio su trayectoria");

            //Como podemos ver, siempre va a estar involucrado la torre de control por mas que un objeto quiera comunicarse directamente,
            //eso pasa por tener la ref al mediador en su constructor, entonces el mediador le termina enviando el mensaje al destinatario 2
            avionFlybondy.EnviarMensajeGeneral("Hola soy el avion flybondy te informo que cambie de trayectoria por mas que te aviso la torre de control", 2);

            Console.Read();
        }
    }
}