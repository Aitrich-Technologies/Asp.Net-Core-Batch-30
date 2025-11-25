using JobPortalApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobPortalApplication.Manager
{
    internal class Printer
    {

        public void print(Job[] jobs)
        {
            foreach (var j in jobs)
            {
                if (j == null) continue;
                Console.WriteLine($"{j.Id } | {j.Title } | {j.Company } | {j.Location } | {j.Type } | {j.Salary }");
            }


        }

        public void print(Interview[] interviews)
        {
            foreach (var i in interviews)
            {
                if (i == null) continue;
   
         Console.WriteLine($"{i.Id} | {i.company } | {i.Post} | {i.Date} | {i.Time} | {i.Loaction}");
            }
        }
    }
}