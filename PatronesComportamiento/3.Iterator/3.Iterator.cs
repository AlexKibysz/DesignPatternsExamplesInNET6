using PatronesComportamiento._3.Iterator._3._1_IteratorEmployeeEx;
using PatronesComportamiento._3.Iterator._3._1_IteratorEmployeeEx.ConcreteCollection;
using PatronesComportamiento._3.Iterator._3._1_IteratorEmployeeEx.Models;

namespace PatronesComportamiento
{
    public class IteratorCLIENT
    {
        public static void ejecutarCliente()
        {
            Collection collection = new Collection();
            collection[0] = new Item("Item 0");
            collection[1] = new Item("Item 1");
            collection[2] = new Item("Item 2");
            collection[3] = new Item("Item 3");
            collection[4] = new Item("Item 4");
            collection[5] = new Item("Item 5");
            collection[6] = new Item("Item 6");
            collection[7] = new Item("Item 7");
            collection[8] = new Item("Item 8");
            // Create iterator
            MyConcreteIterator iterator = collection.CreateIterator();
            // Skip every other item
            iterator.Step = 2;
            Console.WriteLine("Iterating over collection:");
            for (Item item = iterator.First();
                !iterator.IsDone; item = iterator.Next())
            {
                Console.WriteLine(item.name);
            }
            // Wait for user
            Console.ReadKey();
        }
    }
}