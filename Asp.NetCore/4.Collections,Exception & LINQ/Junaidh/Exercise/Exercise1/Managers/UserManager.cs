using Exercise1;
using Exercise1.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1.Manager
{
    public class UserManager
    {
        public List<User> Users = new List<User>();

        public void Register()
        {
            try
            {
                Console.Write("Please enter your first name: ");
                string firstName = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(firstName))
                    throw new Exception("First name cannot be empty.");

                Console.Write("Please enter your last name: ");
                string lastName = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(lastName))
                    throw new Exception("Last name cannot be empty.");

                Console.Write("Please enter your email address: ");
                string email = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(email) || !email.Contains("@"))
                    throw new Exception("Invalid email address.");

                
                if (Users.Exists(u => u.Email == email))
                    throw new Exception("This email is already registered.");

                Console.Write("Please enter your phone number: ");
                string phone = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(phone) || phone.Length < 10)
                    throw new Exception("Invalid phone number.");

                Console.Write("Please enter a password: ");
                string password = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(password) || password.Length < 6)
                    throw new Exception("Password must be at least 6 characters.");

                User newUser = new User(firstName, lastName, email, phone, password);
                Users.Add(newUser);

                Console.WriteLine("Registration successful!\n");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Registration failed: " + ex.Message + "\n");
            }
        }

        public User Login(string email, string password)
        {
            User user = Users.FirstOrDefault(u => u.Email == email);

            if (user == null)
                throw new UserNotFoundException("User not found");

            if (user.Password != password)
                throw new InvalidLoginException("Incorrect password");

            return user;
        }
    }
}
