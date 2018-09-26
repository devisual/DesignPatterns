using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    interface IObserved
    {
        void AddObserver(IObserver observer);
        void DelereObserver(IObserver observer);
        void TellTheObserver();
    }
}
