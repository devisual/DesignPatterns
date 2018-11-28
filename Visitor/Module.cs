using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    abstract class Module
    {
        public abstract bool VisitUser(StandardUser standardUser);
        public abstract bool VisitUser(SuperUser superUser);
        public abstract bool VisitUser(ExternalUser externalUser);
    }
}
