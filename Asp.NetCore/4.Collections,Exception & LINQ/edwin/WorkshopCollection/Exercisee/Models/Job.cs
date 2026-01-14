using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercisee.Models
{
    public class Job
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Company { get; set; }
        public decimal Salary { get; set; }

        public override string ToString()
        {
            return $"[{Id}] {Title} - {Company} (Salary: {Salary:C})";
        }
    }
}
