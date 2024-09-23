using PatronesComportamiento._10.Visitor.AbstractElement;
using PatronesComportamiento._10.Visitor.AbstractVisitor;

namespace PatronesComportamiento._10.Visitor.ConcreteElement
{
    public class ProductoB : Producto
    {
        public override double Aceptar(IVisitor visitor)
        {
            return visitor.Visitar(this);
        }
    }
}
