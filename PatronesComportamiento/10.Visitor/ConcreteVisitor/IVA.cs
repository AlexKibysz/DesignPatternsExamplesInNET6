using PatronesComportamiento._10.Visitor.AbstractVisitor;
using PatronesComportamiento._10.Visitor.ConcreteElement;

namespace PatronesComportamiento._10.Visitor.ConcreteVisitor
{
    public class IVA : IVisitor
    {
        private double impuestoClaseA = 1.21d;
        private double impuestoClaseB = 1.105d;

        public double Visitar(ProductoB productoB)
        {
            return productoB.Precio = impuestoClaseB;
        }

        public double Visitar(ProductoA productoA)
        {
            return productoA.Precio = impuestoClaseA;
        }
    }
}
