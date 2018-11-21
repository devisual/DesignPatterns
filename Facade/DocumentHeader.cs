using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    class DocumentHeader
    {
        public string Customer { get; set; }

        public void Add()
        {
            Console.WriteLine($"Added document header for customer {Customer}");
        }
    }
}
