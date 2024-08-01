using PatronesComportamiento._2.Command._2._1BaseCommandPatternExample.Command;
using PatronesComportamiento._2.Command._2._1BaseCommandPatternExample.Reciver;

namespace PatronesComportamiento._2.Command._2._1BaseCommandPatternExample.ConcreteComand
{
    //a diferencia de nuestro SimpleCommand, en este caso algunos comandos
    //pueden delegar operaciones mas complejas a otros objetos llamados RECIVERS
    public class ComplexCommand : ICommand
    {
        private Receiver _receiver;

        private string _a;

        private string _b;

        public ComplexCommand(Receiver receiver, string a, string b)
        {
            this._receiver = receiver;
            this._a = a;
            this._b = b;
        }

        public void execute()
        {
            Console.WriteLine("ComplexCommand: Las cosas complejas las debe hacer el reciver");
            this._receiver.DoSomething(this._a);
            this._receiver.DoSomethingElse(this._b);
        }
    }
}