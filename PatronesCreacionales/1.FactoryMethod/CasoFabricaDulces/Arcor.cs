using PatronesCreacionales._1.FactoryMethod.CasoFabricaDulces.Contract;

namespace PatronesCreacionales._1.FactoryMethod.CasoFabricaDulces
{
    public class Arcor
    {
        public abstract class FabricaDulces
        {
            public abstract IDulce CrearDulce();

            public string comerDulce()
            {
                IDulce miDulce = CrearDulce();
                string result = "Yo me como el: " + miDulce.comer();
                return result;
            }

            public string origenDulce()
            {
                IDulce miDulce = CrearDulce();
                return miDulce.nombreFabrica();
            }
        }
    }
}