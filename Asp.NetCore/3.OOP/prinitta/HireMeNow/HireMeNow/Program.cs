<<<<<<< HEAD
﻿
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
=======
﻿
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
>>>>>>> c65346a8715ef5f84b526c46ede8030b3555f835
