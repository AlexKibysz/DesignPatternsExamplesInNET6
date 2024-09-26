using PatronesCombinados.SimplerCompositeIterator.Component;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesCombinados.SimplerCompositeIterator.Leaf
{
    public class Hoja : IComponent
    {
        public string Nombre { get; set; }

        public Hoja(string nombre)
        {
            Nombre = nombre;
        }

        public void Mostrar(int profundidad)
        {
            Console.WriteLine(new String('-', profundidad) + Nombre);
        }
    }
}
