using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    class ReadyState : IPrinterState
    {
        private Printer _printer;
        public ReadyState(Printer printer)
        {
            _printer = printer;
        }
        public void Print()
        {
            if (_printer.PrintPages > 0)
            {
                Console.WriteLine("Printing page...");
                _printer.PrintPages--;
            }
            if(_printer.PrintPages == 0)
            {
                _printer.State = new FinishedState();
            }
        }
    }
}
