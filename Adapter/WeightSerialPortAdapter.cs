using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class WeightSerialPortAdapter : IWeight
    {
        WeightSerialPort _weight = null;
        public WeightSerialPortAdapter()
        {
            _weight = new WeightSerialPort();
        }

        public double GetTare()
        {
            return _weight.GetTareSerialPort();
        }

        public double GetWeight()
        {
            return _weight.GetWeightSerialPort();
        }

        public void SetTare(double tare)
        {
            _weight.SetTareSerialPort(tare);
        }

        public void SetWeight(double weight)
        {
            _weight.SetWegithSerialPort(weight);
        }
    }
}
