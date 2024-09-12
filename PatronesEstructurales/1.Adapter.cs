namespace PatronesEstructurales
{
    public class Adapter
    {
        public void mostrarPrints()
        {
            Console.WriteLine("Motor Naftero");

            IMotor motorNafta = new MotorNaftero();
            Console.Write("MOTOR NAFTA");
            Console.WriteLine("ARRANCO");
            Console.WriteLine(motorNafta.Arrancar());
            Console.WriteLine("Apagar");
            Console.WriteLine(motorNafta.Apagar());
            Console.WriteLine("Acelerar");
            Console.WriteLine(motorNafta.Acelerar());

            MotorElectricoAdapter motorDiesel = new MotorDiesel();
            Console.Write("MOTOR Diesel");
            Console.WriteLine("ARRANCO");
            Console.WriteLine(motorDiesel.Arrancar());
            Console.WriteLine("Apagar");
            Console.WriteLine(motorDiesel.Apagar());
            Console.WriteLine("Acelerar");
            Console.WriteLine(motorDiesel.Acelerar());

            IMotor motorElectrico = new MotorElectricoAdapter();
            Console.Write("MOTOR Electrico");
            Console.WriteLine("ARRANCO");
            Console.WriteLine(motorElectrico.Arrancar());
            Console.WriteLine("Apagar");
            Console.WriteLine(motorElectrico.Apagar());
            Console.WriteLine("Acelerar");
            Console.WriteLine(motorElectrico.Acelerar());
        }
    }

    public interface IMotor
    {
        public string Arrancar();

        public string Apagar();

        public string Acelerar();
    }

    public class MotorNaftero : IMotor
    {
        public string Acelerar()
        {
            return "acelero el motorNaftero";
        }

        public string Apagar()
        {
            return "Apago el motorNaftero";
        }

        public string Arrancar()
        {
            return "Arranco el motorNaftero";
        }
    }

    public class MotorDiesel : IMotor
    {
        public string Acelerar()
        {
            return "acelero el motorNaftero";
        }

        public string Apagar()
        {
            return "Apago el motorNaftero";
        }

        public string Arrancar()
        {
            return "Arranco el motorNaftero";
        }
    }

    public class MotorElectricoAdapter : IMotor
    {
        private MotorElectrico motorElectrico = new MotorElectrico();

        public string Acelerar()
        {
            string result;
            result = motorElectrico.prenderMotor();
            result += " " + motorElectrico.activarMotor();

            return result;
        }

        public string Apagar()
        {
            string result;
            result = motorElectrico.desactivoMotor();
            result += "  " + motorElectrico.apagoMotor();
            return result;
        }

        public string Arrancar()
        {
            string result;
            result = motorElectrico.masPotencia();
            result += motorElectrico.acelerar();
            return result;
        }
    }

    public class MotorElectrico
    {
        public string prenderMotor()
        {
            return "prendo el motor";
        }

        public string activarMotor()
        {
            return "activo el motor para el uso";
        }

        public string desactivoMotor()
        {
            return "preparo para apagar el motor electrico";
        }

        public string apagoMotor()
        {
            return "apago el motor electrico";
        }

        public string masPotencia()
        {
            return "le paso mas energia al motor electrico";
        }

        public string acelerar()
        {
            return "Acelero el automovil electrico";
        }
    }
}