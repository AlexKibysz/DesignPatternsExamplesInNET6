namespace PatronesComportamiento._5.Memento
{
    public class MementoPersona
    {
        private readonly PersonaMem _personaMem;
        private readonly DateTime _datetime;

        public MementoPersona(PersonaMem personaMem, DateTime datetime)
        {
            _personaMem = personaMem;
            _datetime = datetime;
        }

        public void ReadMemento()
        {
            Console.WriteLine($"Estado a las {_datetime}: Edad: {_personaMem.Edad}, Nombre: {_personaMem.Nombre}, Apellido: {_personaMem.Apellido}, Profesion: {_personaMem.Profesion}");
        }
    }
}