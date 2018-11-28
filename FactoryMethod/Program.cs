using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            DeviceFactory factory = new MobilePhoneFactory();
            Device _device = factory.GetDevice();
            Console.WriteLine($@"{_device.Name} has price {_device.GetDevicePrice()}.");
            Console.ReadKey();
        }
    }
}
