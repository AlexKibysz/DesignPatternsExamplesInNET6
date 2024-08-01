using PatronesCreacionales._1.FactoryMethod.CasoFabricaDulces.Contract;
using PatronesCreacionales._1.FactoryMethod.CasoFabricaDulces.Contract.Productos;
using static PatronesCreacionales._1.FactoryMethod.CasoFabricaDulces.Arcor;

namespace PatronesCreacionales._1.FactoryMethod.CasoFabricaDulces.Fabricas
{
    public class FabricaMoritas : FabricaDulces
    {
        public override IDulce CrearDulce()
        {
            return new Moritas();
        }
    }
}