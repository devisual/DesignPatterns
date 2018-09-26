using System;

namespace Builder
{
    /// <summary>
    /// Example of builder usage. We build house
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            IHouseBuilder BrickHouseBuilder = new BrickHouseBuilder();
            IHouseBuilder LogHouseBuilder = new LogHouseBuilder();
            HouseCreator creator = new HouseCreator();

            creator.GetHouse(BrickHouseBuilder);
            creator.GetHouse(LogHouseBuilder);

            House brickHouse = BrickHouseBuilder.GetCreatedHouse();
            House logHouse = LogHouseBuilder.GetCreatedHouse();

            brickHouse.ShowHouse();
            logHouse.ShowHouse();
            Console.ReadKey();




        }
    }
}
