
using HireMeNow.enums;
using HireMeNow.managers;

namespace HireMeNow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            JobManager jobManager = new JobManager();
            JobSeekerManager jobSeekerManager = new JobSeekerManager(jobManager);

            jobSeekerManager.ShowMainMenu();
        }
    }
}
