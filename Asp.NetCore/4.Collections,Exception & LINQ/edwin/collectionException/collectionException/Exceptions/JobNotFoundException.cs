using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace collectionException.Exceptions
{
    public class JobNotFoundException : Exception
    {
        public JobNotFoundException(string msg) : base(msg) { }
    }
}
