﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class DivideStrategy : ICalculateStrategy
    {
        public decimal Calculate(decimal a, decimal b)
        {
            return a / b;
        }
    }
}
