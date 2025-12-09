using AdminJob.Interface;
using AdminJob.Manager;

internal class Program
{
    public static void Main(string[] args)
    {
        IMenu menu = new PublicManager();
        menu.DisplayMenu();
    }
}