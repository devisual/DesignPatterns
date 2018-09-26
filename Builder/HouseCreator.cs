using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    /// <summary>
    /// Director
    /// </summary>
    class HouseCreator
    {
        public void GetHouse(IHouseBuilder brickHouseBuilder)
        {
            brickHouseBuilder.CreateFoundations();
            brickHouseBuilder.CreateWalls();
            brickHouseBuilder.CreateWindow();
            brickHouseBuilder.CreateRoof();
        }
    }
}
