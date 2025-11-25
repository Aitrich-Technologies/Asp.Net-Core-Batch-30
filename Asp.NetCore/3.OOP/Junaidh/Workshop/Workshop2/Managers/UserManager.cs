using Workshop2.Modals;
using Workshop2.Interface;
using Workshop2.Utils;

namespace Workshop2.Managers
{
    internal class UserManager :IMenu
    {
        private readonly JobManager jobManager;  

        public UserManager(JobManager jobManager)
        {
            jobManager = jobManager;
        }

        public void DisplayMenu(object? publicManager = null)
        {
            var printer = new Printer();
            while (true)
            {
                Console.WriteLine("\n=== JobSeeker Menu ===");
                Console.WriteLine("1. View Jobs");
                Console.WriteLine("2. Logout");

                string? choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        // Get jobs from JobManager
                        var jobs = jobManager.GetJobs();
                        printer.Print(jobs);
                        break;
                    case "2":
                        return;
                }
            }
        }
    }
}
