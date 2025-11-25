using Workshop2.Enums;
using Workshop2.Interface;
using Workshop2.Modals;

namespace Workshop2.Managers
{
    internal class PublicManager :ILogin,IMenu
    {
        private User[] users = new User[5];   
        private int userCount = 0;

        private readonly JobManager jobManager; 

        public PublicManager(JobManager jobManager)
        {
            jobManager = jobManager;
        }

        public bool Login(string email, string password)
        {
            for (int i = 0; i < userCount; i++)
            {
                if (users[i].Email == email && users[i].Password == password)
                    return true;
            }
            return false;
        }

        public void Register(User user)
        {
            if (userCount >= users.Length)
            {
                Console.WriteLine("Registration limit reached!");
                return;
            }

            user.Id = userCount + 1;
            users[userCount] = user;
            userCount++;
            Console.WriteLine("\nRegistration successful!");
        }

        public void DisplayMenu(object? publicManager = null)
        {
            while (true)
            {
                Console.WriteLine("\n=== Welcome to Hiring Management System ===");
                Console.WriteLine("1. Login");
                Console.WriteLine("2. Register");
                Console.WriteLine("3. Exit");
                Console.Write("Choose an option: ");
                string? choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.Write("Enter Email: ");
                        string email = Console.ReadLine() ?? "";
                        Console.Write("Enter Password: ");
                        string password = Console.ReadLine() ?? "";

                        if (Login(email, password))
                        {
                            var user = Array.Find(users, u => u != null && u.Email == email)!;

                            if (user.Role == Roles.Admin)
                            {
                                
                                new AdminManager(users, userCount, jobManager).DisplayMenu(this);
                            }
                            else
                            {
                                
                                new UserManager(jobManager).DisplayMenu(this);
                            }
                        }
                        else
                        {
                            Console.WriteLine("Invalid credentials!");
                        }
                        break;

                    case "2":
                        Console.WriteLine("\n=== Register User ===");
                        Console.Write("First Name: ");
                        string firstName = Console.ReadLine() ?? "";
                        Console.Write("Last Name: ");
                        string lastName = Console.ReadLine() ?? "";
                        Console.Write("Email: ");
                        string userEmail = Console.ReadLine() ?? "";
                        Console.Write("Phone: ");
                        string phone = Console.ReadLine() ?? "";
                        Console.Write("Password: ");
                        string userPassword = Console.ReadLine() ?? "";

                        Console.WriteLine("Select Role: 1. Admin  2. JobSeeker");
                        Roles role = (Console.ReadLine() == "1") ? Roles.Admin : Roles.JobSeeker;

                        User newUser = new()
                        {
                            FirstName = firstName,
                            LastName = lastName,
                            Email = userEmail,
                            Phone = phone,
                            Password = userPassword,
                            Role = role
                        };
                        Register(newUser);
                        break;

                    case "3":
                        return;
                }
            }
        }
    }
}
