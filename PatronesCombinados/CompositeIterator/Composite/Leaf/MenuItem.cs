namespace PatronesCombinados.CompositeIterator.Composite.Leaf
{
    // Implementación concreta de MenuItem
    public class MenuItem : IMenuItem
    {
        private string Name { get; set; }
        private string Description { get; set; }
        private bool isVeggy { get; set; }
        private double Price { get; set; }

        public MenuItem(string name, string description, bool isVeggy, double price)
        {
            Name = name;
            Description = description;
            this.isVeggy = isVeggy;
            Price = price;
        }

        public string getName() => Name;
        public string getDescription() => Description;
        public bool isVegetarian() => isVeggy;
    }
}
