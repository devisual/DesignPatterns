using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    class MobilePhone : Device
    {
        public override string Name => "Mobile Phone";

        public override decimal GetDevicePrice()
        {
            return 100.5M;
        }
    }
}
