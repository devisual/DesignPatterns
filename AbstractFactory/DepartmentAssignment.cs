using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class DepartmentAssignment
    {
        DepartmentAssignmentFactory _factory;
        public DepartmentAssignment(DepartmentAssignmentFactory factory)
        {
            _factory = factory;
        }
        public void GetInformationAboutDepartmentWorker()
        {
            IDepartment department = _factory.GetDepartment();
            IWorker worker = _factory.GetWorker();
            Console.WriteLine($"{worker.GetName()} works in {department.GetName()}");
        }
    }
}
