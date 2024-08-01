namespace PatronesCreacionales._2.AbstractFactory
{
    public interface IFabricaVehiculo
    {
        public IAutomovil crearAutomovil();

        public IMotocicleta crearMotocicleta();
    }
}