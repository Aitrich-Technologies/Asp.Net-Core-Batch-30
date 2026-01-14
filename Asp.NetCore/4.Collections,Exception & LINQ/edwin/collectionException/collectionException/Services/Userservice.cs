using collectionException.Exceptions;
using collectionException.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace collectionException.Services
{
    public class Userservice
    {
        public static List<User> Users = new();
        public static Dictionary<string, List<Job>> SavedJobs = new();

        public void Register(string fn, string ln, string email, string phone, string password, string userType)
        {
            if (string.IsNullOrWhiteSpace(fn) || string.IsNullOrWhiteSpace(ln)) throw new PortalException("Name required.");
            if (string.IsNullOrWhiteSpace(email)) throw new PortalException("Email required.");
            if (string.IsNullOrWhiteSpace(phone)) throw new PortalException("Phone required.");
            if (string.IsNullOrWhiteSpace(password) || password.Length < 4) throw new PortalException("Password (>=4 chars) required.");
            if (Users.Exists(u => u.Email == email)) throw new AlreadyExistsException("User already exists!");

            Users.Add(new User
            {
                FirstName = fn,
                LastName = ln,
                Email = email,
                Phone = phone,
                Password = password,
                UserType = userType
            });

            if (!SavedJobs.ContainsKey(email)) SavedJobs[email] = new List<Job>();
        }

        public User Login(string email, string password)
        {
            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
                throw new PortalException("Email and password required.");
            var user = Users.Find(u => u.Email == email && u.Password == password);
            if (user == null) 
                throw new UserNotFoundException("Incorrect email or password!");
            if (!SavedJobs.ContainsKey(email)) SavedJobs[email] = new List<Job>();
            return user;
        }

        public void SaveJob(string email, Job job)
        {
            if (!SavedJobs.ContainsKey(email)) SavedJobs[email] = new List<Job>();
            SavedJobs[email].Add(job);
        }

        public List<Job> GetSavedJobs(string email)
        {
            if (!SavedJobs.ContainsKey(email)) return new List<Job>();
            return SavedJobs[email];
        }
    }
}
