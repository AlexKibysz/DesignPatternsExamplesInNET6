using PatronesComportamiento._2.Command._2._1BaseCommandPatternExample.Command;

namespace PatronesComportamiento._2.Command._2._1BaseCommandPatternExample.ConcreteComand
{
    //algunos comandos pueden implementar y realizar operaciones simples por si mismas
    public class SimpleCommand : ICommand
    {
        private string _payload = string.Empty;

        public SimpleCommand(string payload)
        {
            _payload = payload;
        }

        public void execute()
        {
            Console.WriteLine($"Ves? puedo ejecutar comandos simples por mi misma: {_payload}");
        }
    }
}