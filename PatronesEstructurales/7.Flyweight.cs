namespace PatronesEstructurales
{
    public class Flyweight
    {
    }

    // Interfaz para las canciones compartidas
    internal interface ISong
    {
        void Play();
    }

    // Implementación concreta de una canción
    internal class ConcreteSong : ISong
    {
        private string title;

        public ConcreteSong(string title)
        {
            this.title = title;
        }

        public void Play()
        {
            Console.WriteLine($"Reproduciendo '{title}'");
        }
    }

    // Factory para crear y gestionar canciones compartidas
    internal class SongFactory
    {
        private Dictionary<string, ISong> sharedSongs = new Dictionary<string, ISong>();

        public ISong GetSharedSong(string title)
        {
            if (!sharedSongs.ContainsKey(title))
            {
                sharedSongs[title] = new ConcreteSong(title);
            }
            return sharedSongs[title];
        }
    }

    /*
    static void Main()
    {
        var factory = new SongFactory();

        // Crear listas de reproducción
        var playlist1 = new List<ISong>
        {
            factory.GetSharedSong("Imagine"),
            factory.GetSharedSong("Bohemian Rhapsody"),
            factory.GetSharedSong("Hey Jude")
        };

        var playlist2 = new List<ISong>
        {
            factory.GetSharedSong("Bohemian Rhapsody"),
            factory.GetSharedSong("Let It Be"),
            factory.GetSharedSong("Imagine")
        };

        // Reproducir canciones
        foreach (var song in playlist1)
        {
            song.Play();
        }

        foreach (var song in playlist2)
        {
            song.Play();
        }
    }*/
}