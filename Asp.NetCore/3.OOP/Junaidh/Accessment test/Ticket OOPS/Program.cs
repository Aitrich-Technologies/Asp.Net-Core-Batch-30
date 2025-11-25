using Ticket_OOPS;

internal class Program
{
    public static void Main(string[] args)
    {
        Ticket[] tickets = new Ticket[4];
        TrianTicket[] trianTickets = new TrianTicket[1];
        BusTicket[] busTickets = new BusTicket[1];

        tickets[0] = new TrianTicket(101,"Rahul");
        tickets[2] = new TrianTicket(102, "keshav");
        tickets[1] = new BusTicket(201, "swami");
        tickets[3] = new BusTicket(202,"gafoor");



        int Distance = 10;

        foreach (Ticket ticket in tickets)
        {
           
            Console.WriteLine($"{ticket.TicketId} {ticket.PName}  fare: {ticket.CalculateFare(Distance)}");
        }



    }
}