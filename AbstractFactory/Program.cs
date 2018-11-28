using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            DepartmentAssignment assignmentFinance = new DepartmentAssignment(new DepartmentFinanceFactory());
            assignmentFinance.GetInformationAboutDepartmentWorker();

            DepartmentAssignment assignmentHR = new DepartmentAssignment(new DepartmentHumanResourcesFactory());
            assignmentHR.GetInformationAboutDepartmentWorker();

            DepartmentAssignment assignmentIT = new DepartmentAssignment(new DepartmentITFactory());
            assignmentIT.GetInformationAboutDepartmentWorker();

            Console.ReadKey();
        }
    }
}
