using PatronesCreacionales._2.AbstractFactory.Concrete_Product;

namespace PatronesCreacionales._2.AbstractFactory
{
    internal class BmwFactory : IFabricaVehiculo
    {
        public IAutomovil crearAutomovil()
        {
            return new BmwX1();
        }

        public IMotocicleta crearMotocicleta()
        {
            return new c650bmw();
        }
    }
}