using ExcepCollecExercise4.html.Manager;
using ExcepCollecExercise4.html.Model;
using ExcepCollecExercise4.html.Repository;

public class Program
{
    static void Main()
    {
        UserRepository userRepo = new UserRepository();
        JobRepository jobRepo = new JobRepository();
        UserService userService = new UserService(userRepo);
        JobService jobService = new JobService(jobRepo);

        while (true)
        {
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1. Register");
            Console.WriteLine("2. User Menu");
            Console.WriteLine("3. Exit");

            int ch = Convert.ToInt32(Console.ReadLine());

            if (ch == 1)
                userService.Register();
            else if (ch == 2)
            {
                User u = userService.Login();
                if (u == null) continue;

                if (u.Role == "jobprovider")
                    ShowJobProviderMenu(u, jobService);
                else
                    ShowJobSeekerMenu(u, jobService);
            }
            else if (ch == 3)
                break;
            else
                Console.WriteLine("Invalid choice!");
        }
    }

    static void ShowJobProviderMenu(User u, JobService js)
    {
        while (true)
        {
            Console.WriteLine("\n1. Post Job");
            Console.WriteLine("2. List Jobs");
            Console.WriteLine("3. Logout");

            int ch = Convert.ToInt32(Console.ReadLine());

            if (ch == 1) js.PostJob(u);
            else if (ch == 2) js.ListJobs();
            else if (ch == 3) break;
        }
    }

    static void ShowJobSeekerMenu(User u, JobService js)
    {
        while (true)
        {
            Console.WriteLine("\n1. List Jobs");
            Console.WriteLine("2. Saved Jobs");
            Console.WriteLine("3. Applied Jobs");
            Console.WriteLine("4. Logout");

            int ch = Convert.ToInt32(Console.ReadLine());

            if (ch == 1)
            {
                js.ListJobs();
                Console.WriteLine("1. Apply Job");
                Console.WriteLine("2. Save Job");
                Console.WriteLine("3. Back");

                int n = Convert.ToInt32(Console.ReadLine());
                if (n == 1) js.ApplyJob(u);
                else if (n == 2) js.SaveJob(u);
            }
            else if (ch == 2) js.ShowSavedJobs(u);
            else if (ch == 3) js.ShowAppliedJobs(u);
            else if (ch == 4) break;
        }
    }
}