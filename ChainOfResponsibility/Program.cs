using ChainOfResponsobility;

void GiveCommand(IWorker worker, string command)
{
    string str = worker.Execute(command);

    if (str == "") Console.WriteLine($"{command} - никто не умеет делать");
    else Console.WriteLine(str);
}

Designer designer = new();
Carpenters carpenters = new();
FinishingWorker finishingWorker = new();

designer.SetNextWorker(carpenters).SetNextWorker(finishingWorker);

GiveCommand(designer, "спроектировать дом");
GiveCommand(designer, "класть кирпич");
GiveCommand(designer, "клеить обои");

GiveCommand(designer, "провести проводку");

