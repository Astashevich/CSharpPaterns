using Prototype;

Console.WriteLine("Hello, World!");

IAnimal sheepDonor = new Sheep();
sheepDonor.SetName("Dolly");

IAnimal sheepClone = sheepDonor.Clone();

Console.WriteLine(sheepDonor.GetName());
Console.WriteLine(sheepClone.GetName());
