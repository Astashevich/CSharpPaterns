namespace Decorator
{
    internal class Encyptor : Shell
    {
        public Encyptor(IProcessor pr) : base(pr) { }

        public override void Process()
        {
            Console.WriteLine("Data encryption->");
            _processor.Process();
        }
    }
}
