using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libray
{
    internal class PrintedBook:Book
    {
        public int Pages {  get; set; }
        public string Publisher {  get; set; }

        public  PrintedBook(string bookID, string title, string author, int copiesAvaliable,int pages,string publisher) : base(bookID, title, author, copiesAvaliable)
        {
            Pages = pages;
            Publisher = publisher;
        }
    }
}
