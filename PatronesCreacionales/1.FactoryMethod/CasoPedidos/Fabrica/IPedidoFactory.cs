namespace PatronesCreacionales._1.FactoryMethod.CasoPedidos.Fabrica
{
    public interface IPedidoFactory
    {
        IPedido CrearPedido(string tipo);
    }
}