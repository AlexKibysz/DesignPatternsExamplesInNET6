namespace PatronesCombinados.SimplerCompositeIterator.Component
{
    public interface IComponent
    {
        string Nombre { get; set; }
        void Mostrar(int profundidad);
    }
}
