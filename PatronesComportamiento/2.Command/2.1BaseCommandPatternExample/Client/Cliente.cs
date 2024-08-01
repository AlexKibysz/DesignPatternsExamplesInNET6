using PatronesComportamiento._2.Command._2._1BaseCommandPatternExample.ConcreteComand;
using PatronesComportamiento._2.Command._2._1BaseCommandPatternExample.Invoker;
using PatronesComportamiento._2.Command._2._1BaseCommandPatternExample.Reciver;

namespace PatronesComportamiento._2.Command._2._1BaseCommandPatternExample.Client
{
    internal class Cliente
    {
        public void ejecutarCliente()
        {
            // The client code can parameterize an invoker with any commands.
            var invoker = new MyInvoker();
            invoker.SetOnStart(new SimpleCommand("Say Hi!"));
            Receiver receiver = new Receiver();
            invoker.SetOnFinish(new ComplexCommand(receiver, "Send email", "Save report"));

            invoker.DoSomethingImportant();
        }
    }
}