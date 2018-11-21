using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyweightPattern
{
    abstract class Character
    {
        public abstract string Name { get; set; }
        public abstract double Width { get; set; }
        public abstract double Height { get; set; }

    }  
}
