using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            Messages _messages = new Messages(); //our observed object
            User user1 = new User(_messages); //users observe message changing
            User user2 = new User(_messages);
            _messages.AddObserver(user1); //adding observer to observed object
            _messages.AddObserver(user2);
            _messages.SetMessage("It's Thursday");
            _messages.TellTheObserver(); // inform observer about changes in observed object
            _messages.DelereObserver(user1); //delete one of the observers
            _messages.SetMessage("Today the weather is great.");
            _messages.TellTheObserver();
            Console.ReadLine();
        }
    }
}
