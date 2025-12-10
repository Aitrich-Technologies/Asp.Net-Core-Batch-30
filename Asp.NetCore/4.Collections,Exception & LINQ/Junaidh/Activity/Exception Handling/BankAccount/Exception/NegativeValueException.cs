using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount.Exception
{
    internal class NegativeValueException : ApplicationException
    {
        public NegativeValueException(string message) : base (message) { }
    }
}
