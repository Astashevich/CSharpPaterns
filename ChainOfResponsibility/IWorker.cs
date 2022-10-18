using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsobility
{
    internal interface IWorker
    {
        IWorker SetNextWorker(IWorker worker);
        string Execute(string command);
    }
}
