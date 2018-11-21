using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyweightPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Choose the word to see details about characters.");
            string word = Console.ReadLine();
            CharacterFactory factory = new CharacterFactory();
            char[] wordChars = word.ToArray();

            foreach (char sign in wordChars)
            {
                Character flyweight = factory.GetCharacter(sign);
                if (flyweight != null) 
                Console.WriteLine($"{flyweight.Name} has height equals {flyweight.Height} and width equals {flyweight.Width}.");
            }
            Console.ReadKey();
        }
    }
}
