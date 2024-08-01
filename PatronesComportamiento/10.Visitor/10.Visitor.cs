using PatronesComportamiento._10.Visitor.ConcreteElement;
using PatronesComportamiento._10.Visitor.ConcreteVisitor;

namespace PatronesComportamiento
{
    public class Visitor
    {
        public void ejecutarCliente()
        {
            var pc1 = new ProductoA();
            pc1.Precio = 100;


            var pc2 = new ProductoB();
            pc2.Precio = 100;


            var iva = new IVA();
            Console.WriteLine($"el precio total del producto 1 es {pc1.Aceptar(iva)}");
            Console.WriteLine($"el precio total del producto 2 es {pc2.Aceptar(iva)}");

        }
    }
}