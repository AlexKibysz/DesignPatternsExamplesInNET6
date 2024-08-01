using PatronesComportamiento._1.ChainOfResponsability.Contracts;

namespace PatronesComportamiento._1.ChainOfResponsability
{
    public abstract class BaseHandlerProcessor : IHandlerProccesor
    {
        private IHandlerProccesor _nextHandler;

        public virtual IHandlerProccesor SetNext(IHandlerProccesor handler)
        {
            _nextHandler = handler;
            return handler;
        }

        public virtual async Task<bool> HandleAsync(Order order)
        {
            if (_nextHandler != null)
            {
                return await _nextHandler.HandleAsync(order);
            }
            return true;
        }
    }
}