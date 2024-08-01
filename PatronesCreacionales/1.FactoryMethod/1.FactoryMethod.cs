namespace PatronesCreacionales.FactoryMethod
{
    public interface IProduct
    {
        string Operation();
    }

    public class FactoryMethod
    {
        /*
         Por ejemplo, imagina que tienes la siguiente jerarquía de clases:
        la clase base Correo con las subclases CorreoAéreo y CorreoTerrestre y la clase Transporte con Avión,
        Camión y Tren. La clase CorreoAéreo sólo utiliza objetos Avión,
        pero CorreoTerrestre puede funcionar tanto con objetos Camión, como con objetos Tren.
        Puedes crear una nueva subclase (digamos, CorreoFerroviario) que gestione ambos casos,
        pero hay otra opción.
        El código cliente puede pasar un argumento al Factory Method de la clase CorreoTerrestre para controlar el producto que quiere recibir.
         */

        public class Client
        {
            public void Main()
            {
                Console.WriteLine("App: Launched with the ConcreteCreator1.");
                ClientCode(new ConcreteCreation1());

                Console.WriteLine("");

                Console.WriteLine("App: Launched with the ConcreteCreator2.");
                ClientCode(new ConcreteCreation2());
            }

            public void ClientCode(Creator creator)
            {
                // ...
                Console.WriteLine("Client: I'm not aware of the creator's class," +
                    "but it still works.\n" + creator.SomeOperation());
                // ...
            }
        }
    }

    public abstract class Creator
    {
        public abstract IProduct ProductType();

        public string SomeOperation()
        {
            var product = ProductType();
            var result = "el operador uso el producto: " + product.Operation();
            return result;
        }
    }

    internal class ConcreteCreation1 : Creator
    {
        public override IProduct ProductType()
        {
            return new ConcreteProduct1();
        }
    }

    internal class ConcreteProduct1 : IProduct
    {
        public string Operation()
        {
            return "producto 1";
        }
    }

    internal class ConcreteCreation2 : Creator
    {
        public override IProduct ProductType()
        {
            return new ConcreteProduct2();
        }
    }

    internal class ConcreteProduct2 : IProduct
    {
        public string Operation()
        {
            return "producto 2";
        }
    }
}