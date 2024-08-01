namespace PatronesComportamiento._5.Memento
{
    public class PersonaMem
    {
        public int edad { get; set; }

        public string nombre { get; set; }

        public string apellido { get; set; }

        public string profesion { get; set; }

        public PersonaMem(int edad, string nombre, string apellido, string profesion)
        {
            this.edad = edad;
            this.nombre = nombre;
            this.apellido = apellido;
            this.profesion = profesion;

            Console.WriteLine($"Mi Estado Inicial es edad: {edad},nombre: {nombre}, apellido: {apellido}, profesion: {profesion} ");
        }

        public void cambioDeDatos()
        {
            Console.WriteLine("Persona: Estoy haciendo algo");
            this.nombre = this.GenerateRandomString(30);
            Console.WriteLine($"Persona: mi estado cambio a: edad: {edad},nombre: {nombre}, apellido: {apellido}, profesion: {profesion}");
        }

        //ojo que esto viola Principio resp unica!!! solo a modo de ejemplo
        private string GenerateRandomString(int length = 10)
        {
            string allowedSymbols = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string result = string.Empty;

            while (length > 0)
            {
                result += allowedSymbols[new Random().Next(0, allowedSymbols.Length)];

                Thread.Sleep(12);

                length--;
            }

            return result;
        }

        public MementoPersona guardarHistorial(DateTime datetime)
        {
            PersonaMem histPerson = new PersonaMem(this.edad, this.nombre, this.apellido, this.profesion);
            return new MementoPersona(histPerson, datetime);
        }
    }
}