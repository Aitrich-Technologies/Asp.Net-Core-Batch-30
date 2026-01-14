using Libray;

internal class Program
{
    private static void Main(string[] args)
    {
        EBook ebook = new EBook("B001", "C# Fundamentals", "John Doe", 5, 5, "PDF");
        PrintedBook pbook = new PrintedBook("B002", "Design Patterns", "Gamma et al.", 3, 395, "Addison-Wesley");

        BorrowTransaction bt = new BorrowTransaction(2);

        bt.TransactionID = "002";
        bt.MemberName = "Vishnu";
        bt.TransactionDate = DateTime.Now;

        bt.BorrowedBooks[0]=ebook;
        bt.BorrowedBooks[1]=pbook;

        int lateDays = 3;

        Console.WriteLine("Books Borrowed:");

        if (bt.BorrowedBooks[0] is EBook)
        {
            EBook e = (EBook)bt.BorrowedBooks[0];
            Console.WriteLine("EBook: " + e.Title + " by " + e.Author + " Size: " + e.FileSizeMB + "MB");
        }

        if (bt.BorrowedBooks[1] is PrintedBook)
        {
            PrintedBook p = (PrintedBook)bt.BorrowedBooks[1];
            Console.WriteLine("PrintedBook: " + p.Title + " by " + p.Author + " Pages: " + p.Pages);
        }
        Console.WriteLine();
        Console.WriteLine("Transaction ID: " + bt.TransactionID);
        Console.WriteLine("Member: " + bt.MemberName);
        Console.WriteLine("Late Days: " + lateDays);
        Console.WriteLine("Fine: $" + bt.CalculateFine(lateDays));

    }
}