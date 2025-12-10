using System;
using System.Collections.Generic;

public class LibrarySystem
{
    
    private SortedList<string, string> books = new SortedList<string, string>();

    
    private Dictionary<int, string> members = new Dictionary<int, string>();

    
    private Queue<string> checkoutQueue = new Queue<string>();

    
    private Stack<string> overdueStack = new Stack<string>();

    
    private List<string> announcements = new List<string>();

    

    
    public void AddBook(string title, string isbn)
    {
        books.Add(title, isbn);
        Console.WriteLine($"Book Added: {title} - ISBN: {isbn}");
    }

    
    public void RegisterMember(int id, string name)
    {
        members.Add(id, name);
        Console.WriteLine($"Member Registered: {name} (ID: {id})");
    }

    
    public void CheckoutBook(string bookTitle)
    {
        if (books.ContainsKey(bookTitle))
        {
            checkoutQueue.Enqueue(bookTitle);
            Console.WriteLine($"Book Checked Out: {bookTitle}");
        }
        else
        {
            Console.WriteLine($"Book not found: {bookTitle}");
        }
    }

    
    public void ReturnBook(string bookTitle, bool isOverdue, int memberId)
    {
        if (checkoutQueue.Count > 0 && checkoutQueue.Contains(bookTitle))
        {
            
            Queue<string> tempQueue = new Queue<string>();

            while (checkoutQueue.Count > 0)
            {
                string current = checkoutQueue.Dequeue();
                if (current != bookTitle)
                    tempQueue.Enqueue(current);
            }

            checkoutQueue = tempQueue;
            Console.WriteLine($"Book Returned: {bookTitle}");

            
            if (isOverdue)
            {
                string memberName = members.ContainsKey(memberId) ? members[memberId] : "Unknown";
                overdueStack.Push(memberName);
                Console.WriteLine($"Overdue! Added to stack: {memberName}");
            }
        }
        else
        {
            Console.WriteLine("Book not found in checkout queue.");
        }
    }

    
    public void AddAnnouncement(string message)
    {
        announcements.Add(message);
        Console.WriteLine($"Announcement Added: {message}");
    }

    
    public void PrintState()
    {
       

        Console.WriteLine("\nBooks (SortedList):");
        foreach (var b in books)
            Console.WriteLine($"Title: {b.Key}, ISBN: {b.Value}");

        Console.WriteLine("\nMembers (Dictionary):");
        foreach (var m in members)
            Console.WriteLine($"ID: {m.Key}, Name: {m.Value}");

        Console.WriteLine("\nCheckout Queue:");
        foreach (var q in checkoutQueue)
            Console.WriteLine(q);

        Console.WriteLine("\nOverdue Stack:");
        foreach (var s in overdueStack)
            Console.WriteLine(s);

        Console.WriteLine("\nAnnouncements:");
        foreach (var a in announcements)
            Console.WriteLine(a);

      
    }
}



public class Program
{
    public static void Main(string[] args)
    {
        LibrarySystem library = new LibrarySystem();

        
        library.AddBook("Harry Potter", "ISBN001");
        library.AddBook("Fire of wings", "ISBN002");
        library.AddBook("Paolo Coelho", "ISBN003");

        
        library.RegisterMember(101, "john");
        library.RegisterMember(102, "catherine");

        
        library.AddAnnouncement("New books arriving next week!");
        library.AddAnnouncement("Library closed on Sunday.");

        
        library.CheckoutBook("Harry Potter");
        library.CheckoutBook("Fire of wings");

        
        library.ReturnBook("Harry Potter", isOverdue: true, memberId: 101);
        library.ReturnBook("Fire of wings", isOverdue: false, memberId: 102);

        
        library.PrintState();
    }
}
