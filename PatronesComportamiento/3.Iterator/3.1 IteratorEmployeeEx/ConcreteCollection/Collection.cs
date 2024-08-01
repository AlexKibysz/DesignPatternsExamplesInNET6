using PatronesComportamiento._3.Iterator._3._1_IteratorEmployeeEx.Models;

namespace PatronesComportamiento._3.Iterator._3._1_IteratorEmployeeEx.ConcreteCollection
{
    public class Collection : IAbstractCollection
    {
        private List<Item> items = new List<Item>();

        public MyConcreteIterator CreateIterator()
        {
            return new MyConcreteIterator(this);
        }

        public int Count
        {
            get { return items.Count; }
        }

        public Item this[int index]
        {
            get { return items[index]; }
            set { items.Add(value); }
        }
    }
}