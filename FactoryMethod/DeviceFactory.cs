using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    abstract class DeviceFactory
    {
        public abstract Device GetDevice();
    }
}
