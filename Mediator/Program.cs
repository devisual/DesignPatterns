using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcreteMediator mediator = new ConcreteMediator();
            IColleague col1 = new ConcreteColleague(mediator, "user 1");
            IColleague col2 = new ConcreteColleague(mediator, "user 2");
            IColleague col3 = new ConcreteColleague(mediator, "user 3");

            mediator.Add(col1);
            mediator.Add(col2);
            mediator.Add(col3);

            col1.Send("Message from user 1. Hello!");
            Console.ReadKey();
        }
    }
}
