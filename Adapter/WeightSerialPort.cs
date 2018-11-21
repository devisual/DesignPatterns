using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class WeightSerialPort
    {
        private double _tare;
        private double _weight;
        public void SetTareSerialPort(double tare)
        {
            _tare = tare;
        }
        public double GetTareSerialPort()
        {
            return _tare;
        }
        public double GetWeightSerialPort()
        {
            return _weight;
        }
        public void SetWegithSerialPort(double weight)
        {
            _weight = weight;
        }
    }
}
