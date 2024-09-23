using PatronesComportamiento._7.State.States;

namespace PatronesComportamiento._7.State.Context
{
    public class VendingMachine
    {
        private IVendingMachineState _state;

        public VendingMachine(IVendingMachineState InitialState)
        {
            _state = InitialState;
        }

        //ejecutar accion del estado
        public void doThis()
        {
            _state.doSomething();
        }

        //cambiar el estado al siguiente
        //aca podemos usar dos aproaches, uno que se defina desde el cliente y otro que se defina en el estado que apunte al siguiente
        public void changeState()
        {
            //en este caso vamos a hacer un condicional para el estado

            switch (_state.GetType().Name)
            {
                case "NoCoinsState":
                    _state = new InsertedCoinState();
                    break;

                case "InsertedCoinState":
                    _state = new DrinkChoiceState();
                    break;

                case "DrinkChoiceState":
                    _state = new DrinkDeliverState();
                    break;

                case "DrinkDeliverState":
                    _state = new NoCoinsState();

                    break;
            }


        }



    }
}
