using PatronesCombinados.CompositeIterator.Composite.Component;
using PatronesCombinados.CompositeIterator.Iterador.AbstractIterator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
