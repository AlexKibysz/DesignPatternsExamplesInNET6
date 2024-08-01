using PatronesComportamiento._2.Command._2._2CommandPatternERP.ConcreteCommand;
using PatronesComportamiento._2.Command._2._2CommandPatternERP.InvokerEmpSol;
using PatronesComportamiento._2.Command._2._2CommandPatternERP.Reciver;

namespace PatronesComportamiento._2.Command._2._2CommandPatternERP.Client
{
    public class ClienteERP
    {
        public static void Ejecutar()
        {
            var tareaService = new TareaService();

            var crearTareaCommand = new CreateTareaCommand(tareaService);

            var tareaController = new TareaController();

            tareaController.EjecutarComando(crearTareaCommand);

            tareaController.EjecutarComando(crearTareaCommand);

            tareaController.EjecutarComando(crearTareaCommand);

            tareaService.ListarTareas();

            tareaController.Deshacer();

            tareaService.ListarTareas();
        }
    }
}