using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    class Station2 : Module
    {
        public override bool VisitUser(StandardUser standardUser)
        {
            Console.WriteLine("Standard user doesn't have rights to access Station2");
            return false;
        }

        public override bool VisitUser(SuperUser superUser)
        {
            Console.WriteLine("Super user has rights to access Station2");
            return true;
        }

        public override bool VisitUser(ExternalUser externalUser)
        {
            Console.WriteLine("External user has rights to access Station2");
            return true;
        }
    }
}
