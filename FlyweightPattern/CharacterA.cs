using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyweightPattern
{
    class CharacterA : Character
    {
        public override string Name { get; set; }
        public override double Width { get; set; }
        public override double Height { get; set; }
        public CharacterA()
        {
            Name = "A";
            Width = 0.6;
            Height = 1.1;
        }
    }
}
