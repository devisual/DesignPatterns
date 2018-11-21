using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            IWeight weight = null;
            Console.Write($"Którą wagę chcesz uruchomić [R/S]");
            ConsoleKey answear = Console.ReadKey(false).Key;
            Console.WriteLine();
            if (answear == ConsoleKey.R)
                weight = new Weight();
            else if (answear == ConsoleKey.S)
                weight = new WeightSerialPortAdapter();

            if(weight != null)
            {
                weight.SetTare(2);
                weight.SetWeight(3.5);
                Console.WriteLine($"Gross weight equals {weight.GetTare() + weight.GetWeight()}");
                Console.ReadKey();
            }
        }
    }
}
