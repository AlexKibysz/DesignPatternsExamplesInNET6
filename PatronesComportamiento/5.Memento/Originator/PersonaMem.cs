namespace PatronesComportamiento._5.Memento
{
    public class PersonaMem
    {
        public int Edad { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Profesion { get; set; }

        public PersonaMem(int edad, string nombre, string apellido, string profesion)
        {
            Edad = edad;
            Nombre = nombre;
            Apellido = apellido;
            Profesion = profesion;
            Console.WriteLine($"Estado Inicial: Edad: {edad}, Nombre: {nombre}, Apellido: {apellido}, Profesion: {profesion}");
        }

        public void CambioDeDatos()
        {
            Console.WriteLine("Persona: Estoy haciendo algo");
            Nombre = RandomStringGenerator.GenerateRandomString(30);
            Console.WriteLine($"Estado Cambiado: Edad: {Edad}, Nombre: {Nombre}, Apellido: {Apellido}, Profesion: {Profesion}");
        }

        public MementoPersona GuardarHistorial(DateTime datetime)
        {
            return new MementoPersona(new PersonaMem(Edad, Nombre, Apellido, Profesion), datetime);
        }
    }
}