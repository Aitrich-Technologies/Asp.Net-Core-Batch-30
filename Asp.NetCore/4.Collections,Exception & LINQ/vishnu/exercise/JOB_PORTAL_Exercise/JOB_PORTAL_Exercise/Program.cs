using JOB_PORTAL_Exercise.Managers;
using JOB_PORTAL_Exercise.Models;
using JOB_PORTAL_Exercise.Services;

internal class Program
{
    private static void Main(string[] args)
    {

        var auth = new AuthService();
        var jobService = new JobService();

        while (true)
        {
            Console.WriteLine("\n1. Login\n2. Register\n3. Exit\n");
            var opt = Console.ReadLine();


            if (opt == "1")
            {
                Console.Write("Email: ");
                var email = Console.ReadLine();

                Console.Write("Password: ");
                var pass = Console.ReadLine();

                var user = auth.Login(email, pass);

                if (user == null)
                {
                    Console.WriteLine("Invalid login!");
                }
                else
                {
                    if (user.Role == Role.JobProvider)
                        new JobProviderMenu(jobService, user).Run();
                    else
                        new JobSeekerMenu(jobService, user).Run();
                }
            }


            else if (opt == "2")
            {
                Console.Write("First Name: ");
                var fn = Console.ReadLine();

                Console.Write("Last Name: ");
                var ln = Console.ReadLine();

                Console.Write("Email: ");
                var email = Console.ReadLine();

                Console.Write("Phone: ");
                var phone = Console.ReadLine();

                Console.Write("Password: ");
                var pass = Console.ReadLine();

                Console.Write("Role (1.Provider / 2.Seeker): ");
                var r = Console.ReadLine();

                var role = r == "1" ? Role.JobProvider : Role.JobSeeker;

                var user = new User
                {
                    FirstName = fn,
                    LastName = ln,
                    Email = email,
                    Phone = phone,
                    Password = pass,
                    Role = role
                };


                string msg = auth.Register(user);
                Console.WriteLine(msg);
            }


            else if (opt == "3")
            {
                break;
            }

            else
            {
                Console.WriteLine("Invalid option\n");
            }
        }
    }
}