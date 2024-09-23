namespace PatronesEstructurales
{
    public class CompositeExample2
    {

    }

    //Aplicamos el principio de ISP, por que si hicieramos un unico IMenuComponent, los Hijos o MenuItem,
    //deberian implementar metodos como addMenuComponent al vicio 
    public interface IMenuComponent
    {

        string getName();

        string getDescription();

        public void print();
    }

    public interface IMenu : IMenuComponent
    {
        void addMenuComponent(IMenuComponent menuComponent);

        void removeMenuComponent(IMenuComponent menuComponent);

        IMenuComponent getChild(int i);

    }

    public interface IMenuItem : IMenuComponent
    {
        public bool isVegetarian();
    }


    public class MenuItem : IMenuItem
    {
        private string Name { get; set; }
        private string Description { get; set; }
        private bool isVeggy { get; set; }

        public MenuItem(string name, string description, bool isveggy)
        {
            Name = name;
            Description = description;
            isVeggy = isveggy;
        }

        public string getDescription()
        {
            return Description;
        }

        public string getName()
        {
            return Name;
        }

        public bool isVegetarian()
        {
            return isVeggy;
        }

        public void print()
        {
            Console.WriteLine($"Nombre: {getName()} Descripcion: {getDescription()} esVegano {isVegetarian()}");
        }
    }

    public class Menu : IMenu
    {
        public Menu(string name, string description)
        {
            Name = name;
            Description = description;
        }

        private List<IMenuComponent> _menuComponents = new List<IMenuComponent>();

        private string Name { get; set; }
        private string Description { get; set; }


        public void addMenuComponent(IMenuComponent menuComponent)
        {
            _menuComponents.Add(menuComponent);
        }

        public IMenuComponent getChild(int i)
        {
            return _menuComponents[i];
        }

        public string getDescription()
        {
            return Description;
        }

        public string getName()
        {
            return Name;
        }

        public void print()
        {
            Console.WriteLine($"------------Nombre: {getName()} Descripcion: {getDescription()}------------");

            foreach (var component in _menuComponents)
            {
                component.print();
            }
        }

        public void removeMenuComponent(IMenuComponent menuComponent)
        {
            _menuComponents.Remove(menuComponent);
        }
    }

}

/*
 
 Menu menuDesayuno = new Menu("Desayuno", "Menu con todas las cosas ricas para desayunar...");

MenuItem tostadoMasCafe = new MenuItem("Tostado con Cafe", "sanguche de miga tostado, mas cafe expresso cortado", false);

MenuItem tostadoMasTe = new MenuItem("Tostado con Te", "sanguche de miga tostado, mas cafe expresso cortado", false);

menuDesayuno.addMenuComponent(tostadoMasCafe);
menuDesayuno.addMenuComponent(tostadoMasTe);

Menu menuAlmuerzo = new Menu("Almuerzo", "Menu con todas las cosas ricas para almorzar...");


MenuItem rissotoTapaNalga = new MenuItem("Rissoto con Tapa de Nalga",
    "Una porcion de rissoto con un pedazo de tapa de nalga al horno decorado con finas hierbas", false);

MenuItem ensaladaCesar = new MenuItem("Ensalada Cesar", "Lechuga, mayonesa, Croutones para que te sientas como el cesar", true);

menuAlmuerzo.addMenuComponent(rissotoTapaNalga);

menuAlmuerzo.addMenuComponent(ensaladaCesar);

menuAlmuerzo.removeMenuComponent(rissotoTapaNalga);

Menu menuCena = new Menu("Cena", "Menu con todas las cosas ricas para Cenar...");

MenuItem asado = new MenuItem("Asado", "2 chori, 2 chinchu, 1 Costillar, 1 matambrito", false);

menuCena.addMenuComponent(asado);


Menu menuCompleto = new Menu("Menu Completo", "Menu Completo de la casa");

menuCompleto.addMenuComponent(menuDesayuno);
menuCompleto.addMenuComponent(menuAlmuerzo);
menuCompleto.addMenuComponent(menuCena);


menuCompleto.print();
 */
