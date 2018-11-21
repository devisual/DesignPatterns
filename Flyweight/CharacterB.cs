using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyweightPattern
{
    class CharacterB : Character
    {
        public override string Name { get; set; }
        public override double Width { get; set; }
        public override double Height { get; set; }
        public CharacterB()
        {
            Name = "B";
            Width = 1;
            Height = 1.1;
        }
    }
}
