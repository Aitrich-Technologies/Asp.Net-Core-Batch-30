
using MovieTicketSystem.Models;
using MovieTicketSystem.Services;
using System;
using System.Linq.Expressions;

internal class Program
{
    static void Main(string[] args)
    {
        Theatre theatre = new Theatre();

        while (true)
        {

            Console.WriteLine("1. Add Movie");
            Console.WriteLine("2. Remove Movie");
            Console.WriteLine("3. Display Movies");
            Console.WriteLine("4. Book Tickets");
            Console.WriteLine("5. Cancel Tickets");
            Console.WriteLine("6. Exit");
            Console.Write("Enter Option: ");
            string opt = Console.ReadLine();

            try
            {
                switch (opt)
                {
                    case "1":
                        Console.Write("Movie ID: ");
                        int id = int.Parse(Console.ReadLine());

                        Console.Write("Title: ");
                        string title = Console.ReadLine();

                        Console.Write("Genre: ");
                        string genre = Console.ReadLine();

                        Console.Write("Available Seats: ");
                        int seats = int.Parse(Console.ReadLine());

                        theatre.AddMovie(new Movie(id, title, genre, seats));
                        break;

                    case "2":
                        Console.Write("Enter Movie ID to Remove: ");
                        int removeId = int.Parse(Console.ReadLine());
                        theatre.RemoveMovie(removeId);
                        break;

                    case "3":
                        Console.Write("Enter movie to display:");
                        int displayId = int.Parse(Console.ReadLine());
                        
                        break;
                        
                        

                    case "4":
                        Console.Write(" Enter  a movie to book a ticket:");
                        int tickets = int.Parse(Console.ReadLine());
                        break;
                    case "5":
                        Console.Write("enter a id to cancel a ticket");
                        int removeticket = int.Parse(Console.ReadLine());
                        break;

                       

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine( "Error: {ex.Message}");
            }
        }
    }
}







