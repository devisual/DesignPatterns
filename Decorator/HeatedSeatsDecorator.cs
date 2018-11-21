using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    /// <summary>
    /// Concrete implementation if user wants to add heated seats to base car option
    /// </summary>
    class HeatedSeatsDecorator : Decorator
    {
        public HeatedSeatsDecorator(CarComponent component) : base (component)
        {
            _price = 5500M;
            _name = "Heated Seats";
        }
    }
}
