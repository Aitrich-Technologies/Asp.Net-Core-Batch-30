using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UseraleradyExists.Exception
{
    internal class PasswordException:ApplicationException
    {
        public PasswordException(string message) : base(message) { }
    }
}
