using Builder.Enums;

namespace Builder
{
    /// <summary>
    /// Concrete builder
    /// </summary>
    class LogHouseBuilder : IHouseBuilder
    {
        House logHouse = new House();
        public void CreateFoundations()
        {
            logHouse.Foundations = "Foundations for LogHouse";
        }
        public void CreateWalls()
        {
            logHouse.WallType = WallType.Wood;
        }
        public void CreateRoof()
        {
            logHouse.RoofType = RoofType.Tile;
        }
        public void CreateWindow()
        {
            logHouse.WindowType = WindowType.Wooden;
        }

        public House GetCreatedHouse()
        {
            return logHouse;
        }
    }
}
