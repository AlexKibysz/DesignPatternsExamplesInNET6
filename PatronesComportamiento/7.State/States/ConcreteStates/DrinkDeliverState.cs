using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesComportamiento._7.State.States
{
    public class DrinkDeliverState : IVendingMachineState
    {
        public void doSomething()
        {
            Console.WriteLine("Entregando Bebida...");
        }
    }
}
