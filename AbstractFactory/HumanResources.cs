using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class HumanResources : IDepartment
    {
        public string GetName()
        {
            return "Human Resources Department";
        }
    }
}
