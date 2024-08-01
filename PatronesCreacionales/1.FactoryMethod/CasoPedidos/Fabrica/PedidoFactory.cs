using PatronesCreacionales._1.FactoryMethod.CasoPedidos.Concretas;

namespace PatronesCreacionales._1.FactoryMethod.CasoPedidos.Fabrica
{
    public class PedidoFactory : IPedidoFactory
    {
        public IPedido? CrearPedido(string tipo)
        {
            IPedido result = null;
            switch (tipo.ToLower())
            {
                case "digital":
                    result = new PedidoProductoDigital();
                    break;

                case "fisico":

                    result = new PedidoProductoFisico();
                    break;

                case "suscripcion":
                    result = new PedidoSubscripcion();
                    break;
            }
            return result;
        }
    }
}