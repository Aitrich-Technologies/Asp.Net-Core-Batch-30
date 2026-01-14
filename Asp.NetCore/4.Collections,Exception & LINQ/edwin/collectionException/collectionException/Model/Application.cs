using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace collectionException.Model
{
    public class Application
    {
        public int Id;
        public string Name;
        public string Location;
        public string Qualification;
        public string Experience;

        public override string ToString()
        {
            return $"{Id}. {Name} | {Location} | {Qualification} | {Experience}";
        }
    }
}
