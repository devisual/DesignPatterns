using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    /// <summary>
    /// Builder
    /// </summary>
    interface IHouseBuilder
    {
        void CreateFoundations();
        void CreateWalls();
        void CreateRoof();
        void CreateWindow();
        House GetCreatedHouse();
    }
}
