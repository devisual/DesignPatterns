using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    class WashingMachine : Device
    {
        public override string Name => "Washing Machine";

        public override decimal GetDevicePrice()
        {
            return 850.9M;
        }
    }
}
