namespace PatronesComportamiento._5.Memento
{
    public class MementoPersona
    {
        private PersonaMem personaMem;

        private DateTime datetime;

        public MementoPersona(PersonaMem personaMem, DateTime datetime)
        {
            this.personaMem = personaMem;
        }

        public void readMemento()
        {
            Console.WriteLine($"mi estado a las {datetime} es: edad: {this.personaMem.edad},nombre: {this.personaMem.nombre}, apellido: {this.personaMem.apellido}, profesion: {this.personaMem.profesion}");
        }
    }
}