using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcepCollecExercise4.html.Exceptions
{
    public class JobNotFoundException:Exception
    {
        public JobNotFoundException(string message) : base(message) { }
    }
}

