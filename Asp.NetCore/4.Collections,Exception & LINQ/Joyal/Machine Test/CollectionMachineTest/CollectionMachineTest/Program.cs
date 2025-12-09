using CollectionMachineTest;

internal class Program
{
    static void Main(string[] args)
    {
        Theatre t = new Theatre();
        while (true)
        {
            Console.WriteLine("==Movie Ticket booking==");
            Console.WriteLine("1.Add Movie \n2.Sort Movies \n3.Remove Movie \n4.book Tickets \n5.Cancel Tickets \n6.Display Movies \n7.Exit");
            Console.WriteLine("Enter your choice:");

            try
            {
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.Write("Enter Movie Id:");
                        int id = int.Parse(Console.ReadLine());

                        Console.Write("Enter Movie title:");
                        string title = Console.ReadLine();

                        Console.Write("Enter Movie Genre:");
                        string genre = Console.ReadLine();

                        Console.Write("Enter Available seats:");
                        int seats = int.Parse(Console.ReadLine());
                        t.AddMovie(new Movie(id, title, genre, seats));
                        break;

                    case 2:
                        t.SortMovie();
                        break;

                    case 3:
                        Console.Write("Enter Movie Id to remove:");
                        int removeid = int.Parse(Console.ReadLine());
                        t.RemoveMovie(removeid);
                        break;
                    case 4:
                        Console.Write("Enter Movie ID: ");
                        int bookId = Convert.ToInt32(Console.ReadLine());

                        Movie movie1 = t.GetMovieById(bookId);
                        if (movie1 == null)
                        {
                            Console.WriteLine("Movie not found.");
                            break;
                        }

                        Console.Write("Enter number of tickets: ");
                        int tickets = Convert.ToInt32(Console.ReadLine());

                        movie1.BookTickets(tickets);
                        Console.WriteLine("Tickets booked successfully!\n");
                        break;

                    case 5:
                        Console.Write("Enter Movie ID: ");
                        int cancelId = Convert.ToInt32(Console.ReadLine());

                        Movie movie2 = t.GetMovieById(cancelId);
                        if (movie2 == null)
                        {
                            Console.WriteLine("Movie not found.");
                            break;
                        }

                        Console.Write("Enter number of tickets to cancel: ");
                        int cancel = Convert.ToInt32(Console.ReadLine());

                        movie2.CancelTickets(cancel);
                        Console.WriteLine("Tickets cancelled successfully!\n");
                        break;

                    case 6:
                        t.DisplayMovies();
                        break;

                    case 7:
                        Console.WriteLine("Exiting....");
                        return;

                    default:
                        Console.WriteLine("Invalid Choice");
                        break;
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error" + ex.Message + "\n");
            }
        }
    }
}