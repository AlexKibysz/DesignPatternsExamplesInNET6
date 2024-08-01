namespace PatronesEstructurales
{
    internal class Decorator
    {
    }

    internal interface IBebida
    {
        string Preparar();
    }

    // Implementación concreta de la bebida base (por ejemplo, café)
    internal class Cafe : IBebida
    {
        public string Preparar()
        {
            return "Café";
        }
    }

    // Decorador base
    internal abstract class Decorador : IBebida
    {
        protected IBebida _bebida;

        public Decorador(IBebida bebida)
        {
            _bebida = bebida;
        }

        public virtual string Preparar()
        {
            return _bebida.Preparar();
        }
    }

    // Decorador concreto: leche
    internal class LecheDecorator : Decorador
    {
        public LecheDecorator(IBebida bebida) : base(bebida)
        {
        }

        public override string Preparar()
        {
            return $"{base.Preparar()} con leche";
        }
    }

    // Decorador concreto: azúcar
    internal class AzucarDecorator : Decorador
    {
        public AzucarDecorator(IBebida bebida) : base(bebida)
        {
        }

        public override string Preparar()
        {
            return $"{base.Preparar()} con azúcar";
        }
    }

    //pegar en program cs
    /*
        Crear un café básico
    using PatronesEstructurales;

    IBebida cafe = new Cafe();

    // Agregar leche al café
    IBebida cafeConLeche = new LecheDecorator(cafe);

    // Agregar azúcar al café con leche
    IBebida cafeConLecheYAzucar = new AzucarDecorator(cafeConLeche);

    Console.WriteLine(cafeConLecheYAzucar.Preparar());
    // Salida: "Café con leche con azúcar"*/
}