using Builder.Enums;

namespace Builder
{
    /// <summary>
    /// Concrete Bulder
    /// </summary>
    class BrickHouseBuilder : IHouseBuilder
    {
        private House brickHouse = new House();
        public void CreateFoundations()
        {
            brickHouse.Foundations = "Foundations for BrickHouse";
        }
        public void CreateWalls()
        {
            brickHouse.WallType = WallType.AirBrick;
        }
        public void CreateRoof()
        {
            brickHouse.RoofType = RoofType.Plate;
        }
        public void CreateWindow()
        {
            brickHouse.WindowType = WindowType.Plastic;
        }

        public House GetCreatedHouse()
        {
            return brickHouse;
        }
    }
}
