 class Program
{
    private static void Main(string[] args)
    {
        Queue<string> supportTickets = new Queue<string>();
        supportTickets.Enqueue("Ticket#101");
        supportTickets.Enqueue("Ticket#102");
        supportTickets.Enqueue("Ticket#103");

        Console.WriteLine("Total Tickets in Queue: " + supportTickets.Count);

        Console.WriteLine("Next Ticket to Process: " + supportTickets.Peek());

        while (supportTickets.Count > 0)
        {
            string ticket = supportTickets.Dequeue();
            Console.WriteLine($"Processing {ticket}...");
        }

        Console.WriteLine("All tickets processed. Remaining Tickets: " + supportTickets.Count);
        Console.ReadLine();

    }
}