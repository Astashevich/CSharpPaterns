using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    internal class Site
    {
        public void Placement() => Console.WriteLine("Размещение на сайте");
        public void Del() => Console.WriteLine("Удаление с сайта");
    }
}
