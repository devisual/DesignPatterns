using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    class FinishedState : IPrinterState
    {
        public void Print()
        {
            Console.WriteLine("Printing is finished...");
        }
    }
}
