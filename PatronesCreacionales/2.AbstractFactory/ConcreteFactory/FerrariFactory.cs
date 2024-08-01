using PatronesCreacionales._2.AbstractFactory.Concrete_Product;

namespace PatronesCreacionales._2.AbstractFactory.ConcreteVehicle
{
    internal class FerrariFactory : IFabricaVehiculo
    {
        public IAutomovil crearAutomovil()
        {
            return new ferrariDiablo();
        }

        public IMotocicleta crearMotocicleta()
        {
            return new ferrari900();
        }
    }
}