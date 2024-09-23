namespace PatronesComportamiento._7.State.States
{
    public class InsertedCoinState : IVendingMachineState
    {
        public void doSomething()
        {
            Console.WriteLine("Ha insertado dinero, por favor continue operando");
        }
    }
}
