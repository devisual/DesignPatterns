using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class DepartmentITFactory : DepartmentAssignmentFactory
    {
        public override IDepartment GetDepartment()
        {
            return new IT();
        }

        public override IWorker GetWorker()
        {
            return new Mandy();
        }
    }
}
