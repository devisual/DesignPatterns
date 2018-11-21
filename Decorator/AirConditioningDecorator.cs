using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    /// <summary>
    /// Concrete implementation if user wants to add air conditioning to base car option
    /// </summary>
    class AirConditioningDecorator : Decorator
    {
        public AirConditioningDecorator(CarComponent component) : base(component)
        {
            _price = 2500M;
            _name = "Air conditioner";
        }
    }
}
