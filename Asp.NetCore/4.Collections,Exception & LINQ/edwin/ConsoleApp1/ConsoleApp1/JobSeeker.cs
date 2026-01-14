using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class JobSeeker
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //public void ApplyJob(int Jobid)
        //{
        //    Console.WriteLine("Applying job started");
        //}


        public JobSeeker(int id, string firstName, string lastName)
        {
            Id=id;
            FirstName=firstName;
            LastName=lastName;
        }
    }
}
