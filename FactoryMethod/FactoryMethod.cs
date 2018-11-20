using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    class FactoryMethod
    {
        public static Device GetDevice(short id)
        {
            switch(id)
            {
                case 1:
                    return new MobilePhone();
                case 2:
                    return new TVSat();
                case 3:
                    return new WashingMachine();
                default:
                    return null;
            }
        }
    }
}
