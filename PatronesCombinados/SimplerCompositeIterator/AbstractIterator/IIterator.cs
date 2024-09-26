using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesCombinados.SimplerCompositeIterator.AbstractIterator
{
    public interface IIterador<T>
    {
        bool TieneSiguiente();
        T Siguiente();
    }
}
