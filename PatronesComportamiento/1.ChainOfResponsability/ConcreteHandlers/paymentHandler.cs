namespace PatronesComportamiento._1.ChainOfResponsability.ConcreteHandlers
{
    public class paymentHandler : BaseHandlerProcessor
    {
        public override async Task<bool> HandleAsync(Order order)
        {
            if (order.cost > 20)
            {
                Console.WriteLine("Verificando el pago sea mayor a 20...");
                return await base.HandleAsync(order);
            }
            else
            {
                throw new Exception("Exception: Payment Rejected");
            }
        }
    }
}