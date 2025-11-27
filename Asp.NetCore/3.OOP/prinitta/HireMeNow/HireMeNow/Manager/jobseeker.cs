using HireMeNow.models;
using HireMeNow.enums;
using System;

namespace HireMeNow.managers
{
    public class JobSeekerManager
    {
        private JobSeeker[] jobSeekers = new JobSeeker[100];
        private int jobSeekerCount = 0;

        private JobSeeker loggedInJobSeeker;
        private JobManager jobManager;  

        public JobSeekerManager(JobManager jm)
        {
            jobManager = jm;   
        }

        public void RegisterJobSeeker()
        {
            Console.WriteLine("\n--- Register Job Seeker ---");

            JobSeeker seeker = new JobSeeker();
            seeker.Id = jobSeekerCount + 1;

            Console.Write("First Name: ");
            seeker.FirstName = Console.ReadLine();

            Console.Write("Last Name: ");
            seeker.LastName = Console.ReadLine();

            Console.Write("Email: ");
            seeker.Email = Console.ReadLine();

            Console.Write("Phone: ");
            seeker.Phone = Console.ReadLine();

            Console.Write("Location: ");
            seeker.Location = Console.ReadLine();

            Console.Write("About Me: ");
            seeker.AboutMe = Console.ReadLine();

            Console.Write("Qualification: ");
            seeker.Qualification = Console.ReadLine();

            Console.Write("Experience Level (0=Fresher, 1=MidLevel, 2=Senior): ");
            seeker.ExperienceLevel = (Experiencelevel)int.Parse(Console.ReadLine());

            Console.Write("Password: ");
            seeker.Password = Console.ReadLine();

            jobSeekers[jobSeekerCount++] = seeker;

            Console.WriteLine("\nRegistration successful!");
        }

        public void LoginJobSeeker()
        {
            Console.WriteLine("\n--- Job Seeker Login ---");

            Console.Write("Email: ");
            string email = Console.ReadLine();

            Console.Write("Password: ");
            string password = Console.ReadLine();

            foreach (var seeker in jobSeekers)
            {
                if (seeker != null && seeker.Email == email && seeker.Password == password)
                {
                    loggedInJobSeeker = seeker;
                    Console.WriteLine("\nLogin Successful!");
                    ShowJobSeekerMenu();
                    return;
                }
            }

            Console.WriteLine("\nInvalid email or password!");
        }

        public void ShowJobSeekerMenu()
        {
            while (true)
            {
                Console.WriteLine("\n--- Job Seeker Menu ---");
                Console.WriteLine("1. View Jobs");
                Console.WriteLine("2. Apply for a Job");
                Console.WriteLine("3. Save a Job");
                Console.WriteLine("4. View Profile");
                Console.WriteLine("5. Logout");
                Console.Write("Enter choice: ");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1: jobManager.ListJobs(); break;
                    case 2: ApplyJob(); break;
                    case 3: SaveJob(); break;
                    case 4: ViewProfile(); break;
                    case 5: Logout(); return;
                    default: Console.WriteLine("Invalid choice!"); break;
                }
            }
        }

        public void ApplyJob()
        {
            Console.Write("Enter Job ID to apply: ");
            int jobId = int.Parse(Console.ReadLine());

            Job job = jobManager.GetJobById(jobId);

            if (job == null)
            {
                Console.WriteLine("Job not found!");
                return;
            }

            loggedInJobSeeker.addAppliedJob(job);
            Console.WriteLine("Job applied successfully!");
        }

        public void SaveJob()
        {
            Console.Write("Enter Job ID to save: ");
            int jobId = int.Parse(Console.ReadLine());

            Job job = jobManager.GetJobById(jobId);

            if (job == null)
            {
                Console.WriteLine("Job not found!");
                return;
            }

            loggedInJobSeeker.addSavedJob(job);
            Console.WriteLine("Job saved successfully!");
        }

        public void ViewProfile()
        {
            Console.WriteLine("\n--- Profile Details ---");
            Console.WriteLine($"Name: {loggedInJobSeeker.FirstName} {loggedInJobSeeker.LastName}");
            Console.WriteLine($"Email: {loggedInJobSeeker.Email}");
            Console.WriteLine($"Phone: {loggedInJobSeeker.Phone}");
            Console.WriteLine($"Location: {loggedInJobSeeker.Location}");
            Console.WriteLine($"Qualification: {loggedInJobSeeker.Qualification}");
            Console.WriteLine($"Experience: {loggedInJobSeeker.ExperienceLevel}");
            Console.WriteLine($"About Me: {loggedInJobSeeker.AboutMe}");
        }

        public void Logout()
        {
            loggedInJobSeeker = null;
            Console.WriteLine("\nLogged out successfully!");
        }

        public void ShowMainMenu()
        {
            while (true)
            {
                Console.WriteLine("\n====== HireMeNow ======");
                Console.WriteLine("1. Register");
                Console.WriteLine("2. Login");
                Console.WriteLine("3. Exit");
                Console.Write("Enter choice: ");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1: RegisterJobSeeker(); break;
                    case 2: LoginJobSeeker(); break;
                    case 3: return;
                    default: Console.WriteLine("Invalid choice!"); break;
                }
            }
        }
    }
}


