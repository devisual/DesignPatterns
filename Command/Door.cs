using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    class Door
    {
        private MaterialType _material;
        private double _height;
        private double _width;
        public Door(MaterialType material, double height, double width)
        {
            _material = material;
            _height = height;
            _width = width;
        }
        public void Produce()
        {
            Console.WriteLine($"I'm producing door made of {_material} with height {_height} and width {_width}");
        }
    }
}
