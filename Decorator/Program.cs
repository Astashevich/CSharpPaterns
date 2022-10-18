using Decorator;

Console.WriteLine("Hello, World!");

IProcessor transmitter = new Transmitter("12345");
transmitter.Process();
Console.WriteLine();

Shell hammingCoder = new HammingCoder(transmitter);
hammingCoder.Process();
Console.WriteLine();

Shell encoder = new Encyptor(hammingCoder);
encoder.Process();
