using PatronesCreacionales._3.Builder.Product;

namespace PatronesCreacionales._3.Builder.ConcreteBuilder
{
    public class BuilderPedidoOnline : IBuilderPedidoOnline
    {
        private Pedido _pedido;

        public void crearNuevoPedido()
        {
            _pedido = new Pedido();
        }

        public void cargarDireccionPedido(string calle, int codigoPostal, string provincia)
        {
            _pedido.direccionPedido = new DireccionPedido(calle, codigoPostal, provincia);
        }

        public void cargarDatosBasicosPedido(int idPedido, DateTime fechaPedido)
        {
            _pedido.idPedido = idPedido;
            _pedido.fechaPedido = fechaPedido;
        }

        public void agregarArticulo(Articulos articulo)
        {
            _pedido.ListaArticulos = new List<Articulos>();
            _pedido.ListaArticulos.Add(articulo);
        }

        public Pedido ObtenerPedido()
        {
            Console.WriteLine("SE MUESTRA INFORMACION PEDIDO");

            _pedido.imprimir();

            return _pedido;
        }
    }
}