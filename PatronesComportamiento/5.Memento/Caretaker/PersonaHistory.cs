namespace PatronesComportamiento._5.Memento.Caretaker
{
    public class PersonaHistory
    {
        private List<MementoPersona> _mementos = new List<MementoPersona>();

        public void AddMementos(MementoPersona m)
        {
            _mementos.Add(m);
        }

        public MementoPersona getMemento(int index)
        {
            return _mementos[index];
        }
    }
}