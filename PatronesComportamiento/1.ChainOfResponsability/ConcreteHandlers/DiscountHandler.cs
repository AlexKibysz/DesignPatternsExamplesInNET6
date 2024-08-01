namespace PatronesComportamiento._1.ChainOfResponsability.ConcreteHandlers
{
    public class DiscountHandler : BaseHandlerProcessor
    {
        public override Task<bool> HandleAsync(Order order)
        {
            if (order.ammount > 2)
            {
                Console.WriteLine("Verificando Descuentos");

                Console.WriteLine("Descuento Encontrado");

                decimal precioSinDescuento = order.cost;

                decimal calculoDescuento = order.cost / 1.20M;

                order.cost = calculoDescuento;
                return base.HandleAsync(order);
            }
            else
            {
                throw new Exception("No aplica cupon");
            }
        }
    }
}