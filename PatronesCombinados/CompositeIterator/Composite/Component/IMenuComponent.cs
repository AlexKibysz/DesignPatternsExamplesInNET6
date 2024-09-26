using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesCombinados.CompositeIterator.Composite.Component
{
    // Interfaz base para todos los componentes del menú
    public interface IMenuComponent
    {
        string getName();
        string getDescription();
    }
}
