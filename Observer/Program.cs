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
            Messages _messages = new Messages();
            User user1 = new User(_messages);
            User user2 = new User(_messages);
            _messages.AddObserver(user1);
            _messages.AddObserver(user2);
            _messages.SetMessage("It's Thursday");
            _messages.TellTheObserver();
            _messages.DelereObserver(user1);
            _messages.SetMessage("Today the weather is great.");
            _messages.TellTheObserver();
            Console.ReadLine();
        }
    }
}
