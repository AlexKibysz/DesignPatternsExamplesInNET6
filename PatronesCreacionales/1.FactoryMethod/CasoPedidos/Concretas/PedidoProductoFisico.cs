namespace PatronesCreacionales._1.FactoryMethod.CasoPedidos.Concretas
{
    public class PedidoProductoFisico : IPedido
    {
        public string procesarPedido()
        {
            return "Proceso el pedido enviando por correo el producto fisico...";
        }
    }
}