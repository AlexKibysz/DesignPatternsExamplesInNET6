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
