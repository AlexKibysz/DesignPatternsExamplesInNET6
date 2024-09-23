using PatronesComportamiento._10.Visitor.AbstractVisitor;

namespace PatronesComportamiento._10.Visitor.AbstractElement
{
    public abstract class Producto
    {
        public double Precio { get; set; }

        public abstract double Aceptar(IVisitor visitor);
    }
}
