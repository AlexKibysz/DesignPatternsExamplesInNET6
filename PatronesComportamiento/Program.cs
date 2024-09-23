using PatronesComportamiento._4._1MediatorChat.Components.Abstract;
using PatronesComportamiento._4._1MediatorChat.Components.Concrete;
using PatronesComportamiento._4._1MediatorChat.Mediator;

internal class Program
{
    private static void Main(string[] args)
    {

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

    }
}