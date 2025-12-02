using System.Collections;

internal class Program
{
    private static void Main(string[] args)
    {
        Hashtable libraryBooks = new Hashtable();

        libraryBooks.Add("978-3-16-148410-0", "The Great Gatsby");
        libraryBooks.Add("978-1-40-289462-6", "To Kill a Mockingbird");
        libraryBooks.Add("978-0-7432-7356-5", "The Da Vinci Code");

        Console.WriteLine("Library Books:");
        foreach (DictionaryEntry book in libraryBooks)
        {
            Console.WriteLine($"ISBN: {book.Key}, Title: {book.Value}");
        }


        String searchISBN = "978-1-40-289462-6";
        if(libraryBooks.ContainsKey(searchISBN))
        {

            Console.WriteLine($"\nBook with ISBN {searchISBN} is available: {libraryBooks[searchISBN]}");
        }

        string searchTitle = "The Great Gatsby";
        if (libraryBooks.ContainsValue(searchTitle))
        {
            Console.WriteLine($"\nThe book '{searchTitle}' is available in the library.");
        }

        string removeISBN = "978-0-7432-7356-5";
        if (libraryBooks.ContainsKey(removeISBN))
        {
            libraryBooks.Remove(removeISBN);
            Console.WriteLine($"\nBook with ISBN {removeISBN} has been removed.");
        }


        Console.WriteLine($"\nTotal books in library: {libraryBooks.Count}");
        Console.ReadLine();
    }
}