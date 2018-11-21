using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class Weight : IWeight
    {
        private double _tare;
        private double _weight;


        public double GetTare()
        {
            return _tare;
        }

        public double GetWeight()
        {
            return _weight;
        }

        public void SetTare(double tare)
        {
            _tare = tare;
        }

        public void SetWeight(double weight)
        {
            _weight = weight;
        }
    }
}
