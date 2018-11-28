using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class DepartmentHumanResourcesFactory : DepartmentAssignmentFactory
    {
        public override IDepartment GetDepartment()
        {
            return new HumanResources();
        }

        public override IWorker GetWorker()
        {
            return new John();
        }
    }
}
