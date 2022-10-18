using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    internal class HammingCoder : Shell
    {
        public HammingCoder(IProcessor pr) : base(pr) { }

        public override void Process()
        {
            Console.WriteLine("Error-correcting Hamming code superimposed->");
            _processor.Process();
        }
    }
}
