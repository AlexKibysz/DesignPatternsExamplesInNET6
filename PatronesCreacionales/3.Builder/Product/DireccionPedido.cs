namespace PatronesCreacionales._3.Builder.Product
{
    public class DireccionPedido
    {
        public DireccionPedido(string calle, int codigoPostal, string provincia)
        {
            this.calle = calle;
            this.provincia = provincia;
            this.codigoPostal = codigoPostal;
        }

        public string calle { get; set; }

        public int codigoPostal { get; set; }

        public string provincia { get; set; }
    }
}