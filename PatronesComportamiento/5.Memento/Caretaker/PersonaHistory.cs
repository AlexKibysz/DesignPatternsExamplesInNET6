namespace PatronesComportamiento._5.Memento.Caretaker
{
    public class PersonaHistory
    {
        private readonly List<MementoPersona> _mementos = new List<MementoPersona>();

        public void AddMemento(MementoPersona m)
        {
            _mementos.Add(m);
        }

        public MementoPersona GetMemento(int index)
        {
            return _mementos[index];
        }
    }
}