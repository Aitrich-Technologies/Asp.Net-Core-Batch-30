using Exercise._2.managers;

internal class Program
{
    private static void Main(string[] args)
    {
 
        JobManager jobManager = new JobManager();       
        PublicManager publicManager = new PublicManager(jobManager);  
        publicManager.DisplayMenu();
    }
}
