using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
