using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkshopCollection.Models;

namespace WorkshopCollection.InterFace
{
    public interface IUserRepository
    {
        List<User> getAll();
    }
}
