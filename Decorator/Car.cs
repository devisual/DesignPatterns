using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class Car : CarComponent
    {
        /// <summary>
        /// Base option of car implementing car component
        /// </summary>
        /// <returns></returns>
        public override string GetName()
        {
            return "Car";
        }

        public override decimal GetPrice()
        {
            return 50000M;
        }
    }
}
