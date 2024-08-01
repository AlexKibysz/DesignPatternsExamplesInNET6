namespace PatronesComportamiento._2.Command._2._1BaseCommandPatternExample.Reciver
{
    //la clase reciver contiene importante logica de negocio, esta clase sabe como realizar todo tipo de operaciones
    // asociadas para llevar a cabo un pedido, de hecho cualquier clase puede servir como un receiver
    public class Receiver
    {
        public void DoSomething(string a)
        {
            Console.WriteLine($"Receiver: Working on {a}");
        }

        public void DoSomethingElse(string b)
        {
            Console.WriteLine($"Receiver: Also working on ({b})");
        }
    }
}