using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class DepartmentFinanceFactory : DepartmentAssignmentFactory
    {
        public override IDepartment GetDepartment()
        {
            return new Finance();
        }

        public override IWorker GetWorker()
        {
            return new Sam();
        }
    }
}
