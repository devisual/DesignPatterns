using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    interface IIterator
    {
        string First();
        string Next();
        string Current();
        bool IsFinished();
    }
}
