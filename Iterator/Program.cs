using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    class Program
    {
        static void Main(string[] args)
        {
            Aggregation a = new Aggregation();
            a[0] = "Ann";
            a[1] = "Sam";
            a[2] = "John";
            a[3] = "Mandy";

            IIterator iterator = a.Iterator();
            for(string name = iterator.First(); iterator.IsFinished() == false; name = iterator.Next())
            {
                Console.WriteLine(name);
            }
            Console.ReadKey();
        }
    }
}
