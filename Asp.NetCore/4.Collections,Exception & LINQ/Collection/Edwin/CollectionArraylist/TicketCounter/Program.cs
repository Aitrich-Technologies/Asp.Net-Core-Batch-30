
using System;
using System.Collections;


internal class Program
{
    static void Main()
    {
        Queue ticketQueue = new Queue();

        
        ticketQueue.Enqueue("Customer 1");
        ticketQueue.Enqueue("Customer 2");
        ticketQueue.Enqueue("Customer 3");
        ticketQueue.Enqueue("Customer 4");

        Console.WriteLine("Customers in Queue: " + ticketQueue.Count);

       
        Console.WriteLine("Next to be served: " + ticketQueue.Peek());

      
        Console.WriteLine(ticketQueue.Dequeue() + " is being served.");
        Console.WriteLine(ticketQueue.Dequeue() + " is being served.");

       
        Console.WriteLine("Customers remaining in Queue: " + ticketQueue.Count);
        Console.WriteLine("Next to be served: " + ticketQueue.Peek());
        Console.ReadLine();
    }
}