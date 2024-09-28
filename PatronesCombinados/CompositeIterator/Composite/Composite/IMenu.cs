using PatronesCombinados.CompositeIterator.Composite.Component;
using PatronesCombinados.CompositeIterator.Iterador.AbstractIterator;

namespace PatronesCombinados.CompositeIterator.Composite.Composite
{
    // Interfaz para los menús
    public interface IMenu : IMenuComponent
    {
        void addMenuComponent(IMenuComponent menuComponent);
        void removeMenuComponent(IMenuComponent menuComponent);
        IMenuComponent getChild(int i);
        List<IMenuComponent> getMenuComponents();
        IMenuIterator CreateIterator();
    }
}
