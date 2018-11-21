using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    class Offer
    {
        public string Name { get; set; }
        public string Customer { get; set; }
        public decimal Price { get; set; }
        public Memento SaveMemento()
        {
            return new Memento(Name, Customer, Price);
        }
        public void RestoreMemento(Memento memento)
        {
            Name = memento.Name;
            Customer = memento.Customer;
            Price = memento.Price;
        }
    }
}
