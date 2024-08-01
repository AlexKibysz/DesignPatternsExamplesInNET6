namespace PatronesEstructurales
{
    public class Facade
    {
        /*
         using PatronesEstructurales;

Artilleria artilleria = new Artilleria();

Infanteria  infanteria = new Infanteria();

facadePirateShip facadePirateShip = new facadePirateShip(artilleria, infanteria);

Console.WriteLine("-----disparo-----");

facadePirateShip.DispararBarco();

         */
    }

    public class facadePirateShip
    {
        protected Artilleria _artilleria;
        protected Infanteria _infanteria;

        public facadePirateShip(Artilleria artilleria, Infanteria infanteria)
        {
            this._artilleria = artilleria;
            this._infanteria = infanteria;
        }

        public void PreparBarco()
        {
            _artilleria.prepararArtilleria();
            _infanteria.prepararArqueros();
        }

        public void DispararBarco()
        {
            PreparBarco();
            _artilleria.dispararArtilleria();
            _infanteria.dispararArcos();
        }
    }

    public class Artilleria
    {
        public void dispararArtilleria()
        {
            Console.WriteLine("Booom");
        }

        public void prepararArtilleria()
        {
            Console.WriteLine("Preparacion de la artilleria, listos...");
        }
    }

    public class Infanteria
    {
        public void dispararArcos()
        {
            Console.WriteLine("fuisshh, flechas lanzadas");
        }

        public void prepararArqueros()
        {
            Console.WriteLine("Tensen los arcos!, listos...");
        }
    }
}