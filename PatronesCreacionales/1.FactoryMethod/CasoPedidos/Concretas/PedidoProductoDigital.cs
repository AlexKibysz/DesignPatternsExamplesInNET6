namespace PatronesCreacionales._1.FactoryMethod.CasoPedidos.Concretas
{
    public class PedidoProductoDigital : IPedido
    {
        public string procesarPedido()
        {
            return "Proceso El pedido de producto digital dando llaves de producto...";
        }
    }
}