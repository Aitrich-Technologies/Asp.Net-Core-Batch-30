internal class Program
{
    private static void Main(string[] args)
    {
        List<string> list = new List<string>();
        while (true)
        {

            try
            {
                Console.WriteLine("----Movies-----");
                Console.WriteLine("1. Add movie");
                Console.WriteLine("2. Remove movie");
                Console.WriteLine("3. Book Tickets");
                Console.WriteLine("4.Cancel Tickets");
                Console.WriteLine("5.Exit");
                switch (Console.ReadLine())
                {
                    case "1":
                        Console.WriteLine("Movie ");
                        string movie = Console.ReadLine();
                        break;
                        case "2":
                        Console.WriteLine("Remove Movie");
                            string rmovie= Console.ReadLine();
                        break;
                        case "3":
                        Console.WriteLine("	Book tickets");
                        string bmovie= Console.ReadLine();
                        break;
                        case "4":
                        Console.WriteLine("Cancel tickets");
                        string cmovie = Console.ReadLine();
                        break;
                        default:
                        break;


                }
            }

            catch (Exception e)
            {
                Console.WriteLine(e.Message);

            }
        }
    }
}