using PatronesCombinados.SimplerCompositeIterator.AbstractIterator;
using PatronesCombinados.SimplerCompositeIterator.Component;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesCombinados.SimplerCompositeIterator.AbstractComposite
{
    public interface IComposite : IComponent
    {
        void Agregar(IComponent componente);
        void Remover(IComponent componente);
        IIterador<IComponent> CrearIterador();
    }
}
