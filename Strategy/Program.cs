using System;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 2;
            Console.WriteLine("Sum value - {0}", GetStrategy(CalculationType.Sum).Calculate(a, b));
            Console.ReadKey();
            Console.WriteLine("Diff value - {0}", GetStrategy(CalculationType.Diff).Calculate(a, b));
            Console.ReadKey();
            Console.WriteLine("Multiple value - {0}", GetStrategy(CalculationType.Multiple).Calculate(a, b));
            Console.ReadKey();
            Console.WriteLine("Divide value - {0}", GetStrategy(CalculationType.Divide).Calculate(a, b));
            Console.ReadKey();

        }
        public static ICalculateStrategy GetStrategy(CalculationType type)
        {
            switch (type)
            {
                case CalculationType.Diff:
                    return new DiffStrategy();
                case CalculationType.Divide:
                    return new DivideStrategy();
                case CalculationType.Multiple:
                    return new MultipleStrategy();
                case CalculationType.Sum:
                    return new SumStrategy();
                default:
                    return null;
            }
        }
    }
}
