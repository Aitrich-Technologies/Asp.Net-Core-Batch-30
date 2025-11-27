using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libray
{
    internal class BorrowTransaction:Transaction
    {
        public Book[] BorrowedBooks;
        public BorrowTransaction(int bookCount)
        {
            BorrowedBooks = new Book[bookCount];
        }
        public override decimal CalculateFine(int daysLate)
        {
            return daysLate * 2;
        }
    }
}
