using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    class User : IObserver
    {
        Messages _messages;
        public User(Messages messages)
        {
            _messages = messages;
        }
        public void updateData()
        {       
            Console.WriteLine(_messages.GetCurrentMessage());
        }
    }
}
