﻿using PatronesComportamiento._5.Memento;
using PatronesComportamiento._5.Memento.Caretaker;

namespace PatronesComportamiento
{
    public class Memento
    {
        public static void clienteMementoEjecutar()
        {
            var alex = new PersonaMem(21, "Alexander", "Kibysz", "Programador");
            var personaHistory = new PersonaHistory();

            personaHistory.AddMemento(alex.GuardarHistorial(DateTime.Now));
            alex.CambioDeDatos();
            personaHistory.AddMemento(alex.GuardarHistorial(DateTime.Now));
            alex.CambioDeDatos();
            personaHistory.AddMemento(alex.GuardarHistorial(DateTime.Now));

            Console.WriteLine("Historial de cambios:");
            for (var i = 0; i < 3; i++)
            {
                var history = personaHistory.GetMemento(i);
                history.ReadMemento();
            }

            Console.Read();
        }
    }
}