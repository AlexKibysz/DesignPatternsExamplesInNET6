namespace PatronesCreacionales.FactoryMethod.FactoryMethodLogistica
{
    public class FactoryMethodLogistica
    {
        public class Empresa
        {
            public void Main()
            {
                Console.WriteLine("incicio logistica Maritima: ");
                ejecutarLogistica(new LogisticaMaritima());

                Console.WriteLine("Inicio logistica Terrestre");
                ejecutarLogistica(new LogisticaTerrestre());
            }

            public void ejecutarLogistica(Logistica logistica)
            {
                Console.WriteLine("el envio fue despachado por: " + logistica.EjecutarOperacion());
            }
        }

        public interface IProduct
        {
            string Envio();
        }

        public abstract class Logistica
        {
            public abstract IProduct createProduct();

            public string EjecutarOperacion()
            {
                var tipoEnvio = createProduct();
                var result = "el tipo de producto es: " + tipoEnvio.Envio();
                return result;
            }
        }

        public class LogisticaTerrestre : Logistica
        {
            public override IProduct createProduct()
            {
                return new EnvioCamion();
            }
        }

        private class EnvioCamion : IProduct
        {
            public string Envio()
            {
                return "El envio se realiza por medio de transporte terrestre: Camion";
            }
        }

        public class LogisticaMaritima : Logistica
        {
            public override IProduct createProduct()
            {
                return new EnvioMaritima();
            }
        }

        private class EnvioMaritima : IProduct
        {
            public string Envio()
            {
                return "El envio se realiza por medio de transporte maritimo: Barco";
            }
        }
    }
}