using PatronesComportamiento._10.Visitor.ConcreteElement;

namespace PatronesComportamiento._10.Visitor.AbstractVisitor
{
    public interface IVisitor
    {

        double Visitar(ProductoA productoA);

        double Visitar(ProductoB productoB);
    }
}
