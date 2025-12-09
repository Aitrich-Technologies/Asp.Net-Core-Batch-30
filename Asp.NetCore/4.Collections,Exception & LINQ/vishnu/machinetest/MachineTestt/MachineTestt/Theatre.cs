using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MachineTestt
{
    internal class Theatre
    {

       private  List <Movie > movies=new List<Movie>() ;


        public void AddMovies(Movie movie)
        {
            movies.Add(movie);
            Console.WriteLine("Movie added");
        }
       


        //public void RemoveMovies(Movie movie)
        //{
        //    movies.Remove(movie);
        //    Console.WriteLine("Movie removed");
        //}

      
        public void Display()
        {
            foreach (var m in movies)
            {
                Console.WriteLine(m);
            }

        }

        //internal void RemoveMovies(string? removename)
        //{

        //    throw new NotImplementedException();
        //}



        public void Removemovie(string moviename)
        {

            Movie movie = movies .Find(x => x.Title == moviename);


            movies .Remove(movie );
            Console.WriteLine("Movie removed");
        }






    }
}
