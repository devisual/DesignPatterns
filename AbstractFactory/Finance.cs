using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class Finance : IDepartment
    {
        public string GetName()
        {
            return "Finance Department";
        }
    }
}
