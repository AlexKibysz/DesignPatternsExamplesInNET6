using PatronesCombinados.CompositeIterator.Composite.Component;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesCombinados.CompositeIterator.Composite.Leaf
{
    // Interfaz para los ítems de menú
    public interface IMenuItem : IMenuComponent
    {
        bool isVegetarian();
    }
}
