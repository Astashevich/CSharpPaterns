using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsobility
{
    internal class Carpenters : AbsWorker
    {
        public override string Execute(string command)
        {
            if (command == "класть кирпич") return $"Плотник выполнил команду: {command}";
            else return base.Execute(command);
        }
    }
}
