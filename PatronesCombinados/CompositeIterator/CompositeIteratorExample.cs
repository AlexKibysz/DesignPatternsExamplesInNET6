using PatronesCombinados.CompositeIterator.Composite.Composite;
using PatronesCombinados.CompositeIterator.Composite.Leaf;
using PatronesCombinados.CompositeIterator.Composite.Util;
using PatronesCombinados.CompositeIterator.Iterador;

namespace PatronesCombinados.CompositeIterator
{
    public static class CompositeIteratorExample
    {


        public static void Run()
        {

            Menu menuPrincipal = new Menu("Menú Principal", "Menú completo del restaurante");

            Menu menuDesayuno = new Menu("Desayuno", "Opciones para el desayuno");
            menuDesayuno.addMenuComponent(new MenuItem("Tostadas", "Tostadas con mantequilla", true, 2.99));
            menuDesayuno.addMenuComponent(new MenuItem("Huevos revueltos", "Huevos revueltos con tocino", false, 3.99));

            Menu menuAlmuerzo = new Menu("Almuerzo", "Opciones para el almuerzo");
            menuAlmuerzo.addMenuComponent(new MenuItem("Ensalada", "Ensalada fresca", true, 4.99));
            menuAlmuerzo.addMenuComponent(new MenuItem("Sandwich", "Sandwich de pollo", false, 5.99));

            Menu menuCena = new Menu("Cena", "Opciones para la cena");
            menuCena.addMenuComponent(new MenuItem("Pasta", "Pasta con salsa de tomate", true, 7.99));
            menuCena.addMenuComponent(new MenuItem("Filete", "Filete con papas", false, 12.99));

            menuPrincipal.addMenuComponent(menuDesayuno);
            menuPrincipal.addMenuComponent(menuAlmuerzo);
            menuPrincipal.addMenuComponent(menuCena);

            PrintCollection.Print(menuPrincipal); //Sin aplicar el patron Iterador


            Console.WriteLine("Aplicando el patron Iterator");

            IterateComposite.PrintMenu(menuPrincipal);
        }
    }


}
