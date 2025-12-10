using System.Collections;
internal class Program
{
    private static void Main(string[] args)
    {
        Stack books = new Stack();
        books.Push(1);
        books.Push(2);
        books.Push(3);
        books.Push(4);

        Console.WriteLine($"Total books in stack :{books.Count}");

        Console.WriteLine($"Top book on the stack {books.Peek()} ");

        string bookToFind = "1984";
        if(books.Contains(bookToFind))
        {
            Console.WriteLine($"The book '{bookToFind}' is in the stack.");
        }
        else
        {
            Console.WriteLine($"The book '{bookToFind}' is not in the stack");
        }

        string poppedBook = books.Pop().ToString();
        Console.WriteLine($"PoppedBook : {poppedBook}");


        Console.WriteLine($"Total books after popping one {books.Count}");
        Console.ReadLine();
    }
}