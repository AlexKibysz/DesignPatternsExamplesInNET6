namespace PatronesComportamiento._1.ChainOfResponsability.Contracts
{
    public interface IHandlerProccesor
    {
        IHandlerProccesor SetNext(IHandlerProccesor handler);

        Task<bool> HandleAsync(Order order);
    }
}