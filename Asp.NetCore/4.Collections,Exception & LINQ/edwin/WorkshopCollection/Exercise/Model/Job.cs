using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise.Model
{
    public class Job
    {
        internal int Id;

        public int JobId { get; set; }
        public string Title { get; set; }
        public string Company { get; set; }

        public Job(int id, string title, string company)
        {
            JobId = id;
            Title = title;
            Company = company;
        }

        public override string ToString()
        {
            return $"{JobId}. {Title} at {Company}";
        }
    }
}
