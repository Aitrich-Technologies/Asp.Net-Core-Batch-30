using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Book
    {
        public int BookId { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }

        public double Price { get; set; }


        public Book(int bookId, string title, string author, double price)
        {
            BookId = bookId;
            Title = title;
            Author = author;
            Price = price;
        }
        public void displaybook()
        {
            Console.WriteLine($"BookId{BookId},Title{Title},Authot{Author},Price{Price}");
        }
    }
}
