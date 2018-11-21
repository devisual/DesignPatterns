using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    class DocumentElement
    {
        public int Article { get; set; }

        public void Add()
        {
            Console.WriteLine($"Added document element for article {Article}");
        }
    }
}
