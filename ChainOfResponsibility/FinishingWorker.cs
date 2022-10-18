using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsobility
{
    internal class FinishingWorker : AbsWorker
    {
        public override string Execute(string command)
        {
            if (command == "клеить обои") return $"Рабочий внутренней отделки выполнил команду: {command}";
            else return base.Execute(command);
        }
    }
}
