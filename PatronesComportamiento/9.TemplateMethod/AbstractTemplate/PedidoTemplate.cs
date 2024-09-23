namespace PatronesComportamiento._9.TemplateMethod.AbstractTemplate
{
    public abstract class PedidoTemplate
    {
        public void ProcesarPedido()
        {
            validacionDatoCliente();
            procesamientoPago();
            Entrega();
            ConfirmacionCliente();
            Console.WriteLine("------pedido procesado correctamente-----");
        }

        public void validacionDatoCliente()
        {
            Console.WriteLine("Validando datos Cliente...");
        }


        public abstract void procesamientoPago();



        public abstract void Entrega();


        public abstract void ConfirmacionCliente();


    }


    public class PedidoProductoFisico : PedidoTemplate
    {
        public override void ConfirmacionCliente()
        {
            Console.WriteLine("Confirmacion con cliente del producto fisico...");
        }

        public override void Entrega()
        {
            generarEmpaquetado();
            Console.WriteLine("Confirmacion con cliente de la entrega del producto fisico...");
            GestionMensajeria();
        }

        private void GestionMensajeria()
        {
            Console.WriteLine("Se gestiona el envio por mensajeria");
        }

        private void generarEmpaquetado()
        {
            Console.WriteLine("Se genera el empaquetado y etiquetado...");

        }

        public override void procesamientoPago()
        {
            calculoCostoEnvio();
            Console.WriteLine("Procesando el pago del producto fisico...");
        }

        private void calculoCostoEnvio()
        {
            Console.WriteLine("Se calcula el costo de envio...");
        }




    }

    public class PedidoDigital : PedidoTemplate
    {
        public override void ConfirmacionCliente()
        {
            Console.WriteLine("Confirmacion con cliente del producto digital...");
        }

        public override void Entrega()
        {
            Console.WriteLine("envio de correo con enlaces de descarga..." + generarEnlaces());
        }

        public string generarEnlaces()
        {
            return "LinkEnlacePedido";
        }

        public override void procesamientoPago()
        {
            Console.WriteLine("Procesando el pago del producto digital...");
        }


    }

    public class PedidoSuscripcion : PedidoTemplate
    {
        public override void ConfirmacionCliente()
        {
            Console.WriteLine("Confirmacion con cliente de la suscripcion...");
        }

        public override void Entrega()
        {
            RegistroDelClienteServicio();
            Console.WriteLine("envio de correo con enlaces de descarga del servicio de suscripcion...");
        }

        private void RegistroDelClienteServicio()
        {
            Console.WriteLine("Se registra el cliente del servicio");
        }

        public override void procesamientoPago()
        {
            ConfiguracionPagoRecurrente();
            Console.WriteLine("Procesando el pago de la suscripcion...");
        }

        private void ConfiguracionPagoRecurrente()
        {
            Console.WriteLine("Se configura el pago recurrente...");
        }

    }
}
