using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneApplication.Exception
{
    internal class InvalidPhoneNumberException:ApplicationException
    {
        public InvalidPhoneNumberException(string message) : base(message)
        {

        }
    }
}
