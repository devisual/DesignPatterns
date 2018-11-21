using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{    
    /// <summary>
    /// Concrete implementation if user wants to add reversing sensor to base car option
    /// </summary>
    class ReversingSensorDecorator : Decorator
    {
        public ReversingSensorDecorator(CarComponent component) : base(component)
        {
            _price = 5390;
            _name = "Reversing Sensor";
        }
    }
}
