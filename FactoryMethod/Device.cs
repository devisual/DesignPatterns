using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    abstract class Device
    {
        public abstract string Name { get; }
        public abstract decimal GetDevicePrice();
    }
}
