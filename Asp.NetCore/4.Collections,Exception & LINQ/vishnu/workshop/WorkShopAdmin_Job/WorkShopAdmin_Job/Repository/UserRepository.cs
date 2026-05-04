using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkShopAdmin_Job.Enums;
using WorkShopAdmin_Job.Interface;
using WorkShopAdmin_Job.Models;

namespace WorkShopAdmin_Job.Repository
{
  
    

        public sealed class UserRepository : IUserRepository
        {
            private List<User> users = new List<User>
        {
            new User(1, "admin", "", "admins@gmail.com", 123, Roles.Admin, "123"),
            new User(2, "admin2", "", "admin1@gmail.com", 123, Roles.Admin, "123"),
            new User(3, "admin123", "", "admin@gmail.com", 123, Roles.Admin, "123")
        };

            private static User loggedUser;

            public List<User> getAll()
            {
                return users.Where(e => e.Role == Roles.Admin).ToList();
            }

            public User login(string email, string password)
            {
                loggedUser = users.FirstOrDefault(u =>
                    u.Email.ToLower() == email.ToLower() &&
                    u.Password == password);

                return loggedUser;
            }

            public User getLoggedUser()
            {
                return loggedUser;
            }
        }
    }
