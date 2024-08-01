using PatronesComportamiento._9.TemplateMethod.AbstractTemplate;

namespace PatronesComportamiento
{
    public class TemplateMethod
    {
        public void ejecutarCliente()
        {
            PedidoProductoFisico pedidoProductoFisico = new PedidoProductoFisico();

            pedidoProductoFisico.ProcesarPedido();

            Console.WriteLine("--------------------------------------------------");

            PedidoSuscripcion pedidoSuscripcion = new PedidoSuscripcion();

            pedidoSuscripcion.ProcesarPedido();

            Console.WriteLine("--------------------------------------------------");

            PedidoDigital pedidoDigital = new PedidoDigital();

            pedidoDigital.ProcesarPedido();
        }
    }
}