using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    /// <summary>
    /// Decorator class
    /// </summary>
    public abstract class Decorator : CarComponent
    {
        CarComponent _component = null;
        protected decimal _price = 0;
        protected string _name = "Undefined";
        protected Decorator(CarComponent component)
        {
            _component = component;
        }
        public override string GetName()
        {
            return string.Format($"{_name} / {_component.GetName()}");
        }

        public override decimal GetPrice()
        {
            return _price + _component.GetPrice();
        }
    }
}
