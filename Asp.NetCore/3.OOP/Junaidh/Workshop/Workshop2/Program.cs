using Workshop2.Managers;

internal class Program
{
    private static void Main(string[] args)
    {
        JobManager jobManager = new JobManager();       
        PublicManager publicManager = new PublicManager(jobManager);  
        publicManager.DisplayMenu();
    }
}