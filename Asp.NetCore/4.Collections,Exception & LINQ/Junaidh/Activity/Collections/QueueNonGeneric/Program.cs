using System.Collections;
internal class Program
{
    private static void Main(string[] args)
    {
        Queue ticketQueue = new Queue();

        ticketQueue.Enqueue("Customer 1");
        ticketQueue.Enqueue("Customer 2");
        ticketQueue.Enqueue("Customer 3");
        ticketQueue.Enqueue("Customer 4");

        Console.WriteLine($"customers in Queue: {ticketQueue.Count} ");

        Console.WriteLine($"Next to be served: {ticketQueue.Peek() } ");

        Console.WriteLine(ticketQueue.Dequeue() + " is being served.");
        Console.WriteLine(ticketQueue.Dequeue() + " is being served.");

        Console.WriteLine($"Customers Remaining in Queue :{ticketQueue.Count} ");
        Console.WriteLine($"Next to be Served: {ticketQueue.Peek()} ");
        Console.ReadLine();
    }
}