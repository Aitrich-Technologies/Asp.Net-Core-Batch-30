using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssessmentCollection
{
    public class Theatre
    {
        public List<Movie> movies = new List<Movie>();

        public void AddMovies(Movie movie)
        {
            movies.Add(movie);
            Console.WriteLine($"{movie.title} added to the movie list.");
        }

        public void RemoveMovies(Movie movie)
        {
            if (movies.Contains(movie))
            {
                movies.Remove(movie);
                Console.WriteLine($"{movie.title} removed from the list.");
            }
            else
            {
                throw new Exception("Error: Movie not found in the list.");
            }
        }

        public void Display()
        {
            if (movies.Count == 0)
            {
                Console.WriteLine("No movies available.");
                return;
            }

            Console.WriteLine("\n--- Available Movies ---");
            foreach (var movie in movies)
            {
                Console.WriteLine($"Movie ID: {movie.movieId}");
                Console.WriteLine($"Title: {movie.title}");
                Console.WriteLine($"Genre: {movie.genre}");
                Console.WriteLine($"Available Seats: {movie.availableseats}");
             
            }
        }
    }

}
