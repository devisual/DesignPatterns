using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    class TVSat : Device
    {
        public override string Name => "TV Sat";

        public override decimal GetDevicePrice()
        {
            return 1300;
        }
    }
}
