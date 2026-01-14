using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exericseee.Exception
{
    public class UserNotFoundException : Exception
    {
        public UserNotFoundException(string msg) : base(msg) { }
    }
}
