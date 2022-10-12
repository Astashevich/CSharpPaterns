namespace Prototype
{
    internal class Sheep : IAnimal
    {
        private string _name;

        public Sheep() { }

        private Sheep(Sheep donor) => _name = donor._name;
        
        public void SetName(string name) => _name = name;

        public string GetName() => _name;

        public IAnimal Clone() => new Sheep(this);
    }
}
