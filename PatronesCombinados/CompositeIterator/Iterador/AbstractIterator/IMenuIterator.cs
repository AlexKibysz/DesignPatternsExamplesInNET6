using PatronesCombinados.CompositeIterator.Composite.Component;

namespace PatronesCombinados.CompositeIterator.Iterador.AbstractIterator
{
    // Interfaz para el Iterator
    public interface IMenuIterator
    {
        bool HasNext();
        IMenuComponent Next();
    }
}
