using System;

namespace Movies.Exceptions
{
    public class MovieNotFoundException : Exception
    {
        public MovieNotFoundException(string message) : base(message) { }
    }
}
 }
}
