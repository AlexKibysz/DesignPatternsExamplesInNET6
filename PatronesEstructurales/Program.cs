using PatronesEstructurales;

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