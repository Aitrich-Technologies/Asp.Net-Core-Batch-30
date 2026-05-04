using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adminjob.Model
{
    internal class Job
    {


        public int Id { get; set; }
        public string title { get; set; }
        public string Description { get; set; }
        
        public string salary {  get; set; }

        public string Location {  get; set; }


        public Job(int id, string title, string description, string salary, string location)
        {
            Id = id;
            this.title = title;
            Description = description;
            this.salary = salary;
            Location = location;
        }


    }
}
