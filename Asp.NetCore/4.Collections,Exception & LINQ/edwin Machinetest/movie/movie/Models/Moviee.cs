
using movie.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace movie.Models
{
    public class Moviee
    {

        public int MovieId { get; set; }
        public string Title { get; set; }
        public string Genre { get; set; }
        public int AvailableSeats { get; set; }

        public Moviee(int movieId, string title, string genre, int seats)
        {
            MovieId = movieId;
            Title = title;
            Genre = genre;
            AvailableSeats = seats;
        }

        public void BookTickets(int count)
        {
            if (count > AvailableSeats)
            {
                throw new SeatNotAvailableException("Not enough seats available!");
            }
            AvailableSeats -= count;
        }

        public void CancelTickets(int count)
        {
            AvailableSeats += count;
        }

        public override string ToString()
        {
            return $"[{MovieId}] {Title} | Genre: {Genre} | Seats: {AvailableSeats}";
        }
    }
}
