using AdminJob.Interface;
using AdminJob.Managers;
using AdminJob.Interface;
using AdminJob.Managers;

namespace Admin_Job
{
    class Program
    {
        public static void Main(string[] args)
        {
            IMenu menu = new PublicManager();
            menu.DisplayMenu();
        }
    }
}
