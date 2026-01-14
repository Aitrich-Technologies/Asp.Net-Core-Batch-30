using WorkshopCollection.InterFace;
using WorkshopCollection.Manager;

internal class Program
{
    private static void Main(string[] args)
    {
        IMenu menu = new PublicManager();
        menu.DisplayMenu();
    }
}