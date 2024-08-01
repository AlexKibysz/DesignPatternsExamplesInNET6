namespace PatronesEstructurales
{
    /*using PatronesEstructurales;

Box box = new Box("caja 50x50");

Product product1 = new Product("Playstation 2");

Box box2 = new Box("caja 50x20");

Product product2 = new Product("sony walkman");

Product product3 = new Product("luis miguel CD");

box2.addToBox(product2);

box2.addToBox(product3);

box.addToBox(product1);

box.addToBox(box2);

Composite.Observar(box, 0);

Console.WriteLine(box.ToString());*/

    public class Composite
    {
        public static void Observar(IEmpaquetado empaquetado, int depth)
        {
            Console.WriteLine(new string('-', depth) + (empaquetado is Box caja ? caja.Observar() : ((Product)empaquetado).Observar()));

            if (empaquetado is Box box)
            {
                foreach (var empaque in box._empaquetados)
                {
                    Observar(empaque, depth + 1);
                }
            }
        }
    }

    public class Product : IEmpaquetado
    {
        public string nombre { get; set; }

        public Product(string nombre)
        {
            this.nombre = nombre;
        }

        public string Observar()
        {
            return $"Producto {nombre}";
        }
    }

    public class Box : IEmpaquetado
    {
        public List<IEmpaquetado> _empaquetados = new List<IEmpaquetado>();

        private string _nombre;

        public Box(string nombre)
        {
            this._nombre = nombre;
        }

        public void addToBox(IEmpaquetado empaquetado)
        {
            _empaquetados.Add(empaquetado);
        }

        public string Observar()
        {
            return $"Caja {_nombre}";
        }
    }

    public interface IEmpaquetado
    {
        string Observar();
    }
}