using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkshopCollection.Exceptions
{
   internal class UserAlreadyExistException:Exception
    {
        public UserAlreadyExistException() { }
        
        public UserAlreadyExistException(string email):base(String.Format("User Already exists with this email{0}",email)) { }
    }
}
