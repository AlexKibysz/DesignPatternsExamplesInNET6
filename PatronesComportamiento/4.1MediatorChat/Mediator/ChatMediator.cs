using PatronesComportamiento._4._1MediatorChat.Components.Abstract;

namespace PatronesComportamiento._4._1MediatorChat.Mediator
{
    public class ChatMediator : IChatMediator
    {

        private List<IUser> _users;

        public ChatMediator()
        {
            _users = new List<IUser>();
        }

        public void AddUser(IUser user)
        {
            _users.Add(user);
        }

        public void SendMessage(string message, IUser user)
        {
            foreach (var u in _users)
            {
                if (u != user)
                {
                    u.ReceiveMessage(message);
                }
            }
        }

        public void SendDirectMessage(string message, IUser fromUser, IUser toUser)
        {
            toUser.ReceiveMessage($"Mensaje directo de {fromUser.GetName()}: {message}");
        }

    }
}

/*program.cs
   IChatMediator chatMediator = new ChatMediator();

        IUser user1 = new User("Alice", chatMediator);
        IUser user2 = new User("Bob", chatMediator);
        IUser user3 = new User("Charlie", chatMediator);

        chatMediator.AddUser(user1);
        chatMediator.AddUser(user2);
        chatMediator.AddUser(user3);

        user1.SendMessage("Hola a todos!");
        user2.SendMessage("Hola Alice!");
        user3.SendMessage("Hola Bob!");

        // Enviar un mensaje directo de Alice a Bob
        chatMediator.SendDirectMessage("¿Cómo estás, Bob?", user1, user2);
 
 
 
 
 
 
 
 */