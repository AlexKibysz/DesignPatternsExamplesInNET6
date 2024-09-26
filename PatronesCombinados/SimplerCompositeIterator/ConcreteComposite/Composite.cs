using PatronesCombinados.SimplerCompositeIterator.AbstractIterator;
using PatronesCombinados.SimplerCompositeIterator.Component;
using PatronesCombinados.SimplerCompositeIterator.ConcreteIterator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesCombinados.SimplerCompositeIterator.ConcreteComposite
{
    public class Composite : IComponent
    {
        private List<IComponent> _hijos = new List<IComponent>();

        public event EventHandler? Disposed;

        public string Nombre { get; set; }

        public Composite(string nombre)
        {
            Nombre = nombre;
        }

        public void Agregar(IComponent componente)
        {
            _hijos.Add(componente);
        }

        public void Remover(IComponent componente)
        {
            _hijos.Remove(componente);
        }

        public void Mostrar(int profundidad)
        {
            Console.WriteLine(new String('-', profundidad) + Nombre);
            foreach (var hijo in _hijos)
            {
                hijo.Mostrar(profundidad + 2);
            }
        }

        public IIterador<IComponent> CrearIterador()
        {
            return new CompuestoIterador(_hijos);
        }

    }
}
