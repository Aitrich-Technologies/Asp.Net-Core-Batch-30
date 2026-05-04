using JobPortalApplication.Manager;
using JobPortalApplication.Models;

internal class Program
{
    private static void Main(string[] args)
    {


        JobPortalManager portal = new JobPortalManager();
        Printer printer = new Printer();

        while (true)
        {
            Console.WriteLine("\n===== JOB PORTAL MENU =====");
            Console.WriteLine("1. Register");
            Console.WriteLine("2. Login");
            Console.WriteLine("3. Exit");
            //Console.WriteLine("3. List Jobs");
            //Console.WriteLine("4. Post Jobs");
            //Console.WriteLine("5. List Interviews");
            //Console.WriteLine("6. Schedule Interview");
            //Console.WriteLine("7. Exit");
            Console.WriteLine("Choose: ");


            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    User u = new User();

                    Console.WriteLine("Enter ID: ");
                    u.Id = int.Parse(Console.ReadLine());

                    Console.WriteLine("First Name: ");
                    u.Firstname = Console.ReadLine();

                    Console.WriteLine("Last Name: ");
                    u.Lastname = Console.ReadLine();

                    Console.WriteLine("Email: ");
                    u.Email = Console.ReadLine();

                    Console.WriteLine("Phone :");
                    u.Phone = Console.ReadLine();

                    Console.WriteLine("Password");
                    u.Password = Console.ReadLine();


                    u.Role = Roles.User;

                    portal.Register(u);
                    break;


                case 2:
                    Console.WriteLine("Email: ");
                    string email = Console.ReadLine();

                    Console.WriteLine("Password: ");
                    string password = Console.ReadLine();

                    var logged = portal.Login(email, password);

                    if (logged == null)
                    {
                        Console.WriteLine("Invalid Login!");
    break;
                    }
                  
                    
                        Console.WriteLine($"Welcome {logged.Firstname}");




                    bool loggedIn = true;

                    while (loggedIn)
                    {
                        Console.WriteLine("3. List Jobs");
                        Console.WriteLine("4. Post Jobs");
                        Console.WriteLine("5. List Interviews");
                        Console.WriteLine("6. Schedule Interview");
                        Console.WriteLine("7. Exit");
                        Console.WriteLine("Choose: ");


                        int choice1 = int.Parse(Console.ReadLine());

                        switch (choice1)
                        {






                            case 3:
                                printer.print(portal.GetJobs());
                                break;

                            case 4:
                                Job j = new Job();
                                Console.Write("Job ID: ");
                                j.Id = int.Parse(Console.ReadLine());
                                Console.WriteLine("Title: ");
                                j.Title = Console.ReadLine();
                                Console.WriteLine("Description: ");
                                j.Description = Console.ReadLine();
                                Console.WriteLine("Location: ");
                                j.Location = Console.ReadLine();
                                Console.WriteLine("Salary: ");
                                j.Salary = Console.ReadLine();
                                Console.WriteLine("Type: ");
                                j.Type = Console.ReadLine();
                                Console.WriteLine("Company: ");
                                j.Company = Console.ReadLine();


                                portal.PostJob(j);
                                break;

                            case 5:
                                printer.print(portal.GetInterviews());
                                break;


                            case 6:
                                Interview i = new Interview();

                                Console.Write("Interview ID: ");
                                i.Id = int.Parse(Console.ReadLine());
                                Console.WriteLine("Comapny: ");
                                i.company = Console.ReadLine();
                                Console.WriteLine("Post: ");
                                i.Post = Console.ReadLine();
                                Console.WriteLine("Date: ");
                                i.Date = Console.ReadLine();
                                Console.WriteLine("Location: ");
                                i.Loaction = Console.ReadLine();
                                Console.WriteLine("Time: ");
                                i.Time = Console.ReadLine();


                                portal.ScheduleInterview(i);

                                break;


                            case 7:
                                Console.WriteLine("You have logged out.");
                                loggedIn = false; // EXIT SECOND MENU
                                break;

                        }
                    }
                    break ;
                case 3:
                    Console.WriteLine("Thank you!");
                    return;
            }
        }
    }
}