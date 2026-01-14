using Movies.Exceptions;
using Movies.models;

using Movies.Exceptions;
using Movies.models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Movies.Services
{
    public class Theatre
    {
        private List<Movie> movies = new List<Movie>();

       public void AddMovie(Movie movie)
        {
            movies.Add(movie);
        }

        public void RemoveMovie(int movieId)
        {
            Movie movie = movies.FirstOrDefault(m => m.MovieId == movieId);

            if (movie == null)
            {
                throw new MovieNotFoundException("Movie not found!");
            }

            movies.Remove(movie);
        }

        public Movie GetMovieById(int movieId)
        {
            Movie movie = movies.FirstOrDefault(m => m.MovieId == movieId);

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
