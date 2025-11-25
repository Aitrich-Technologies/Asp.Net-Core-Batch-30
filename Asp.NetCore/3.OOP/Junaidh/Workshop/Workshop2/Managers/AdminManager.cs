using Workshop2.Modals;
using Workshop2.Utils;
using Workshop2.Enums;
using Workshop2.Interface;

namespace Workshop2.Managers
{
    public class AdminManager : IMenu
    {
        private readonly User[] users;
        private readonly int userCount;
        private readonly JobManager jobManager;

        public AdminManager(User[] users, int userCount, JobManager jobManager)
        {
            this.users = users;
            this.userCount = userCount;
            this.jobManager = jobManager;
        }

        public void DisplayMenu(object? PublicManager = null)
        {
            var Printer = new Printer();

            while (true)
            {
                Console.WriteLine("======Admin Menu=====");
                Console.WriteLine("1. View Registration");
                Console.WriteLine("2. Add Job");
                Console.WriteLine("3.List Jobs");
                Console.WriteLine("4. Logout");

                string? choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        Printer.Print(users);
                        break;

                    case "2":
                        AddJob();
                        break;

                    case "3":
                        Printer.Print(jobManager.GetJobs());
                        break;

                    case "4":
                        return;
                }
            }
        }
        private void  AddJob()
        {
            Console.WriteLine("=== Add Job ===");
            Console.WriteLine("Title :");
            string title = Console.ReadLine() ?? "";
            Console.WriteLine("Company :");
            string company = Console.ReadLine() ?? "";
            Console.WriteLine("Location :");
            string location = Console.ReadLine() ?? "";
            Console.WriteLine("Salary Range :");
            string salary = Console.ReadLine() ?? "";
            Console.WriteLine("Job Type :");
            string jobtype = Console.ReadLine() ?? "";

            Console.WriteLine("Select Experience Level : 1.Fresher  2.MidLevel  3.Senior ");
            string choice = Console.ReadLine();
            ExperienceLevels exp;
            switch (choice)
            {
                case "2":
                    exp = ExperienceLevels.MidLevel;
                    break;
                    case "3":
                    exp = ExperienceLevels.Senior;
                    break;
                default:
                    exp = ExperienceLevels.Fresher;
                    break;
            }
            Job job = new()
            {
                Title = title,
                Company = company,
                location = location,
                SalaryRange = salary,
                JobType = jobtype,
                ExperienceLevel = exp
            };
            jobManager.AddJob(job);
            Console.WriteLine("Job added Successfully!");

        }
    }
}
