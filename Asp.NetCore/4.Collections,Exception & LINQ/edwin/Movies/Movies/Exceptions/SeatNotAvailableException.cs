using System;

namespace Movies.Exceptions
{
    public class SeatNotAvailableException : Exception
    {
        public SeatNotAvailableException(string message) : base(message) { }
    }
}

