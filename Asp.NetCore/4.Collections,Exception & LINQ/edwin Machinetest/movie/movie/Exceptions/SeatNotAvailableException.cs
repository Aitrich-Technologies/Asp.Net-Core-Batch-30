using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace movie.Exceptions
{
    public class SeatNotAvailableException : Exception
    {
        public SeatNotAvailableException(string message) : base(message) { }
    }
}
