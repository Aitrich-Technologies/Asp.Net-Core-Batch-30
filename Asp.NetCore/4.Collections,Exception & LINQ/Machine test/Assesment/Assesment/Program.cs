using Assesment;
using Assesment.Models;
using System;
using System.Collections.Generic;

namespace MovieBookingSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Theatre theatre = new Theatre();
            bool running = true;

            while (running)
            {

                Console.WriteLine("1. Add Movie");
                Console.WriteLine("2. Remove Movie");
                Console.WriteLine("3. Book Tickets");
                Console.WriteLine("4. Cancel Tickets");
                Console.WriteLine("5. Display Movies");
                Console.WriteLine("6. Exit");
                Console.Write("Choose an option: ");

                try
                {
                    int choice = int.Parse(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:
                            Console.Write("Enter Movie ID: ");
                            int id = int.Parse(Console.ReadLine());

                            Console.Write("Enter Title: ");
                            string title = Console.ReadLine();

                            Console.Write("Enter Genre: ");
                            string genre = Console.ReadLine();

                            Console.Write("Enter Available Seats: ");
                            int seats = int.Parse(Console.ReadLine());

                            theatre.AddMovie(new Movie(id, title, genre, seats));
                            break;

                        case 2:
                            Console.Write("Enter Movie ID to remove: ");
                            int removeId = int.Parse(Console.ReadLine());
                            theatre.RemoveMovie(removeId);
                            break;


                    }

                }
                }
        }
    }
}




