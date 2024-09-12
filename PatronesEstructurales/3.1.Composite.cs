using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

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
        private string Description { get; set ; }
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
