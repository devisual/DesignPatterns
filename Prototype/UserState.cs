using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    abstract class UserState : ICloneable
    {
        public string UserName { get; set; }
        public Point UserLocation { get; set; }
        public Point UserWeaponLocation { get; set; }
        public abstract object Clone();
    }
}
