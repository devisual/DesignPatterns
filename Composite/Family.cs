using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    class FamilySon : IFamilyMember
    {
        string _name;
        string _surname;
        public FamilySon(string name, string surname)
        {
            _name = name;
            _surname = surname;
        }
        public void AddFamilyMember(IFamilyMember member)
        {
            familyMembers.Add(member);
        }
        private List<IFamilyMember> familyMembers = new List<IFamilyMember>();
        public void DisplayName()
        {
            Console.WriteLine(_name + " family members");
           foreach (IFamilyMember familyMember in familyMembers)
            {
                familyMember.DisplayName();
            }
        }
    }
}
