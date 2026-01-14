using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercisee.Exception
{
    public class UserAlreadyExistsException : ApplicationException
    {
        public UserAlreadyExistsException(string message) : base(message) { }
    }
}
