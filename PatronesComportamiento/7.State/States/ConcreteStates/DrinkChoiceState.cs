namespace PatronesComportamiento._7.State.States
{
    public class DrinkChoiceState : IVendingMachineState
    {
        private readonly DrinkChoiceState _state;

        public void doSomething()
        {
            Console.WriteLine("Elija la bebida por favor...");
        }
    }
}
