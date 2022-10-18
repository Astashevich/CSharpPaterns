namespace Decorator
{
    public class Transmitter : IProcessor
    {
        private string data;

        public Transmitter(string data) => this.data = data;

        public void Process() => Console.WriteLine($"{data} data is transmitted over a communication channel");
    }
}
