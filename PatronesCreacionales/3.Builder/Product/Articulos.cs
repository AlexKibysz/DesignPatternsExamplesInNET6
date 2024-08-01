namespace PatronesCreacionales._3.Builder.Product
{
    public class Articulos
    {
        public Articulos(int idArticulo, string nombreArticulo, string descripcionArticulo, decimal Precio)
        {
            this.descripcionArticulo = descripcionArticulo;
            this.idArticulo = idArticulo;
            this.nombreArticulo = nombreArticulo;
            this.Precio = Precio;
        }

        public int idArticulo { get; set; }

        public string nombreArticulo { get; set; }

        public string descripcionArticulo { get; set; }

        public decimal Precio { get; set; }
    }
}