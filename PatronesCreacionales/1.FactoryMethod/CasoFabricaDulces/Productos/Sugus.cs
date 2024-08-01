namespace PatronesCreacionales._1.FactoryMethod.CasoFabricaDulces.Contract.Productos
{
    public class Sugus : IDulce
    {
        public string comer()
        {
            return "Nada como la sugus naranja...";
        }

        public string nombreFabrica()
        {
            return "Fabrica de Sugus";
        }
    }
}