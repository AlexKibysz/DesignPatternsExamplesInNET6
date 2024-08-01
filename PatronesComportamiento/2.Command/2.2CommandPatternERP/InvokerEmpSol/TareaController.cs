using PatronesComportamiento._2.Command._2._2CommandPatternERP.Command;

namespace PatronesComportamiento._2.Command._2._2CommandPatternERP.InvokerEmpSol
{
    public class TareaController
    {
        private readonly List<ICommandERP> _commandsExecuted = new List<ICommandERP>();

        public void EjecutarComando(ICommandERP comando)
        {
            comando.Ejecutar();
            _commandsExecuted.Add(comando);
        }

        public void Deshacer()
        {
            if (_commandsExecuted.Count > 0)
            {
                var ultimoComando = _commandsExecuted.Last();
                ultimoComando.Deshacer();
                _commandsExecuted.Remove(ultimoComando);
            }
            else
            {
                Console.WriteLine("No hay Acciones para deshacer");
            }
        }
    }
}