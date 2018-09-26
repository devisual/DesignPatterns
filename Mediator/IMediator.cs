using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    interface IMediator
    {
        void NotifyAll(string message, IColleague colleague);
    }
}
