using movie.Exceptions;
using movie.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace movie.Services
{
    internal class Theatre
    {
        private List<Moviee> movies = new List<Moviee>();

        public void AddMovie(Moviee movie)
        {
            movies.Add(movie);
        }

        public void RemoveMovie(int movieId)
        {
            Moviee movie = movies.FirstOrDefault(m => m.MovieId == movieId);

            if (movie == null)
            {
                throw new MovieNotFoundException("Movie not found!");
            }

            movies.Remove(movie);
        }

        public Moviee GetMovieById(int movieId)
        {
            Moviee movie = movies.FirstOrDefault(m => m.MovieId == movieId);

            if (movie == null)
            {
                throw new MovieNotFoundException("Movie not found!");
            }

            return movie;
        }

        public void DisplayMovies()
        {
            var sorted = movies.OrderBy(m => m.Title).ToList();

            if (sorted.Count == 0)
            {
                Console.WriteLine("No movies available!");
                return;
            }

            Console.WriteLine("\n--- Available Movies (A–Z) ---");
            foreach (var movie in sorted)
            {
                Console.WriteLine(movie);
            }
        }
    }
}
