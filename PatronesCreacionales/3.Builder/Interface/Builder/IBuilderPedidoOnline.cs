using PatronesCreacionales._3.Builder.Product;

namespace PatronesCreacionales._3.Builder.ConcreteBuilder
{
    public interface IBuilderPedidoOnline
    {
        void agregarArticulo(Articulos articulo);

        void cargarDatosBasicosPedido(int idPedido, DateTime fechaPedido);

        void cargarDireccionPedido(string calle, int codigoPostal, string provincia);

        void crearNuevoPedido();

        Pedido ObtenerPedido();
    }
}