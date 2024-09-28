using PatronesCombinados.CompositeIterator.Composite.Component;
using PatronesCombinados.CompositeIterator.Composite.Composite;
using PatronesCombinados.CompositeIterator.Composite.Leaf;
using PatronesCombinados.CompositeIterator.Iterador.AbstractIterator;

namespace PatronesCombinados.CompositeIterator.Iterador
{
    public static class IterateComposite
    {
        public static void PrintMenu(IMenu menu)
        {
            Console.WriteLine($"\n{menu.getName()}");
            Console.WriteLine(menu.getDescription());
            Console.WriteLine("----------------------");

            IMenuIterator iterator = menu.CreateIterator();
            IMenuComponent component;
            while ((component = iterator.Next()) != null)
            {
                if (component is IMenuItem menuItem)
                {
                    Console.WriteLine($"  {menuItem.getName()} {(menuItem.isVegetarian() ? "(v)" : "")}");
                    Console.WriteLine($"     -- {menuItem.getDescription()}");
                }
                else if (component is IMenu submenu)
                {
                    Console.WriteLine($"\n{submenu.getName()}");
                    Console.WriteLine(submenu.getDescription());
                }
            }
        }
    }
}
