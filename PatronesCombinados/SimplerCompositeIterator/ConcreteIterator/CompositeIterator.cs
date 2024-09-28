using PatronesCombinados.SimplerCompositeIterator.AbstractIterator;
using PatronesCombinados.SimplerCompositeIterator.Component;

namespace PatronesCombinados.SimplerCompositeIterator.ConcreteIterator
{
    public class CompuestoIterador : IIterador<IComponent>
    {
        private readonly List<IComponent> _componentes;
        private int _posicion = 0;

        public CompuestoIterador(List<IComponent> componentes)
        {
            _componentes = componentes;
        }

        public bool TieneSiguiente()
        {
            return _posicion < _componentes.Count;
        }

        public IComponent Siguiente()
        {
            return _componentes[_posicion++];
        }
    }
}
