using HiringManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HiringManagement.Interface
{
    public interface Ilogin
    {
        bool Login(string email, string password);
        void Register(User user);
    }
}
