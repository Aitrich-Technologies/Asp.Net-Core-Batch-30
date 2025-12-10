using System.Collections;
internal class Program
{
    private static void Main(string[] args)
    {
        Hashtable libraryBooks = new Hashtable();

        libraryBooks.Add("978-3-16-148410-0", "the great gatsby");
        libraryBooks.Add("978-1-40-289462-6", "to kill a mockingbird");
        libraryBooks.Add("978-0-7432-7356-5", "the da vinci code");

        Console.WriteLine("Library Books:");
        foreach(DictionaryEntry book in libraryBooks)
        {
            Console.WriteLine($"ISBN: {book.Key},Title: {book.Value}");
        }

        string searchISBN = "978-1-40-289462-6";
        if( libraryBooks.ContainsKey(searchISBN) )
        {
            Console.WriteLine($"\n Book with ISBN {searchISBN} is available: {libraryBooks[searchISBN]}");
        }

        string searchTitle = "the great Gatsby";
        if(libraryBooks.ContainsValue(searchTitle) )
        {
            Console.WriteLine($"\n The book '{searchTitle}' is available in the library.");
        }

        string removeISBN = "978-0-7432-7356-5";
        if(libraryBooks.ContainsKey(removeISBN) )
        {
            libraryBooks.Remove(removeISBN);
            Console.WriteLine($"\n Book with ISBN {removeISBN} has been removed.");
        }

        Console.WriteLine($"\n Total books in library: {libraryBooks.Count}");
        Console.ReadLine();

    }
}