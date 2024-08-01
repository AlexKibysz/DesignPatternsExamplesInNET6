using PatronesComportamiento._3.Iterator._3._1_IteratorEmployeeEx.ConcreteCollection;
using PatronesComportamiento._3.Iterator._3._1_IteratorEmployeeEx.Iterator;
using PatronesComportamiento._3.Iterator._3._1_IteratorEmployeeEx.Models;

namespace PatronesComportamiento._3.Iterator._3._1_IteratorEmployeeEx
{
    public class MyConcreteIterator : IAbstractIterator
    {
        private Collection collection;

        private int current = 0;

        private int step = 1;

        public MyConcreteIterator(Collection collection)
        {
            this.collection = collection;
        }

        public bool IsDone => current >= collection.Count;

        public Item CurrentItem => collection[current] as Item;

        public Item First()
        {
            current = 0;
            return collection[current] as Item;
        }

        public Item Next()
        {
            current += step;
            if (!IsDone)
            {
                return collection[current] as Item;
            }
            else
            {
                return null;
            }
        }

        public int Step
        {
            get { return step; }
            set { step = value; }
        }
    }
}