<<<<<<< HEAD
﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using workshop1.interfaces;
using workshop1.Models;

namespace workshop1.Manager
{
    public class jobmanager 
    {
        private int num_jobs = 0;
        private job[] jobs = new job[100];
       
        public void addjob()
        {
            if (num_jobs == jobs.Length)
            {
                Console.WriteLine("Maximum number of jobs reached. Please try again later.");
                return;
            }
            Console.Write("Enter job id: ");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter job title: ");
            string title = Console.ReadLine();

            Console.Write("Enter job description: ");
            string description = Console.ReadLine();
            Console.Write("Enter job salary: ");
            string salary = Console.ReadLine();
            Console.Write("Enter job location: ");
            string location = Console.ReadLine();
            job newJob = new job(id, title, description, salary, location);

            jobs[num_jobs] = newJob;
            num_jobs++;



            Console.WriteLine("Job added successfully.");
        }
        

        public void ListJob()
        {
            Console.WriteLine("Jobs:");
            for (int i = 0; i < num_jobs; i++)
            {
                Console.WriteLine($"Title: {jobs[i].title}");
                Console.WriteLine($"Description: {jobs[i].description}");
                Console.WriteLine($"salary: {jobs[i].salary}");
                Console.WriteLine($"Location: {jobs[i].Location}");
            }
        }
    }
}

      
   
=======
﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using workshop1.interfaces;
using workshop1.Models;

namespace workshop1.Manager
{
    public class jobmanager 
    {
        private int num_jobs = 0;
        private job[] jobs = new job[100];
       
        public void addjob()
        {
            if (num_jobs == jobs.Length)
            {
                Console.WriteLine("Maximum number of jobs reached. Please try again later.");
                return;
            }
            Console.Write("Enter job id: ");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter job title: ");
            string title = Console.ReadLine();

            Console.Write("Enter job description: ");
            string description = Console.ReadLine();
            Console.Write("Enter job salary: ");
            string salary = Console.ReadLine();
            Console.Write("Enter job location: ");
            string location = Console.ReadLine();
            job newJob = new job(id, title, description, salary, location);

            jobs[num_jobs] = newJob;
            num_jobs++;



            Console.WriteLine("Job added successfully.");
        }
        

        public void ListJob()
        {
            Console.WriteLine("Jobs:");
            for (int i = 0; i < num_jobs; i++)
            {
                Console.WriteLine($"Title: {jobs[i].title}");
                Console.WriteLine($"Description: {jobs[i].description}");
                Console.WriteLine($"salary: {jobs[i].salary}");
                Console.WriteLine($"Location: {jobs[i].Location}");
            }
        }
    }
}

      
   
>>>>>>> c65346a8715ef5f84b526c46ede8030b3555f835
