using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccounts.Exception
{
    internal class InSufficientFundException :ApplicationException
    {
        public  InSufficientFundException() { }

        public InSufficientFundException(string message) : base(message) { }
    }
}
