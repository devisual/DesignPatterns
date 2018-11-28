using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    class Station1 : Module
    {
        public override bool VisitUser(StandardUser standardUser)
        {
            Console.WriteLine("Standard user has rights to access Station1");
            return true;
        }

        public override bool VisitUser(SuperUser superUser)
        {
            Console.WriteLine("Super user has rights to access Station1");
            return true;
        }

        public override bool VisitUser(ExternalUser externalUser)
        {
            Console.WriteLine("External user doesn't have rights to access Station1");
            return false;
        }
    }
}
