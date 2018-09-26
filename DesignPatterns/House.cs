using Builder.Enums;
using System;

namespace Builder
{
    /// <summary>
    /// product
    /// </summary>
    class House
    {
        public RoofType RoofType { get; set; }
        public WallType WallType { get; set; }
        public WindowType WindowType { get; set; }
        public string Foundations { get; set; }

        public void ShowHouse()
        {
            Console.WriteLine(string.Format("House with roof {0}, walltype {1} and windowtype {2}", RoofType, WallType, WindowType));
            Console.ReadKey();
        }
    }
}
