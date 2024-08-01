namespace PatronesComportamiento._2.Command._2._3TelevisionCommandPatternExample.Receiver
{
    public class Televisor
    {
        public void Encender()
        {
            Console.WriteLine("Encendiendo el Televisor");
        }

        public void Apagar()
        {
            Console.WriteLine("Apagando el televisor");
        }

        public void CambiarCanal()
        {
            Console.WriteLine("Cambiando Canal");
        }
    }
}