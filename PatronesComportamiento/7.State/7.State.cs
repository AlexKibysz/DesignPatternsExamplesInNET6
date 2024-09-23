using PatronesComportamiento._7.State.Context;
using PatronesComportamiento._7.State.States;

namespace PatronesComportamiento.State
{
    public class State
    {
        /*Supongamos que estamos desarrollando el software para una máquina expendedora de bebidas.
         * La máquina tiene varios estados,
         * como “Sin Monedas”, “Moneda Insertada”, “Selección de Bebida”, “Entrega de Bebida”, etc.
         * Cada estado afecta el comportamiento de la máquina y las acciones que el usuario puede realizar.*/

        public void ejecutarClienteState()
        {
            NoCoinsState noCoinsInitial = new NoCoinsState();

            VendingMachine vendingMachine = new VendingMachine(noCoinsInitial);


            for (int i = 0; i < 5; i++)
            {
                vendingMachine.doThis();

                vendingMachine.changeState();
            }

        }
    }
}