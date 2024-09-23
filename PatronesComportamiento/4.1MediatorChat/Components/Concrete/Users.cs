using PatronesComportamiento._4._1MediatorChat.Components.Abstract;

namespace PatronesComportamiento._4._1MediatorChat.Components.Concrete
{
    public class User : IUser
    {
        private string _name;
        private IChatMediator _mediator;

        public User(string name, IChatMediator mediator)
        {
            _name = name;
            _mediator = mediator;
        }

        public void SendMessage(string message)
        {
            Console.WriteLine($"{_name} envía: {message}");
            _mediator.SendMessage(message, this);
        }

        public void ReceiveMessage(string message)
        {
            Console.WriteLine($"{_name} recibe: {message}");
        }

        public string GetName()
        {
            return _name;
        }
    }
}
