using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Exception
{
    internal class InvalidEmailException:EmailValidator
    {
        public InvalidEmailException(string message) : base(message) { }
    }
}
