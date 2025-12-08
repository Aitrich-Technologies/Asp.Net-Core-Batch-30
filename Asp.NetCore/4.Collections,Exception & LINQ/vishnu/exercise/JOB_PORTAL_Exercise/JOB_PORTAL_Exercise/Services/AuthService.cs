using JOB_PORTAL_Exercise.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JOB_PORTAL_Exercise.Services
{
    internal class AuthService
    {
       
            private  Dictionary<string, User> _usersByEmail = new Dictionary<string, User>(StringComparer.OrdinalIgnoreCase);

            public AuthService()
            {
                var provider = new User { FirstName = "jobprovider", Email = "jobprovider@gmail.com", Password = "123", Role = Role.JobProvider };
                var seeker = new User { FirstName = "vishnu", Email = "vishnu@gmail.com", Password = "123", Role = Role.JobSeeker };

                _usersByEmail[provider.Email] = provider;
                _usersByEmail[seeker.Email] = seeker;
            }

        public string Register(User user)
        {
            if (string.IsNullOrWhiteSpace(user.Email) || string.IsNullOrWhiteSpace(user.Password))
                return "Email and password are required.";

            if (_usersByEmail.ContainsKey(user.Email))
                return "User already exists.";

            _usersByEmail[user.Email] = user;
            return "Registration successful";
        }


        public User Login(string email, string password)
        {
            if (!_usersByEmail.TryGetValue(email, out var found))
                return null;

            if (found.Password != password)
                return null;

            return found;
        }

        }
    
}
