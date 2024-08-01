using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
