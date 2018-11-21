using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    class Program
    {
        static void Main(string[] args)
        {
            Offer offer = new Offer();
            offer.Name = "Winter Offer";
            offer.Customer = "FU4N";
            offer.Price = 1500.5M;

            Console.WriteLine($"{offer.Name} for {offer.Customer} with price {offer.Price}.");

            SavedMemento saved = new SavedMemento();
            saved.Memento = offer.SaveMemento();

            offer.Price = 1650M;

            Console.WriteLine($"{offer.Name} for {offer.Customer} with price {offer.Price}.");
            Console.WriteLine("Restoring memento");
            offer.RestoreMemento(saved.Memento);

            Console.WriteLine($"{offer.Name} for {offer.Customer} with price {offer.Price}.");
            Console.ReadKey();
        }
    }
}
