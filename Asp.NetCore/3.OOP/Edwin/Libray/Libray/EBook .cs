using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libray
{
    internal class EBook:Book
    {
        public double FileSizeMB {  get; set; }
        public string Format {  get; set; }

        public EBook(string bookID,string title, string author, int copiesAvaliable,double fileSizemb,string format): base(bookID, title, author, copiesAvaliable)
        {
            FileSizeMB = fileSizemb;
            Format=format;
        }
    }
}
