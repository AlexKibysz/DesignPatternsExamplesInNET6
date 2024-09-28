using PatronesCombinados.CompositeIterator.Composite.Component;
using PatronesCombinados.CompositeIterator.Composite.Composite;
using PatronesCombinados.CompositeIterator.Composite.Leaf;

namespace PatronesCombinados.CompositeIterator.Composite.Util
{
    public static class PrintCollection
    {
        public static void Print(IMenuComponent component)
        {
            if (component is IMenu menu)
            {
                Console.WriteLine($"------------Nombre: {menu.getName()} Descripcion: {menu.getDescription()}------------");
                foreach (var subComponent in menu.getMenuComponents())
                {
                    Print(subComponent);
                }
            }
            else if (component is IMenuItem menuItem)
            {
                Console.WriteLine($"Nombre: {menuItem.getName()} Descripcion: {menuItem.getDescription()} esVegano: {menuItem.isVegetarian()}");
            }
        }
    }
}
