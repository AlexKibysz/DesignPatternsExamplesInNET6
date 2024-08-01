namespace PatronesComportamiento._4.Mediator.Mediador
{
    public interface IMediator
    {
        void notify(int sender, int receiver, string message);
    }
}