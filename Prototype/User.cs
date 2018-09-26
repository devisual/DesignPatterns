using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    class User : UserState
    {
        public override object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
