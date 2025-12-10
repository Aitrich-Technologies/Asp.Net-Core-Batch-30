using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssessmentCollection
{
    public class Movie
    {
        private int MovieId;
        private string Title;
        private string Genre;
        private int AvailableSeats;

        public int movieId
        {
            get { return MovieId; }
            set
            {
                if (value <= 0)
                    throw new Exception("Movie ID can't be negative or zero");
                MovieId = value;
            }
        }

        public string title
        {
            get { return Title; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new Exception("Title cannot be empty");

                Title = value;
            }
        }

        public string genre
        {
            get { return Genre; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new Exception("Genre cannot be empty");

                Genre = value;
            }
        }

        public int availableseats
        {
            get { return AvailableSeats; }
            set
            {
                if (value < 0)
                    throw new Exception("Seats can't be negative");

                AvailableSeats = value;
            }
        }

        public Movie(int movieid, string title, string genre, int availableseats)
        {
            movieId = movieid;
            this.title = title;
            this.genre = genre;
            this.availableseats = availableseats;
        }

        public void BookTickets(int seats)
        {
            if (seats <= 0)
                throw new Exception("Seats to book must be greater than zero");

            if (AvailableSeats >= seats)
            {
                AvailableSeats -= seats;
                Console.WriteLine($"{seats} Tickets booked successfully!");
            }
            else
            {
                throw new Exception("Not enough seats available");
            }
        }

        public void CancelTickets(int seats)
        {
            if (seats <= 0)
                throw new Exception("Seats to cancel must be greater than zero");

            AvailableSeats += seats;
            Console.WriteLine($"{seats} Tickets cancelled successfully!");
        }
    }
}

