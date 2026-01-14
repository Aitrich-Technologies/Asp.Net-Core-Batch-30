internal class Program
{
    private static void Main(string[] args)
    {
      SortedList<string,string> books = new SortedList<string,string>();
        books.Add("C# Programming", "ISBN-101");
        books.Add("ASP.NET Core", "ISBN-202");
        books.Add("Data Structures", "ISBN-303");

        Console.WriteLine("BOOKS");
        foreach (var item in books)
        {
            Console.WriteLine(item.Key + " - " + item.Value);
        }
            

        Dictionary<int, string> members = new Dictionary<int, string>();
        members.Add(1, "John");
        members.Add(2, "Emma");

        Console.WriteLine(" MEMBERS");
        foreach (var m in members)
        {
            Console.WriteLine(m.Key + ": " + m.Value);
        }
          



        Queue<string> checkoutQueue = new Queue<string>();
        checkoutQueue.Enqueue("C# Programming");
        checkoutQueue.Enqueue("ASP.NET Core");

        Console.WriteLine(" CHECKOUT  ");
        foreach (var book in checkoutQueue)
        {
            Console.WriteLine(book);
        }
            



        Stack<string> overdueStack = new Stack<string>();
        overdueStack.Push("Emma");

        Console.WriteLine(" OVERDUE MEMBERS ");
        foreach (var name in overdueStack)
        {
            Console.WriteLine(name);
        }
           


        List<string> announcements = new List<string>();
        announcements.Add("New books coming next week.");
        announcements.Add("Library closes at 6 PM.");

        Console.WriteLine("\n=== ANNOUNCEMENTS (List) ===");
        foreach (var note in announcements)
        {
            Console.WriteLine(note);

        }
         
    }
}