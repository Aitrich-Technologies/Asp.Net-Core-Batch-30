using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionMachineTest
{
    public class Movie
    {
        private int movieid;
        private string title;
        private string genre;
        private int availseats;

        public int MovieId { get { return movieid; } set { movieid = value; } }

        public string Title { get { return title; } set { title = value; } }
        public string Genre { get { return genre; } set { genre = value; } }

        public int Availableseats { get { return availseats; } set { availseats = value; } }

        public Movie(int movieid, string title, string genre, int availseats)
        {
            MovieId = movieid;
            Title = title;
            Genre = genre;
            Availableseats = availseats;
        }

        public void BookTickets(int count)
        {
            if (count <= 0)
            {
                throw new Exception("Invalid Ticket count");
            }

            if (count > Availableseats)
            {
                throw new Exception("No seats available");
            }

            Availableseats -= count;
        }

        public void CancelTickets(int count)
        {
            if (count <= 0) { throw new Exception("Invalid ticket count"); }
            if (count > Availableseats)
            {
                throw new Exception("booked seats can only cancel");
            }
            Availableseats += count;
        }

    }
}
