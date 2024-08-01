namespace PatronesCreacionales._1.FactoryMethod.CasoPedidos.Concretas
{
    public class PedidoSubscripcion : IPedido
    {
        public string procesarPedido()
        {
            return "Proceso el pedido dandole las credenciales de login al usuario...";
        }
    }
}