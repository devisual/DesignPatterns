using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    /// <summary>
    /// State pattern example. We use this pattern when we want to change object behavior because state has been changed.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Printer printer = new Printer(10);

            for(int i = 1; i<=12; i++)
            {
                printer.Print();
            }
            Console.ReadKey();

        }
    }
}
