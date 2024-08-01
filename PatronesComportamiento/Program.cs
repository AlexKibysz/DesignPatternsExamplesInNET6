using PatronesComportamiento;
using PatronesComportamiento._8.Strategy.Context;
using PatronesComportamiento._8.Strategy.Strategies;

internal class Program
{
    private static void Main(string[] args)
    {
        Visitor visitor = new Visitor();

        visitor.ejecutarCliente();
    }
}