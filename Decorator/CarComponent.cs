using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    /// <summary>
    /// interface of functionallity
    /// </summary>
    public abstract class CarComponent
    {
        public abstract string GetName();
        public abstract decimal GetPrice();
    }
}
