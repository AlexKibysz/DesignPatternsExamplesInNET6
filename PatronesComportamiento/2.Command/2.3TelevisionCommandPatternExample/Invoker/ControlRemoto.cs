using PatronesComportamiento._2.Command._2._3TelevisionCommandPatternExample.Command;

namespace PatronesComportamiento._2.Command._2._3TelevisionCommandPatternExample.Invoker
{
    public class ControlRemoto
    {
        private ICommandTelevision _command;

        public void SetCommand(ICommandTelevision comando)
        {
            _command = comando;
        }

        public void PresionarBoton()
        {
            _command.execute();
        }
    }
}