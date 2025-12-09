using AdminJob.Enums;
using AdminJob.Interface;
using AdminJob.Models;
//using AdminJob.Models;

namespace AdminJob.Repository
{
    public sealed class UserRepository : IUserRepository
    {
        private List<User> users = new List<User> { new User(1, "admin", "", "admins@gmail.com", 123, "123", Roles.Admin), new User(2, "admin", "", "admin1@gmail.com", 123, "123", Roles.Admin), new User(3, "admin123", "", "admin@gmail.com", 123, "123", Roles.Admin) };
        private static User loggedUser;
        private int nextId = 2;
        public List<User> getAll()
        {
            return users.Where(e => e.Role == Roles.Admin).ToList();
        }

        public User login(string email, string password)
        {
            loggedUser = users.FirstOrDefault(e => e.Email == email && e.Password == password);
            return loggedUser;
        }


        public User getLoggedUser()
        { return loggedUser; }



    }
}