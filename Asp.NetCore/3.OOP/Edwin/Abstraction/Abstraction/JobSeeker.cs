using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    public class JobSeeker:User
    {
        public string FirstName {  get; set; }
        public string LastName { get; set; }
        public string Loation {  get; set; }
        public string Phone {  get; set; }

        public void ApplyJob(int jobId)
        {
            Console.WriteLine("Applying job started");
        }
        public override void Welcome()
        {
            Console.WriteLine("Welcome to Hire me Now");
        }
    }
}
