namespace Prototype
{
    internal interface IAnimal
    {
        void SetName(string name);
        string GetName();
        IAnimal Clone();
    }
}
