using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exericseee.Exception
{
    public class InvalidChoiceException : Exception
    {
        public InvalidChoiceException(string msg) : base(msg) { }
    }
}
