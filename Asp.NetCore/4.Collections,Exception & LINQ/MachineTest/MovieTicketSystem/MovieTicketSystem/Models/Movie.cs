using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieTicketSystem.Models
{
    public class Movie
    {
        public int MovieId { get;  set; }

        public string Title { get;  set; }

        public string Genre { get;   set; }

        public int AvaliableSeat { get;  set; }


        public Movie( int movieid, string title, string genre, int availableseat)
        {
            MovieId = movieid;
            Title = title;
            Genre = genre;
            AvaliableSeat = availableseat;
        }

        public void BookTickets( int  Count)
        {
            if(Count<0)
            {
                throw new Exception("seats never less than zero");
            }
            if(Count>AvaliableSeat)
            {
                throw new Exception("no more seats available");
            }
            AvaliableSeat =- Count;
            Console.WriteLine($"Booking successful {Count} ticket(s) booked for {Title}. Remaining seats: {AvaliableSeat}");
        }

        public override string ToString()
        {
            return $"ID: {MovieId}, Title: {Title}, Genre: {Genre}, Seats Available: {AvaliableSeat}";

        }


    }
}
