using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment.Models
{
    public class Movie
    {
        public int id { get; set; }
        public string Title { get; set; }
        public string genre { get; set; }
        public int AvailableSeats { get; set; }

        public Movie(int id, string title, string genre, int AvailableSeats)
        {
            id = id;
            title = title;
            genre = genre;
            AvailableSeats = AvailableSeats;
        }

        public void BookTickets(int count)
        {
            if (count <= 0)
                throw new Exception("Ticket count must be greater than zero.");

            if (count > AvailableSeats)
                throw new Exception("Not enough seats available for booking.");

            AvailableSeats -= count;
            Console.WriteLine($"Successfully booked {count} ticket(s) for {Title}.");
        }

      
        public void CancelTickets(int count)
        {
            if (count <= 0)
                throw new Exception("Invalid cancellation count.");

            AvailableSeats += count;
            Console.WriteLine($"{count} ticket(s) cancelled for {Title}.");
        }
    }
}
