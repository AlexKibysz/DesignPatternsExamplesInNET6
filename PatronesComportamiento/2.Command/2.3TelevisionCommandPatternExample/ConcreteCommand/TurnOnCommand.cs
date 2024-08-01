using PatronesComportamiento._2.Command._2._3TelevisionCommandPatternExample.Command;
using PatronesComportamiento._2.Command._2._3TelevisionCommandPatternExample.Receiver;

namespace PatronesComportamiento._2.Command._2._3TelevisionCommandPatternExample.ConcreteCommand
{
    public class TurnOnCommand : ICommandTelevision
    {
        private readonly Televisor _televisor;

        public TurnOnCommand(Televisor televisor)
        {
            _televisor = televisor;
        }

        public void execute()
        {
            _televisor.Encender();
        }
    }
}