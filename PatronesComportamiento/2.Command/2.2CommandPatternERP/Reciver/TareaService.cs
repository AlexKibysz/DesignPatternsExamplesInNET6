using PatronesComportamiento._2.Command._2._2CommandPatternERP.Client;

namespace PatronesComportamiento._2.Command._2._2CommandPatternERP.Reciver
{
    //Este es nuestro Receiver se encarga de la logica
    //de las acciones que realizaran nuestros comandos
    public class TareaService
    {
        private List<Tarea> _tareas = new List<Tarea>();

        public Tarea CrearTarea()
        {
            Console.WriteLine("ingrese la descripcion de la tarea");
            var descripcion = Console.ReadLine();

            var cont = 0;
            cont = +1;
            var nuevaTarea = new Tarea() { id = cont, Descripcion = descripcion };

            _tareas.Add(nuevaTarea);
            Console.WriteLine($"Tarea '{descripcion}' creada correctamente");

            return nuevaTarea;
        }

        public void EliminarTarea(Tarea tarea)
        {
            _tareas.Remove(tarea);
            Console.WriteLine($"Tarea '{tarea.Descripcion}' eliminada correctamente");
        }

        public void ListarTareas()
        {
            Console.WriteLine("------------Listado de Tareas------------");
            foreach (var tarea in _tareas)
            {
                Console.WriteLine($"ID: {tarea.id}, Descripción: {tarea.Descripcion}");
            }
        }

        public void DeshacerTareaPorId(int tareaId)
        {
            var tarea = _tareas.FirstOrDefault(t => t.id == tareaId);
            if (tarea != null)
            {
                _tareas.Remove(tarea);
                Console.WriteLine($"Tarea '{tarea.Descripcion}' eliminada correctamente por ID.");
            }
            else
            {
                Console.WriteLine($"No se encontró ninguna tarea con el ID {tareaId}.");
            }
        }
    }
}