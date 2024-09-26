using PatronesCombinados.CompositeIterator.Composite.Component;
using PatronesCombinados.CompositeIterator.Iterador.AbstractIterator;
using PatronesCombinados.CompositeIterator.Iterador.ConcreteIterator.cs;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesCombinados.CompositeIterator.Composite.Composite
{
    // Implementación concreta de Menu
    public class Menu : IMenu
    {
        private List<IMenuComponent> _menuComponents = new List<IMenuComponent>();
        private string Name { get; set; }
        private string Description { get; set; }

        public Menu(string name, string description)
        {
            Name = name;
            Description = description;
        }

        public void addMenuComponent(IMenuComponent menuComponent)
        {
            _menuComponents.Add(menuComponent);
        }

        public void removeMenuComponent(IMenuComponent menuComponent)
        {
            _menuComponents.Remove(menuComponent);
        }

        public IMenuComponent getChild(int i)
        {
            return _menuComponents[i];
        }

        public List<IMenuComponent> getMenuComponents()
        {
            return _menuComponents;
        }

        public string getName() => Name;
        public string getDescription() => Description;

        public IMenuIterator CreateIterator()
        {
            return new CompositeMenuIterator(this);
        }
    }
}
