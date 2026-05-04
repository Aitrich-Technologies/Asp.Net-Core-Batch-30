using JobPortalApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobPortalApplication.Interfaces
{
    internal interface IUser
    {

        void Register(User user);
        User Login(string email, string password);

    }
}
