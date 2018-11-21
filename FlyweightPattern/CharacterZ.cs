using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyweightPattern
{
    class CharacterZ : Character
    {
        public override string Name { get; set; }
        public override double Width { get; set; }
        public override double Height { get; set; }
        public CharacterZ()
        {
            Name = "Z";
            Width = 0.9;
            Height = 1.1;
        }
    }
}
