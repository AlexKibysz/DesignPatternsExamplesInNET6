using PatronesComportamiento._2.Command._2._2CommandPatternERP.Client;
using PatronesComportamiento._2.Command._2._2CommandPatternERP.Command;
using PatronesComportamiento._2.Command._2._2CommandPatternERP.Reciver;

namespace PatronesComportamiento._2.Command._2._2CommandPatternERP.ConcreteCommand
{
    public class CreateTareaCommand : ICommandERP
    {
        private readonly TareaService _tareaService;

        private Tarea _tareaCreada;

        public CreateTareaCommand(TareaService tareaService)
        {
            _tareaService = tareaService;
        }

        public void Deshacer()
        {
            _tareaService.EliminarTarea(_tareaCreada);
        }

        public void Ejecutar()
        {
            _tareaCreada = _tareaService.CrearTarea();
        }
    }
}