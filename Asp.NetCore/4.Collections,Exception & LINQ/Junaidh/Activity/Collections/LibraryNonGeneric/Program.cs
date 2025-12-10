using System.Collections;
using System;

internal class Program
{
    static void Main(string[] args)
    {
        ArrayList books = new ArrayList();

        books.Add("The Great Gatsby");
        books.Add("To kill a mockingbird");
        books.Add("1984");
        books.Add("Moby Dick");
        books.Add("Pride and prejudice");

        Console.WriteLine("Books in the library");
        DisplayBooks(books);


        books.Remove("1984");
        Console.WriteLine("\n After removing '1984' :");
        DisplayBooks(books);

        books.RemoveAt(2);
        Console.WriteLine("\n After removing book at index 2:");
        DisplayBooks(books);

        books.Insert(1, "Harry Potter");
        Console.WriteLine("\n After inserting 'Harry Potter' at index 1:");
        DisplayBooks(books);

        int index = books.IndexOf("Pride and Prejudice");
        Console.WriteLine($"\nIndex of 'pride and prejudice' :{index}");


        bool contains = books.Contains("The Great Gatsby");
        Console.WriteLine($"\n Does the library contain 'The Great Gatsby'? {contains}");

        Console.WriteLine($"\n Total Books In the library: {books.Count}");


        books.Sort();
        Console.WriteLine("\n Books after sorting Alphabetically:");
        DisplayBooks(books);
    }




    static void DisplayBooks(ArrayList books)
    {
        foreach (string book in books)
        {
            Console.WriteLine(book);
            Console.WriteLine();
        }
    }
}