using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace collectionException.Model
{
    public class Job
    {
        public int JobId;
        public string Title;
        public string Description;
        public string Company;
        public string Location;
        public string SalaryRange;
        public string JobType;

        public override string ToString()
        {
            return $"{JobId}. {Title} | {Company} | {Location} | {SalaryRange} | {JobType}";
        }
    }

}
