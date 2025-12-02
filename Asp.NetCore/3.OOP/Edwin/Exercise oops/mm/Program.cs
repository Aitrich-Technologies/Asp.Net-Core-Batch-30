using mm.Manaher;
using mm.Model;

internal class Program
{
    private static void Main(string[] args)
    {
        JobPortal portal = new JobPortal();
        Printer printer = new Printer();

        
        portal.AddApplication(new Application
        {
            Id = 1,
            Name = "Edwin",
            Location = "Kottayam",
            Qualification = "BCA",
            Experience = "1 Year"
        });

        int choice = 0;

        while (choice != 4)
        {
            Console.WriteLine("\n---- Job Portal ----");
            Console.WriteLine("1. Manage Jobs");
            Console.WriteLine("2. View Applications");
            Console.WriteLine("3. Manage Interviews");
            Console.WriteLine("4. Exit");
            Console.Write("Enter choice: ");
            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("\n1. List Jobs\n2. Post Job");
                    int j = int.Parse(Console.ReadLine());

                    if (j == 1)
                        printer.Print(portal.GetJobs());
                    else
                    {
                        Job job = new Job();
                        Console.Write("ID: "); job.Id = int.Parse(Console.ReadLine());
                        Console.Write("Title: "); job.Title = Console.ReadLine();
                        Console.Write("Description: "); job.Description = Console.ReadLine();
                        Console.Write("Location: "); job.Location = Console.ReadLine();
                        Console.Write("Salary: "); job.Salary = Console.ReadLine();
                        Console.Write("Type: "); job.Type = Console.ReadLine();
                        Console.Write("Company: "); job.Company = Console.ReadLine();

                        portal.PostJob(job);
                    }
                    break;

                case 2:
                    printer.Print(portal.GetApplications());
                    break;

                case 3:
                    Console.WriteLine("\n1. List Interviews\n2. Schedule Interview");
                    int i = int.Parse(Console.ReadLine());

                    if (i == 1)
                        printer.Print(portal.GetInterviews());
                    else
                    {
                        Interview interview = new Interview();
                        Console.Write("ID: "); interview.Id = int.Parse(Console.ReadLine());
                        Console.Write("Company: "); interview.Company = Console.ReadLine();
                        Console.Write("Post: "); interview.Post = Console.ReadLine();
                        Console.Write("Date: "); interview.Date = Console.ReadLine();
                        Console.Write("Location: "); interview.Location = Console.ReadLine();
                        Console.Write("Time: "); interview.Time = Console.ReadLine();

                        portal.ScheduleInterview(interview);
                    }
                    break;
            }
        }
    }
}
    
