using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    class Messages : IObserved
    {
        List<IObserver> _observers = new List<IObserver>();
        string message = "Today 05.07.2018";
        public void AddObserver(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void DelereObserver(IObserver observer)
        {
            _observers.Remove(observer);
        }

        public void TellTheObserver()
        {
            foreach (var observer in _observers)
            {
                observer.updateData();
            }
        }
        public string GetCurrentMessage()
        {
            return message;
        }
        public void SetMessage(string message)
        {
            this.message += message;
        }
    }
}
