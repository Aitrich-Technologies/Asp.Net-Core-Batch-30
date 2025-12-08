using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JOB_PORTAL_Exercise.Exceptions
{
    internal class InvalidJobException: Exception
    {
        public InvalidJobException(string message) : base(message) { }

    }
}
