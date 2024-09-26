using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesCombinados.SimplerCompositeIterator.Component
{
    public interface IComponent
    {
        string Nombre { get; set; }
        void Mostrar(int profundidad);
    }
}
