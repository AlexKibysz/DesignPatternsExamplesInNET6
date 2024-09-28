using PatronesCombinados.CompositeIterator.Composite.Component;

namespace PatronesCombinados.CompositeIterator.Composite.Leaf
{
    // Interfaz para los ítems de menú
    public interface IMenuItem : IMenuComponent
    {
        bool isVegetarian();
    }
}
