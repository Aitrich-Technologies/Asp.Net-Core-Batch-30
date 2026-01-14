using Exercisee.Manager;

internal class Program
{
    private static void Main(string[] args)
    {
        JobPortalManager portal = new JobPortalManager();
        string currentUser = null;

        while (true)
        {
            if (currentUser == null)
            {
                Console.WriteLine("\n===== JOB PORTAL =====");
                Console.WriteLine("1. Register");
                Console.WriteLine("2. Login");
                Console.WriteLine("3. Exit");
                Console.Write("Choose: ");
                string op = Console.ReadLine();

                try
                {
                    if (op == "1")
                    {
                        Console.Write("Enter username: ");
                        string u = Console.ReadLine();

                        Console.Write("Enter password: ");
                        string p = Console.ReadLine();

                        portal.RegisterUser(u, p);
                        Console.WriteLine("User registered.");
                    }
                    else if (op == "2")
                    {
                        Console.Write("Enter username: ");
                        string u = Console.ReadLine();

                        Console.Write("Enter password: ");
                        string p = Console.ReadLine();

                        if (portal.Login(u, p))
                        {
                            currentUser = u;
                            Console.WriteLine("Login successful.");
                        }
                    }
                    else if (op == "3")
                    {
                        return;
                    }
                    else
                    {
                        Console.WriteLine("Invalid option.");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
            else
            {
                Console.WriteLine("\n===== JOB PORTAL - MENU =====");
                Console.WriteLine("1. List Jobs");
                Console.WriteLine("2. Save Job");
                Console.WriteLine("3. View Saved Jobs");
                Console.WriteLine("4. Remove Saved Job");
                Console.WriteLine("5. List Users");
                Console.WriteLine("6. Logout");
                Console.WriteLine("7. Exit");
                Console.Write("Choose: ");
                string op = Console.ReadLine();

                try
                {
                    if (op == "1")
                    {
                        foreach (var job in portal.GetAllJobs())
                            Console.WriteLine(job);
                    }
                    else if (op == "2")
                    {
                        Console.Write("Enter job id: ");
                        int id = int.Parse(Console.ReadLine());
                        portal.SaveJob(currentUser, id);
                        Console.WriteLine("Job saved.");
                    }
                    else if (op == "3")
                    {
                        foreach (var j in portal.GetSavedJobs(currentUser))
                            Console.WriteLine("  " + j);
                    }
                    else if (op == "4")
                    {
                        Console.Write("Enter job id: ");
                        int id = int.Parse(Console.ReadLine());
                        portal.RemoveSavedJob(currentUser, id);
                        Console.WriteLine("Removed.");
                    }
                    else if (op == "5")
                    {
                        foreach (var u in portal.GetAllUsers())
                            Console.WriteLine("- " + u);
                    }
                    else if (op == "6")
                    {
                        Console.WriteLine("Logged out.");
                        currentUser = null;
                    }
                    else if (op == "7")
                    {
                        return;
                    }
                    else
                    {
                        Console.WriteLine("Invalid option.");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
        }
    }
}
