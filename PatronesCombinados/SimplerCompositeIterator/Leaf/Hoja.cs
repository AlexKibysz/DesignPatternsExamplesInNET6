using PatronesCombinados.SimplerCompositeIterator.Component;

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
