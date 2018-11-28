using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    abstract class DepartmentAssignmentFactory
    {
        public abstract IDepartment GetDepartment();
        public abstract IWorker GetWorker();
    }
}
