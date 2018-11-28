using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    class Program
    {
        static void Main(string[] args)
        {
            UserStructure structure = new UserStructure();
            structure.Add(new StandardUser());
            structure.Add(new SuperUser());
            structure.Add(new ExternalUser());

            Module m1 = new Station1();
            Module m2 = new Station2();

            structure.Accept(m1);
            structure.Accept(m2);
            Console.ReadKey();
        }
    }
}
