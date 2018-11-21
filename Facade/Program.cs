using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            DocumentManager document = new DocumentManager();
            document.Customer = "FUN4A";
            document.ArticleList = new List<int> { 1, 2, 4 };
            document.CreateDocument();
            Console.ReadKey();
        }
    }
}
