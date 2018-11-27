using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    class Window
    {
        private MaterialType _material;
        private double _height;
        private double _width;
        public Window(MaterialType material, double height, double width)
        {
            _material = material;
            _height = height;
            _width = width;
        }
        public void Produce()
        {
            Console.WriteLine($"I'm producing window made of {_material} with height {_height} and width {_width}");
        }
    }
}
