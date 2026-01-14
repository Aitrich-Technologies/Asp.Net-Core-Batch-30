using Exericseee.Exception;
using Exericseee.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exericseee.Services
{
    public class Userservice
    {
        public static List<User> Users = new();
        public static Dictionary<string, List<Job>> SavedJobs = new();

        public void Register(string fn, string ln, string email, string phone, string password)
        {
            if (Users.Exists(u => u.Email == email))
                throw new AlreadyExistsException("User already exists!");

            Users.Add(new User
            {
                FirstName = fn,
                LastName = ln,
                Email = email,
                Phone = phone,
                Password = password
            });
        }

        public User Login(string email, string password)
        {
            var user = Users.Find(u => u.Email == email && u.Password == password);

            if (user == null)
                throw new UserNotFoundException("Incorrect email or password!");

            if (!SavedJobs.ContainsKey(email))
                SavedJobs[email] = new List<Job>();

            return user;
        }

        public void SaveJob(string email, Job job)
        {
            SavedJobs[email].Add(job);
        }

        public List<Job> GetSavedJobs(string email)
        {
            return SavedJobs[email];
        }
    }
}
