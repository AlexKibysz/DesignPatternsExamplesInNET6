using PatronesCombinados.CompositeIterator.Composite.Component;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesCombinados.CompositeIterator.Iterador.AbstractIterator
{
    // Interfaz para el Iterator
    public interface IMenuIterator
    {
        bool HasNext();
        IMenuComponent Next();
    }
}
