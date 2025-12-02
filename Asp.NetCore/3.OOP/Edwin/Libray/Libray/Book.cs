using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libray
{
    internal class Book
    {
        private string bookID;
        private string title;
        private string author;
        private int copiesAvailable;


        public string BookID
        {
            get { return bookID; }
            set { bookID = value; }

        }
        public string Title
        {
            get { return title; }
            set { title = value; }
        }
        public string Author
        {
            get { return author; }
            set { author = value; }
        }
        public int CopiesAvailable
        {
            get { return copiesAvailable;}
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("copies cannot be negative. setting to 0.");
                    copiesAvailable = 0;
                }
                else
                {
                    copiesAvailable = value; 
                }
            }
        }
        public Book(string  bookID,string title, string author,int copiesAvaliable)
        {
            BookID = bookID;
            Title = title;
            Author = author;
            CopiesAvailable= copiesAvaliable;
        }
    
    }
   
}
