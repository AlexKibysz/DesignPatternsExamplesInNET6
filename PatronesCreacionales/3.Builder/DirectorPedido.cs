using PatronesCreacionales._3.Builder.ConcreteBuilder;
using PatronesCreacionales._3.Builder.Product;

namespace PatronesCreacionales._3.Builder
{
    public class DirectorPedido
    {
        private IBuilderPedidoOnline _pedidoBuilder;

        public DirectorPedido(IBuilderPedidoOnline pedidoBuilder)
        {
            _pedidoBuilder = pedidoBuilder;
        }

        public void ConstruirPedido(int id, DateTime fecha, DireccionPedido direccion, List<Articulos> articulos)
        {
            _pedidoBuilder.crearNuevoPedido();

            _pedidoBuilder.cargarDatosBasicosPedido(id, fecha);

            _pedidoBuilder.cargarDireccionPedido(direccion.calle, direccion.codigoPostal, direccion.provincia);

            foreach (var articulo in articulos)
            {
                _pedidoBuilder.agregarArticulo(articulo);
            }

            Console.WriteLine(_pedidoBuilder.ObtenerPedido());

            Console.Read();
        }
    }
}