using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    class TVFactory : DeviceFactory
    {
        public override Device GetDevice()
        {
            return new TVSat();
        }
    }
}
