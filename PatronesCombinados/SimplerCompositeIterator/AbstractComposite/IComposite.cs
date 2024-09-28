using PatronesCombinados.SimplerCompositeIterator.AbstractIterator;
using PatronesCombinados.SimplerCompositeIterator.Component;

namespace PatronesCombinados.SimplerCompositeIterator.AbstractComposite
{
    public interface IComposite : IComponent
    {
        void Agregar(IComponent componente);
        void Remover(IComponent componente);
        IIterador<IComponent> CrearIterador();
    }
}
