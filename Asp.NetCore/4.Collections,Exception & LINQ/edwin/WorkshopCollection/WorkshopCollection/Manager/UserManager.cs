using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkshopCollection.InterFace;
using WorkshopCollection.Models;

namespace WorkshopCollection.Manager
{
    internal class UserManager:IMenu
    {
        public User loggedUser;

        public UserManager(User loggedUser)
        {
            this.loggedUser = loggedUser;
        }
        public UserManager() { }

        public void DisplayMenu()
        {
            throw new NotImplementedException();
        }
    }
}
