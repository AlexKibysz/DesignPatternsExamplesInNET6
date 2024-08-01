using PatronesComportamiento._2.Command._2._3TelevisionCommandPatternExample.Command;
using PatronesComportamiento._2.Command._2._3TelevisionCommandPatternExample.ConcreteCommand;
using PatronesComportamiento._2.Command._2._3TelevisionCommandPatternExample.Invoker;
using PatronesComportamiento._2.Command._2._3TelevisionCommandPatternExample.Receiver;

namespace PatronesComportamiento._2.Command._2._3TelevisionCommandPatternExample.Client
{
    public class ClienteTelevision
    {
        public static void EjecutarCliente()
        {
            var television = new Televisor();

            List<ICommandTelevision> comandos = new List<ICommandTelevision>();

            var encenderCommand = new TurnOnCommand(television);

            comandos.Add(encenderCommand);

            var cambiarCanal = new CambiarCanal(television);

            comandos.Add(cambiarCanal);

            var apagarCommand = new ApagarTelevisor(television);

            comandos.Add(apagarCommand);

            var controlRemoto = new ControlRemoto();

            foreach (var comando in comandos)
            {
                controlRemoto.SetCommand(comando);
                controlRemoto.PresionarBoton();
            }
        }
    }
}