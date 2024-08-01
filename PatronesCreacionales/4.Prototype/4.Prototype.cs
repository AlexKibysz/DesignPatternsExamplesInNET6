namespace PatronesCreacionales
{
    internal class Prototype
    {
        //ESTE PUEDE SER MUCHO MAS CLARO Y BONITO EN EL CASO DE USAR INTERFACES PERO SE ENTIENDE LA IDEA

        /* PEGAR EN PROGRAM.CS

          private static void Main(string[] args)
    {
        Persona persona1 = new Persona(1, 21, "ALEXANDER", "Magallanes 3647");

        Console.WriteLine("---------------------------------------------PROBLEMA--------------------------------------------------------");

        Console.WriteLine(string.Format("ID Persona: {0} Edad: {1}, nombre: {2}, direccion: {3}", persona1.id.ToString(), persona1.edad.ToString(), persona1.nombre, persona1.direccion.calle));

        //una vez creado nuestro objeto persona 1 vamos a crear la copia de la persona 1 en la persona 2

        Persona persona2 = persona1;

        Console.WriteLine("Imprimimos como quedo la persona2");

        Console.WriteLine("Persona1");

        Console.WriteLine(string.Format("ID Persona: {0} Edad: {1}, nombre: {2}, direccion: {3}", persona1.id.ToString(), persona1.edad.ToString(), persona1.nombre, persona1.direccion.calle));

        Console.WriteLine("Persona2");

        Console.WriteLine(string.Format("ID Persona: {0} Edad: {1}, nombre: {2}, direccion: {3}", persona2.id.ToString(), persona2.edad.ToString(), persona2.nombre, persona2.direccion.calle));

        Console.WriteLine("Supongamos que ahora quiero cambiar la calle de la persona 1, lo vamos a hacer y printear");

        persona1.direccion = new Direccion("pesherman 4321 sidney");

        Console.WriteLine("Persona1");

        Console.WriteLine(string.Format("ID Persona: {0} Edad: {1}, nombre: {2}, direccion: {3}", persona1.id.ToString(), persona1.edad.ToString(), persona1.nombre, persona1.direccion.calle));

        Console.WriteLine("Persona2");

        //que paso en este print?????? como puede ser que haya cambiado la calle de la persona2 si solo cambie la persona1, ese es el problema, me copio el ancla a la clase 1, la solucion es la siguiente

        Console.WriteLine(string.Format("ID Persona: {0} Edad: {1}, nombre: {2}, direccion: {3}", persona2.id.ToString(), persona2.edad.ToString(), persona2.nombre, persona2.direccion.calle));

        persona1.direccion = new Direccion("Magallanes 3647");

        //en vez de crear la persona2, vamos a crear una persona3 pero lo vamos a clonar de una manera diferente, en la clase Persona vamos a crear un metodo de copia superficial (Shallow Copy)

           // Este metodo nos va a retornar una copia del objeto actual al que hace referencia

                //public Persona shallowClone()
               // {
                   // return (Persona) this.MemberwiseClone();
                //}

        Console.WriteLine("------------------------------------------------SOLUCION--------------------------------------------------------------------");

        Console.WriteLine("Probamos el nuevo proceso de clonado");
        Persona persona3 = persona1.shallowClone();

        Console.WriteLine("Persona1");

        Console.WriteLine(string.Format("ID Persona: {0} Edad: {1}, nombre: {2}, direccion: {3}", persona1.id.ToString(), persona1.edad.ToString(), persona1.nombre, persona1.direccion.calle));

        Console.WriteLine("Persona3");
        Console.WriteLine(string.Format("ID Persona: {0} Edad: {1}, nombre: {2}, direccion: {3}", persona3.id.ToString(), persona3.edad.ToString(), persona3.nombre, persona3.direccion.calle));

        Console.WriteLine("Supongamos que ahora quiero cambiar la calle de la persona 1, lo vamos a hacer y printear");

        persona1.direccion = new Direccion("AVIADOR BRADLEY 4321");

        Console.WriteLine("Persona1");

        Console.WriteLine(string.Format("ID Persona: {0} Edad: {1}, nombre: {2}, direccion: {3}", persona1.id.ToString(), persona1.edad.ToString(), persona1.nombre, persona1.direccion.calle));

        Console.WriteLine("Persona3");

        Console.WriteLine(string.Format("ID Persona: {0} Edad: {1}, nombre: {2}, direccion: {3}", persona3.id.ToString(), persona3.edad.ToString(), persona3.nombre, persona3.direccion.calle));
    }

public class Persona
{
public int id {get; set; }
public int edad{get; set; }

public string nombre { get; set; }

public Direccion direccion { get; set; }

public Persona(int id, int edad, string nombre,string calle)
{
    this.id = id;
    this.edad = edad;
    this.nombre = nombre;
    this.direccion = new Direccion(calle);
}

public Persona shallowClone()
{
    return (Persona) this.MemberwiseClone();
}
}
public class Direccion
{
public string calle;

public Direccion(string calle)
{
    this.calle = calle;
}
}

         */
    }
}