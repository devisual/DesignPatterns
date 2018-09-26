using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    class BankFactory
    {
        public IBankService GetBankService(short pin)
        {
            return new BankService(pin);
        }
    }
}
