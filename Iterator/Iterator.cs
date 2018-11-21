using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    internal class Iterator : IIterator
    {
        IAggregate _aggregate;
        int _current;
        public Iterator(IAggregate aggregate)
        {
            _aggregate = aggregate;
        }
        string IIterator.Current()
        {
            return _aggregate[_current];
        }

        string IIterator.First()
        {
            _current = 0;
            return _aggregate[_current];
        }

        public bool IsFinished()
        {
            return (_current >= _aggregate.Count);
        }

        string IIterator.Next()
        {
            _current++;
            if(!IsFinished())
            {
                return _aggregate[_current];
            }
            else
            {
                return string.Empty;
            }
        }
    }
}
