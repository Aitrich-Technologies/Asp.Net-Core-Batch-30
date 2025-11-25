using Exercise._2.Modals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise._2.Interfaces
{
    public interface ILogin
    {
        bool Login(string email, string password);
        void Register(User user);
    }
}
