namespace PatronesComportamiento._4._1MediatorChat.Components.Abstract
{
    public interface IChatMediator
    {
        void SendMessage(string message, IUser user);
        void AddUser(IUser user);
        void SendDirectMessage(string message, IUser fromUser, IUser toUser);

    }
}
