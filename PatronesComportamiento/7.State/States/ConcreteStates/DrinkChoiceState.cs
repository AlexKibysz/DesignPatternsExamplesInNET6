using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
