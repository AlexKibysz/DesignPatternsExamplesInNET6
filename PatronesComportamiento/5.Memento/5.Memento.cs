using PatronesComportamiento._5.Memento;
using PatronesComportamiento._5.Memento.Caretaker;

namespace PatronesComportamiento
{
    public class Memento
    {
        public static void clienteMementoEjecutar()
        {
            PersonaMem Alex = new PersonaMem(21, "Alexander", "Kibysz", "Programador");

            PersonaHistory personaHistory = new PersonaHistory();

            personaHistory.AddMementos(Alex.guardarHistorial(DateTime.Now));

            Alex.cambioDeDatos();

            personaHistory.AddMementos(Alex.guardarHistorial(DateTime.Now));

            Alex.cambioDeDatos();

            personaHistory.AddMementos(Alex.guardarHistorial(DateTime.Now));

            Console.WriteLine("AHORA VAMOS A VER COMO FUE CAMBIANDO EL ESTADO DEL MAS ANTIGUO A NUEVO");
            for (int i = 0; i < 3; i++)
            {
                MementoPersona history = personaHistory.getMemento(i);
                history.readMemento();
            }

            Console.Read();
        }
    }
}