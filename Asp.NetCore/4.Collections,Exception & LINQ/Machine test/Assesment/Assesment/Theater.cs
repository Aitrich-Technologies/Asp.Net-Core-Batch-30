using Assesment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Assesment
{
    public class Theatre
    {
        private List<Movie> movies;

        public Theatre()
        {
            movies = new List<Movie>();
        }

        public void AddMovie(Movie movie)
        {
            movies.Add(movie);
        }

       
        public void RemoveMovie(int movieId)
        {
            try
            {
                Movie movie = movies.Find(m => m.id == movieId);

                if (movie == null)
                {
                    throw new Exception("Movie does not exist in the theatre.");
                }

                movies.Remove(movie);
                Console.WriteLine("Movie removed successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        public void DisplayMovies()
        {
            if (movies.Count == 0)
            {
                Console.WriteLine("No movies available.");
                return;
            }

            foreach (var m in movies)
            {
                Console.WriteLine($"{m.id} - {m.Title} - {m.genre} - Seats: {m.AvailableSeats}");
            }
        }
    }
}

