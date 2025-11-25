using HiringManagement.Managers;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("==== JOB HIRING MANAGEMENT SYSTEM ====\n");

        // Create JobManager
        JobManager jobManager = new JobManager();

        // Create Public Manager (login/registration controller)
        PublicManager publicManager = new PublicManager(jobManager);

        // Start system
        publicManager.DisplayMenu();

        Console.WriteLine("\nExiting system... Goodbye!");
    }
}