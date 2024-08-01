namespace PatronesCreacionales._3.Builder.Product
{
    public class Pedido
    {
        public Pedido()
        { }

        public int idPedido { get; set; }

        public DateTime fechaPedido { get; set; }

        public DireccionPedido? direccionPedido { get; set; }

        public List<Articulos> ListaArticulos { get; set; }

        public void imprimir()
        {
            Console.WriteLine(this.ToString());
        }
    }
}