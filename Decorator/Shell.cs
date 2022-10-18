using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    /// <summary>
    /// Decorator.
    /// </summary>
    abstract class Shell : IProcessor
    {
        protected IProcessor _processor;

        public Shell(IProcessor processor) => _processor = processor;

        public virtual void Process() => _processor.Process();
    }
}
