namespace PatronesCreacionales._1.FactoryMethod.CasoFabricaDulces.Contract.Productos
{
    internal class Cerebritos : IDulce
    {
        public string comer()
        {
            return "Que rico el cerebrito y el jugo de dentro!!!!";
        }

        public string nombreFabrica()
        {
            return "Fabrica de Cerebritos";
        }
    }
}