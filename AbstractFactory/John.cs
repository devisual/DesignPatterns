using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class John : IWorker
    {
        public string GetName()
        {
            return "John Smith";
        }
    }
}
