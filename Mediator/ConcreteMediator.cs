using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    class ConcreteMediator : IMediator
    {
        public List<IColleague> colleagues = new List<IColleague>();
        public void Add(IColleague colleague)
        {
            colleagues.Add(colleague);
        }
        public void Remove(IColleague colleague)
        {
            colleagues.Remove(colleague);
        }
        public void NotifyAll(string message, IColleague colleague)
        {
            Console.WriteLine("Message from user {1} : {0}", message, colleague.GetName());
            foreach (var item in colleagues)
            {
                item.Receive(message);
            }
        }
    }
}
