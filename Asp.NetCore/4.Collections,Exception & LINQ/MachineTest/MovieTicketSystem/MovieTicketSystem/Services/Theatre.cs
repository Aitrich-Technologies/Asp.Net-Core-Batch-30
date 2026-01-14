using MovieTicketSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MovieTicketSystem.Services
{
    public class Theatre
    {
        private List<Movie> movies = new List<Movie>();

        public void AddMovie(Movie movie)
        {
            movies.Add(movie);
            Console.WriteLine("movie added successfully");
        }
        public void RemoveMovie(int id)
        {
            Movie movie = movies.Find(m => m.MovieId == id);

            if (movie == null)
                throw new Exception("Movie not found.  failed.");

            movies.Remove(movie);
            Console.WriteLine("Movie removed successfully!");
        }
        public Movie GetMovie(int id)
        {
            return movies.Find(m => m.MovieId == id);
        }

        public void DisplayMovie(Movie movie)
        {
            if (movies.Count == 0)
            {
                Console.WriteLine("No movies available.");
                return;
            }
            foreach (var m in movies)
            {
                Console.WriteLine(m);
            }
        }






    }
}
