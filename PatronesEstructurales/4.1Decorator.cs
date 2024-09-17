using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesEstructurales
{
    public class DecoratorPart2
    {
    }

    public interface IHamburgesa
    {
        decimal precio();
        string descripcion();
    }

    public class BigMac : IHamburgesa
    {
        public string descripcion()
        {
            return "BigMac"; 
        } 

        public decimal precio()
        {
            return 1.2m;
        }

    }

    public abstract class BigMacDecorator : IHamburgesa //la hacemos abstracta ya que tenemos que armar
                                                        //la propiedad para recibir al que vamos a "envolver"
    {
        private IHamburgesa _hamburgesa;

        public BigMacDecorator(IHamburgesa hamburgesa)
        {
            _hamburgesa = hamburgesa;
        }

        public virtual string descripcion()
        {
            return  _hamburgesa.descripcion();
        }

        public virtual decimal precio()
        {
            return _hamburgesa.precio();
        }
    }


    public class extraBacon : BigMacDecorator
    {
        public extraBacon(IHamburgesa hamburgesa) : base(hamburgesa)
        {
        }

        public override string descripcion()
        {
            return base.descripcion() + " Se agrega extra de Bacon";
        }

        public override decimal precio()
        {
            return base.precio() + 100;
        }

    }

    public class extraCheddar : BigMacDecorator
    {
        public extraCheddar(IHamburgesa hamburgesa) : base(hamburgesa)
        {
        }

        public override string descripcion()
        {
            return base.descripcion() + " Se agrega extra de Cheddar";
        }

        public override decimal precio()
        {
            return base.precio() + 150;
        }

    }

    public class extraCarne : BigMacDecorator
    {
        public extraCarne(IHamburgesa hamburgesa) : base(hamburgesa)
        {
        }

        public override string descripcion()
        {
            return base.descripcion() + " Se agrega extra de Carne";
        }

        public override decimal precio()
        {
            return base.precio() + 500;
        }

    }

}

/*using PatronesEstructurales;

BigMac bigMac = new BigMac();

IHamburgesa bigMacCompleto = new extraBacon(bigMac);

IHamburgesa bigMacCompleto1 = new extraCheddar(bigMacCompleto);

IHamburgesa bigMacCompleto2 = new extraCarne(bigMacCompleto1);

Console.WriteLine($"{bigMacCompleto2.descripcion()}",
    " y el prcio es de", $"{bigMacCompleto2.precio().ToString()}");
*/
