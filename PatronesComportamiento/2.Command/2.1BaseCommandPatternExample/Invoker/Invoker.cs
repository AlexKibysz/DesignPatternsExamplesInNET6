using PatronesComportamiento._2.Command._2._1BaseCommandPatternExample.Command;

namespace PatronesComportamiento._2.Command._2._1BaseCommandPatternExample.Invoker
{
    //el invocador esta asociado a uno o varios comandos, envia la peticion a la clase Commando
    //un ejemplo de un Invoker podria ser un control remoto, este envia la señal al Televisor(Command)
    //y el televisor resuelve este pedido
    public class MyInvoker
    {
        private ICommand _onStart;

        private ICommand _onFinish;

        public void SetOnStart(ICommand command)
        {
            this._onStart = command;
        }

        public void SetOnFinish(ICommand command)
        {
            this._onFinish = command;
        }

        //el invocador no depende de ningun comando concreto (ConcreteCommand) o las clases receiver.
        //el invocador pasa el pedido indirectamente, ejecutando el comando

        public void DoSomethingImportant()
        {
            Console.WriteLine("Invoker: alguien quiere hacer algo antes de que empiece?");

            if (this._onStart is ICommand)
            {
                this._onStart.execute();
            }

            Console.WriteLine("Invoker: haciendo algo sumamente importante y complejo");

            if (this._onFinish is ICommand)
            {
                this._onFinish.execute();
            }
        }
    }
}