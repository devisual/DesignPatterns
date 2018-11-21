using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{    
    /// <summary>
    /// Concrete implementation if user wants to add navigation to base car option
    /// </summary>
    class NavigationDecorator : Decorator
    {
        public NavigationDecorator(CarComponent component) : base(component)
        {
            _price = 4500M;
            _name = "Navigation";
        }
    }
}
