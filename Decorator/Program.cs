using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class Program
    {
        /// <summary>
        /// Example of usage decorator design pattern. In this example we configure car with options and get its price.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            if (GetAnswear("Do you want to buy a car?"))
            {
                Car car = new Car();
                Decorator decorator = null;
                Console.WriteLine($"{car.GetName()} has been created with price {car.GetPrice()}");

                if(GetAnswear("Do you want a navigation?"))
                {
                    decorator = new NavigationDecorator(car);
                    Console.WriteLine($"{decorator.GetName()} has been added. Total price is now {decorator.GetPrice()}.");
                }
                if (GetAnswear("Do you want a reversing sensor?"))
                {
                    decorator = new ReversingSensorDecorator((CarComponent)decorator??car);
                    Console.WriteLine($"{decorator.GetName()} has been added. Total price is now {decorator.GetPrice()}.");
                }
                if (GetAnswear("Do you want heated seats?"))
                {
                    decorator = new HeatedSeatsDecorator((CarComponent)decorator ?? car);
                    Console.WriteLine($"{decorator.GetName()} has been added. Total price is now {decorator.GetPrice()}.");
                }
                if (GetAnswear("Do you want an air conditioner?"))
                {
                    decorator = new AirConditioningDecorator((CarComponent)decorator ?? car);
                    Console.WriteLine($"{decorator.GetName()} has been added. Total price is now {decorator.GetPrice()}.");
                }
                Console.ReadKey();
            }    
        }
        static bool GetAnswear(string question)
        {
            Console.Write($"{question} [y/n]");
            ConsoleKey answear = Console.ReadKey(false).Key;
            Console.WriteLine();
            return (answear == ConsoleKey.Y);
        }
    }
}
