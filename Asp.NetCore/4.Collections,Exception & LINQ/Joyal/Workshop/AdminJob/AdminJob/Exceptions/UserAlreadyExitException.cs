using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminJob.Exceptions
{
    internal class UserAlreadyExitException : Exception
    {
        public UserAlreadyExitException() { }

        public UserAlreadyExitException(string email) : base(String.Format("User already exists with this email{0}", email)) { }

    }
}
