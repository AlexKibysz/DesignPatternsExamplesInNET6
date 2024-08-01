using PatronesCreacionales._1.FactoryMethod.CasoFabricaDulces.Fabricas;
using static PatronesCreacionales._1.FactoryMethod.CasoFabricaDulces.Arcor;

namespace PatronesCreacionales._1.FactoryMethod.CasoFabricaDulces
{
    public class MainArcor
    {
        public void Main()
        {
            Console.WriteLine("Que antojo de cerebritos, vamos a decirle a la fabrica de cerebritos!!!!");
            AbrirFabricaDeDulces(new FabricaCerebritos());

            Console.WriteLine("tengo ganas de comer unos sugus");
            AbrirFabricaDeDulces(new FabricaSugus());
        }

        public void AbrirFabricaDeDulces(FabricaDulces fabrica)
        {
            Console.WriteLine("Fabrica: " + fabrica.origenDulce() + "Dulce:" + fabrica.comerDulce());
        }
    }
}