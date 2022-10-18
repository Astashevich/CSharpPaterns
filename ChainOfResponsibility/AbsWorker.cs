using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsobility
{
    abstract class AbsWorker : IWorker
    {
        private IWorker nextWorker;

        public AbsWorker() => nextWorker = null;

        public IWorker SetNextWorker(IWorker worker)
        {
            nextWorker = worker; 
            return nextWorker;
        }

        public virtual string Execute(string command)
        {
            if(nextWorker != null) return nextWorker.Execute(command);
            return string.Empty;
        }
    }
}
