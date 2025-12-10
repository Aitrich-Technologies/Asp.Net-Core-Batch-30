using AdminJob.Interface;
using AdminJob.Models;
using AdminJob.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminJob.Managers
{
    public class AdminManager :IMenu
    {
        IJobProvider Jobs = new JobManager();
        private User loggedUser;
        private UserRepository Admins = new UserRepository();
        private Lists display = new Lists();
        public AdminManager (User loggedUser)
        {
            this.loggedUser = loggedUser;
        }
        public void DisplayMenu()
        {
            ShowAdminMenu();
        }
        public void ShowAdminMenu()
        {
            Console.WriteLine("1.List all admins\n2.My Profile\n3.Post a Job\n4.List all\n5.Log Out");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    var users = Admins.getAll();
                    display.Print(users);
                    ShowAdminMenu();
                    break;
                    case "2":
                    ViewProfile();
                    ShowAdminMenu();
                    break;
                    case "3":
                    Console.WriteLine("Enter JobTitle");
                    string title = Console.ReadLine();
                    Console.WriteLine("Enter Job Description");
                    string description = Console.ReadLine();
                    Console.WriteLine("Enter Job Location");
                    string location = Console.ReadLine();
                    Console.WriteLine("Enter Job Type");
                    string type = Console.ReadLine();
                    Console.WriteLine("Enter Salary Range");
                    string salary = Console.ReadLine();
                    Console.WriteLine("Enter Company");
                    string company = Console.ReadLine();
                    Job job = new Job(title,description, location, type, salary,company);
                    Jobs.PostJob(job);
                    Console.WriteLine("Job Posted Succesfully");
                    ShowAdminMenu();
                    break;
                    case "4":
                    List<Job> jobs = Jobs.GetJobs();
                        display.Print(jobs);
                    ShowAdminMenu();
                    break;
                    case "5":
                    Logout();
                    break;
                default:
                    Console.WriteLine("Invalid Choice");
                    ShowAdminMenu();
                    break;


            }
        }
        public void ViewProfile()
        {
            User loggedUser = Admins.getLoggedUser();
            Console.WriteLine("========My Profile========");
            Console.WriteLine($"FirstName :{loggedUser.FirstName}");
            Console.WriteLine($"LastName :{loggedUser.LastName}");
            Console.WriteLine($"Email :{loggedUser.Email}");
            Console.WriteLine($"Phone :{loggedUser.Phone}");
            Console.WriteLine("\n");

        }
        public void Logout()
        {
            loggedUser = new User();
            Console.WriteLine("Logged Out Successfully");
        }
    }
}
