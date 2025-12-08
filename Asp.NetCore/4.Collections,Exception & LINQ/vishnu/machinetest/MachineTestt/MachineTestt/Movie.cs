using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MachineTestt
{
    internal class Movie
    {
        private string? name;

        public int MovieId { get; set; }
        public string Title {  get; set; }
        public string Genre {  get; set; }
        public int AvailableSeats{  get; set; }



        //public Movie (int movieid, string title, string genre,int availableseats)
        //{
        //    MovieId = movieid;
        //    Title = title;
        //    Genre = genre;
        //    AvailableSeats = availableseats;
        //}

        public Movie(string? name, string? genre, int availableseats)
        {
            this.name = name;
            Genre = genre;
            AvailableSeats = availableseats;
        }

        //public Movie()
        //{
        //}


    }
}
