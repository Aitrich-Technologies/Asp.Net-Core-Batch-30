using Exercise_oops.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_oops.Manager
{
    public class Printer
    {
       public void Print(Job[] jobs)
        {
            Console.WriteLine("---Jobs---");
            foreach(var job in jobs)
            {
                if(job==null)continue;
                Console.WriteLine($"{job.Id} - {job.Title} ({job.Company})");
            }
        }
        public void Print(Application[] applications)
        {
            Console.WriteLine("---Applications---");
            foreach(var application in applications)
            {
                if(application==null)continue;
                Console.WriteLine($"{application.Id}- {application.Name} ({application.Qualification})");
            }
        }
        public void Print(Interview[] interviews)
        {
            Console.WriteLine("---Interview");
            foreach(var interview in interviews)
            {
                if(interview==null) continue;
                Console.WriteLine($"{interview.Id}-{interview.Company} on{interview.Date}at{interview.Time}");
            }
        }
    }
}

