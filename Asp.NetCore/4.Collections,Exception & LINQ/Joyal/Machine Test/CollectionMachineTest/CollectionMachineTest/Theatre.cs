using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CollectionMachineTest
{
    public class Theatre
    {
        public List<Movie> Movies = new List<Movie>();

        public void AddMovie(Movie movie)
        {
            Movies.Add(movie);
            Console.WriteLine("Movie added successfully.");
        }

        public void SortMovie()
        {
            if (Movies == null || Movies.Count == 0)
            {
                Console.WriteLine("No movies to sort.");
                return;
            }

            var sorted = Movies.OrderBy(m => m.Title).ToList();

            Console.WriteLine("\nSorted Movie List");
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("{0,-10} | {1,-20}", "MovieId", "Title");
            Console.WriteLine("-------------------------------------------------");

            foreach (var movie in sorted)
            {
                Console.WriteLine("{0,-10} | {1,-20}", movie.MovieId, movie.Title);
            }

            Console.WriteLine("-------------------------------------------------\n");
        }

        public void RemoveMovie(int id)
        {
            Movie movie = Movies.Find(m => m.MovieId == id);

            if (movie == null)
                throw new Exception("Movie not found.");

            Movies.Remove(movie);
            Console.WriteLine("Movie removed successfully!\n");
        }

        public void DisplayMovies()
        {
            Console.WriteLine("Movies in Theatre:");
            Console.WriteLine("--------------------------------------------------------------");
            Console.WriteLine("{0,-10} | {1,-20} | {2,-15} | {3,-10}", "MovieId", "Title", "Genre", "Available Seats");
            Console.WriteLine("--------------------------------------------------------------");

            if (Movies.Count == 0)
            {
                Console.WriteLine("No movies in the list.");
            }
            else
            {
                foreach (Movie movie in Movies)
                {
                    Console.WriteLine("{0,-10} | {1,-20} | {2,-15} | {3,-10}",
                        movie.MovieId, movie.Title, movie.Genre, movie.Availableseats);
                }
            }

            Console.WriteLine("--------------------------------------------------------------\n");
        }

        public Movie GetMovieById(int id)
        {
            return Movies.Find(m => m.MovieId == id);
        }

        public Movie GetMovieByName(string name)
        {
            return Movies.Find(m => m.Title.Equals(name, StringComparison.OrdinalIgnoreCase));
        }
    }
}
    