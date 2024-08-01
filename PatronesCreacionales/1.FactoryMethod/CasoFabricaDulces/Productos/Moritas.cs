namespace PatronesCreacionales._1.FactoryMethod.CasoFabricaDulces.Contract.Productos
{
    public class Moritas : IDulce
    {
        public string comer()
        {
            return "Que rico la morita negra y la roja meh";
        }

        public string nombreFabrica()
        {
            return "Fabria de Moritas";
        }
    }
}