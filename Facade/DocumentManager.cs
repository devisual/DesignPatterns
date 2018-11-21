using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    class DocumentManager
    {
        DocumentHeader header;
        DocumentElement element;
        public string Customer { get; set; }
        public List<int> ArticleList { get; set; }

        public void CreateDocument()
        {
            if (string.IsNullOrEmpty(Customer))
                throw new Exception("Customer is required");
            if (!ArticleList.Any())
                throw new Exception("Article is required");
            header = new DocumentHeader()
            {
                Customer = this.Customer,
            };
            header.Add();
            foreach(int article in ArticleList)
            {
                element = new DocumentElement()
                {
                    Article = article
                };
                element.Add();
            }
            DocumentClosing();
        }

        private void DocumentClosing()
        {
            Console.WriteLine("Closing the document");
        }
    }
}
