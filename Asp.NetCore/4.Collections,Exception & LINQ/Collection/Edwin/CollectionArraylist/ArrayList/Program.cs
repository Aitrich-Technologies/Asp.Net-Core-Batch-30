using System;
using System.Collections;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

internal class Program
{
    private static void Main(string[] args)
    {
      ArrayList books = new ArrayList();

        books.Add("The Great Gatsby");
        books.Add("To Kill a Mockingbird");
        books.Add("1984");
        books.Add("Moby Dick");
        books.Add("Pride and Prejudice");

        Console.WriteLine("Books in the Library:");
        DisplayBooks(books);


        books.Remove("1984");
        Console.WriteLine("After removing '1984:");

        DisplayBooks(books);

        books.RemoveAt(2);
        Console.WriteLine("After removing book at index 2:");
        DisplayBooks(books);

        books.Insert(1, "Harry Potter");
        Console.WriteLine("After inserting 'Harry Potter' at index 1:");
        DisplayBooks(books);


        int index = books.IndexOf("Pride and Prejudice");
        Console.WriteLine($"\nIndex of 'Pride and Prejudice': {index}");

        bool contains=books.Contains("The Great Gatsby");
        Console.WriteLine($"\nDoes the library contain 'The Great Gatsby'? {contains}");

        Console.WriteLine($"total books in  the library: {books.Count}");

        books.Sort();
        Console.WriteLine("Books after sorting alphabetically:");
        DisplayBooks( books );
    }
    static void DisplayBooks( ArrayList books)
    {
        foreach(string book in books)
        {
            Console.WriteLine(book);
            Console.WriteLine();
        }
    }
}