using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace workshop1.Models
{
    public class job
    {
        public int id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public string salary { get; set; }
        public string Location { get; set; }

        public job(int id, string title, string description, string salary,string location)
        {
            this.id = id;
            this.title = title;
            this.description = description;
            this.salary = salary;
        }
    }
}
