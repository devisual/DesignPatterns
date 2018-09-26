using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            FamilyMember mom = new FamilyMember("Jenny", "Smith", "mom");
            FamilyMember dad = new FamilyMember("Tom", "Smith", "dad");
            FamilyMember sister = new FamilyMember("Mandy", "Smith", "sister");
            FamilyMember grandma = new FamilyMember("Alice", "Smith", "grandma");

            FamilySon son = new FamilySon("Andy", "Smith");
            son.AddFamilyMember(mom);
            son.AddFamilyMember(dad);
            son.AddFamilyMember(sister);
            son.AddFamilyMember(grandma);

            son.DisplayName();
            Console.ReadKey();
        }
    }
}
