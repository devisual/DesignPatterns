using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    class FamilyMember : IFamilyMember
    {
        string _name;
        string _surname;
        string _kindship;
        public FamilyMember(string name, string surname, string kindship)
        {
            _name = name;
            _surname = surname;
            _kindship = kindship;
        }
        public void DisplayName()
        {
            Console.WriteLine(_name + " " + _surname + " " + _kindship);
        }
    }
}
