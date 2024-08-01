namespace PatronesCreacionales._2.AbstractFactory.Concrete_Product
{
    internal class ferrariDiablo : IAutomovil
    {
        public string Encender()
        {
            return "soy un ferrari diablo bruuuum";
        }

        public string Informacion()
        {
            throw new NotImplementedException();
        }
    }
}