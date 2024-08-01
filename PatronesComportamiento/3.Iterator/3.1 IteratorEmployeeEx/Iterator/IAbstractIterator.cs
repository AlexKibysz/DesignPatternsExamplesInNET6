using PatronesComportamiento._3.Iterator._3._1_IteratorEmployeeEx.Models;

namespace PatronesComportamiento._3.Iterator._3._1_IteratorEmployeeEx.Iterator
{
    public interface IAbstractIterator
    {
        Item First();

        Item Next();

        bool IsDone { get; }

        Item CurrentItem { get; }
    }
}