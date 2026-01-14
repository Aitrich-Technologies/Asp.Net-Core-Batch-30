using mm.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mm.Manaher
{
    public class Printer
    {
        public void Print(Job[] jobs)
        {
            Console.WriteLine("\n--- Jobs ---");
            foreach (var j in jobs)
            {
                if (j == null) continue;
                Console.WriteLine($"{j.Id} - {j.Title} ({j.Company})");
            }
        }
        public void Print(Application[] applications)
        {
            Console.WriteLine("\n--- Applications ---");
            foreach (var a in applications)
            {
                if (a == null) continue;
                Console.WriteLine($"{a.Id} - {a.Name} ({a.Qualification})");
            }
        }
        public void Print(Interview[] interviews)
        {
            Console.WriteLine("\n--- Interviews ---");
            foreach (var i in interviews)
            {
                if (i == null) continue;
                Console.WriteLine($"{i.Id} - {i.Company} on {i.Date} at {i.Time}");
            }
        }
    }
}
