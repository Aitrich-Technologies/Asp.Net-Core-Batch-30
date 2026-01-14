using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace collectionException.Exceptions
{
    public class PortalException : Exception
    {
        public PortalException(string msg) : base(msg) { }
    }
}
