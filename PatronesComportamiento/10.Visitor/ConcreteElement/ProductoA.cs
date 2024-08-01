using PatronesComportamiento._10.Visitor.AbstractElement;
using PatronesComportamiento._10.Visitor.AbstractVisitor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesComportamiento._10.Visitor.ConcreteElement
{
    public class ProductoA : Producto
    {
        public override double Aceptar(IVisitor visitor)
        {
            return visitor.Visitar(this);
        }
    }
}
