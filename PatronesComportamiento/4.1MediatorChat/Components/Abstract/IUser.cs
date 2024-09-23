namespace PatronesComportamiento._4._1MediatorChat.Components.Abstract
{

    public interface IUser
    {
        void SendMessage(string message);
        void ReceiveMessage(string message);
        string GetName();
    }

}
