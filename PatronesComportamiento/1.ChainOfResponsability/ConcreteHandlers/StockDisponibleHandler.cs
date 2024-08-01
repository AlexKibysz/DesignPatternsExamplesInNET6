namespace PatronesComportamiento._1.ChainOfResponsability.ConcreteHandlers
{
    public class StockDisponibleHandler : BaseHandlerProcessor
    {
        public override async Task<bool> HandleAsync(Order order)
        {
            if (order.disponible)
            {
                Console.WriteLine("Verificando disponibilidad de stock...");
                // Simulamos que hay stock disponible
                return await base.HandleAsync(order);
            }
            else { throw new Exception("No Disponible"); }
        }
    }
}