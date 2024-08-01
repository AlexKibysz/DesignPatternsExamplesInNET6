using PatronesComportamiento._10.Visitor.AbstractVisitor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesComportamiento._10.Visitor.AbstractElement
{
    public abstract class Producto
    {
        public double Precio { get;set; }

        public abstract double Aceptar(IVisitor visitor);
    }
}
