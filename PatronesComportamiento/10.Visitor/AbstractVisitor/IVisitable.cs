using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesComportamiento._10.Visitor.AbstractVisitor
{
    public interface IVisitable
    {
        double Aceptar(IVisitor visitor);
    }
}
