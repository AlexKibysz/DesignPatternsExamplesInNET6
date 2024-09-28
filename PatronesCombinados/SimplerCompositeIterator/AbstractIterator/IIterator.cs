namespace PatronesCombinados.SimplerCompositeIterator.AbstractIterator
{
    public interface IIterador<T>
    {
        bool TieneSiguiente();
        T Siguiente();
    }
}
