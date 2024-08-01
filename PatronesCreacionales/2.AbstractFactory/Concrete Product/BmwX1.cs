namespace PatronesCreacionales._2.AbstractFactory.Concrete_Product
{
    internal class BmwX1 : IAutomovil
    {
        public string Encender()
        {
            return "Soy un BMWX1";
        }

        public string Informacion()
        {
            throw new NotImplementedException();
        }
    }
}