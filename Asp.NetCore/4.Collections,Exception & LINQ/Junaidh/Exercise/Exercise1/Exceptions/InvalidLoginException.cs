using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1.Exceptions
{

    public class InvalidLoginException : Exception
    {
        public InvalidLoginException(string message) : base(message) { }
    }
}