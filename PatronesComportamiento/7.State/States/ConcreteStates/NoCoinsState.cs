namespace PatronesComportamiento._7.State.States
{
    public class NoCoinsState : IVendingMachineState
    {
        public void doSomething()
        {
            Console.WriteLine("Inserte dinero...");
        }
    }
}
