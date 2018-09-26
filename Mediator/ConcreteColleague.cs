using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    class ConcreteColleague : IColleague
    {
        private IMediator Mediator;
        private string Name;

        public ConcreteColleague(IMediator mediator, string name)
        {
            this.Mediator = mediator;
            this.Name = name;
        }

        public string GetName()
        {
            return Name;
        }

        public void Receive(string message)
        {
            Console.WriteLine("Colleague {0} received message: {1}", Name, message);
        }

        public void Send(string message)
        {
            Mediator.NotifyAll(message, this);
        }
    }
}
