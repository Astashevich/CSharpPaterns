using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsobility
{
    internal class Designer : AbsWorker
    {
        public override string Execute(string command)
        {
            if (command == "спроектировать дом") return $"Проектировщик выполнил команду: {command}";
            else return base.Execute(command);
        }
    }
}
