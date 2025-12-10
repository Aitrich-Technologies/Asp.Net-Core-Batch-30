using AssessmentCollection;

internal class Program
{
    private static void Main(string[] args)
    {
        Theatre theatre = new Theatre();

        while (true)
        {
            Console.WriteLine("===== Ticket Booking System =====");
            Console.WriteLine("1. Add Movie");
            Console.WriteLine("2. Remove Movie");
            Console.WriteLine("3. Book Tickets");
            Console.WriteLine("4. Cancel Tickets");
            Console.WriteLine("5. Display All Movies");
            Console.WriteLine("6. Exit");
            Console.Write("Enter your choice: ");

            string choice = Console.ReadLine();
            Console.WriteLine();

            try
            {
                switch (choice)
                {
                    case "1":
                        Console.Write("Enter Movie ID: ");
                        int id = int.Parse(Console.ReadLine());

                        Console.Write("Enter Title: ");
                        string title = Console.ReadLine();

                        Console.Write("Enter Genre: ");
                        string genre = Console.ReadLine();

                        Console.Write("Enter Available Seats: ");
                        int seats = int.Parse(Console.ReadLine());

                        Movie movie = new Movie(id, title, genre, seats);
                        theatre.AddMovies(movie);
                        break;

                    case "2":
                        Console.Write("Enter Movie ID to remove: ");
                        int removeId = int.Parse(Console.ReadLine());

                       
                        break;

                    case "3":
                        Console.Write("Enter Movie ID to book tickets: ");
                        int bookId = int.Parse(Console.ReadLine());

                        break;

                    case "4":
                        Console.Write("Enter Movie ID to cancel tickets: ");
                        int cancelId = int.Parse(Console.ReadLine());
                        break;

                    case "5":
                        theatre.Display();
                        break;

                    case "6":
                        Console.WriteLine("Exiting system...");
                        return;

                    default:
                        Console.WriteLine("Invalid option, please try again.");
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

    }
}