using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    interface IWeight
    {
        void SetWeight(double weight);
        double GetWeight();
        void SetTare(double tare);
        double GetTare();
    }
}
