using PatronesComportamiento._6._1Observer.SubjectPublisher.Abstract;

namespace PatronesComportamiento._6._1Observer.Subscriber.Abstract
{
    public interface IInvestor
    {
        void Update(Stock stock);
    }
}
