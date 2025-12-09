using ExcepCollecExercise4.html.Exceptions;
using ExcepCollecExercise4.html.Interface;
using ExcepCollecExercise4.html.Model;
using ExcepCollecExercise4.html.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ExcepCollecExercise4.html.Manager
{
    public class UserService : IUserService
    {
        private readonly UserRepository repo;

        public UserService(UserRepository repo)
        {
            this.repo = repo;
        }

        public void Register()
        {
            try
            {
                string fname;
                while (true)
                {
                    Console.Write("Enter first name: ");
                    fname = Console.ReadLine();

                    if (!string.IsNullOrWhiteSpace(fname) && Regex.IsMatch(fname, @"^[A-Za-z]+$"))
                        break;

                    Console.WriteLine("Invalid first name. Only alphabets allowed.");
                }

                string lname;
                while (true)
                {
                    Console.Write("Enter last name: ");
                    lname = Console.ReadLine();

                    if (!string.IsNullOrWhiteSpace(lname) && Regex.IsMatch(lname, @"^[A-Za-z]+$"))
                        break;

                    Console.WriteLine("Invalid last name. Only alphabets allowed.");
                }

                string email;
                while (true)
                {
                    Console.Write("Enter email: ");
                    email = Console.ReadLine();

                    // Basic email regex
                    string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";

                    if (Regex.IsMatch(email, emailPattern))
                        break;
                    else
                        Console.WriteLine("Invalid email format. Try again.");

                    if (repo.DoesEmailExist(email))
                    {
                        Console.WriteLine("Email already exists. Try another one.");
                        continue;
                    }
                }

                string phoneInput;
                long phone;

                while (true)
                {
                    Console.Write("Enter phone number (10 digits): ");
                    phoneInput = Console.ReadLine();

                    string phonePattern = @"^[0-9]{10}$";

                    if (Regex.IsMatch(phoneInput, phonePattern))
                    {
                        phone = long.Parse(phoneInput);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid phone number. Enter a 10-digit number.");
                    }
                }

                string pass;
                while (true)
                {
                    Console.Write("Enter password (Min 6 chars, 1 number, 1 uppercase): ");
                    pass = Console.ReadLine();

                    string passPattern = @"^(?=.*[A-Z])(?=.*\d).{6,}$";

                    if (Regex.IsMatch(pass, passPattern))
                        break;

                    Console.WriteLine("Weak password. Example: Abcd123");
                }


                Console.WriteLine("\nChoose Role:");
                Console.WriteLine("1. Job Provider");
                Console.WriteLine("2. Job Seeker");
                int choice = Convert.ToInt32(Console.ReadLine());

                if(choice !=1 && choice != 2)
                {
                    Console.WriteLine("Invalid choice.Enter 1 or 2");
                }

                string role = choice == 1 ? "jobprovider" : "jobseeker";

                User user = new User()
                {
                    FirstName = fname,
                    LastName = lname,
                    Email = email,
                    Phone = phone,
                    Password = pass,
                    Role = role
                };

                repo.AddUser(user);

                Console.WriteLine("\nRegistration successful!\n");
            }
            catch(Exception ex) 
            {
                Console.WriteLine("Registration failed. Try again.");
                Console.WriteLine("Reason:" +ex.Message);
            }
        }

        public User Login()
        {
            try
            {
                Console.Write("Enter email: ");
                string email = Console.ReadLine();

                Console.Write("Enter password: ");
                string pass = Console.ReadLine();

                User user = repo.Login(email, pass);

                if (user == null)
                    throw new InvalidUserException("Login failed. Incorrect email or password.");

                Console.WriteLine("Login successful!\n");
                return user;
            }
            catch (InvalidUserException ex)
            {
                Console.WriteLine("Login failed! Try again");
                Console.WriteLine(ex.Message);
                return null;
            }
        }
    }
}


