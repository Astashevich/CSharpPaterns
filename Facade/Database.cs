using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    internal class Database
    {
        public void Insert() => Console.WriteLine("Запись в базу данных");
        public void Delete() => Console.WriteLine("Удаление из базы данных");
    }
}
