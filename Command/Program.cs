using System;

namespace Command
{
    /// <summary>
    /// Example of command pattern usage. Customer orders elements to the house in the shop. The shop tell the producer
    /// to produce elements.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            ///We are in the shop. Customer orders elements.
            Console.WriteLine("Customer wants to order door to the house");

            Producer producer = new Producer(); //we create Producer instance.
            Door door = new Door(MaterialType.Plastic, 210, 90); // we create order for producer
            ProduceDoorCommand produce = new ProduceDoorCommand(door); // prepare command which connects producer with order
            producer.Command = produce;
            producer.Produce(); //producer procudes element. We don't need to know how it is produced. We only want to get our order.

            Console.WriteLine("Now customer wants to order two windows to the house");
            Window window1 = new Window(MaterialType.Wood, 150, 170);
            Window window2 = new Window(MaterialType.Wood, 150, 195);
            ProduceWindowCommand produceW = new ProduceWindowCommand(new Window[] { window1, window2 });
            producer.Command = produceW;
            producer.Produce();
            Console.ReadKey();
        }
    }
}
