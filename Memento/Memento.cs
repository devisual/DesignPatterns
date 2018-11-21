using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    class Memento
    {
        private string _name;
        private string _customer;
        private decimal _price;
        public string Name { get => _name; set => _name = value; }
        public string Customer { get => _customer; set => _customer = value; }
        public decimal Price {get => _price; set => _price = value; }

        public Memento(string name, string customer, decimal price)
        {
            _name = name;
            _customer = customer;
            _price = price;
        }
    }
}
