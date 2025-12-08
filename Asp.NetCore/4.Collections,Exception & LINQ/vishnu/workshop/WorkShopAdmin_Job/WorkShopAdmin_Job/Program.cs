using WorkShopAdmin_Job.Interface;
using WorkShopAdmin_Job.Manager;

 class Program
{
    public static void Main(string[] args)
    {

        IMenu menu = new PublicManager();
        menu.DisplayMenu();
    

    }
}