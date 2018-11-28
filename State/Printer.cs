using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    class Printer
    {
        public IPrinterState State;
        public short PrintPages;
        public Printer(short printPages)
        {
            PrintPages = printPages;
            if (printPages > 0)
                State = new ReadyState(this);
            else
                State = new FinishedState();
        }
        public void Print()
        {
            State.Print();
        }

    }
}
