using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    class Aggregation : IAggregate
    {
        List<string> _values = null;
        public Aggregation()
        {
            _values = new List<string>();
        }
        public string this[int index]
        {
            get
            {
                if (index < _values.Count())
                    return _values[index];

                    return string.Empty;
            }
            set { _values.Add(value); }
        }

        public int Count => _values?.Count??0;

        public IIterator Iterator()
        {
            return new Iterator(this);
        }
    }
}
