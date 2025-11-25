using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ticket_OOPS
{
    public abstract class Ticket
    {
        public int TicketId { get; set; }
        public string PName { get; set; }

        public Ticket(int ticketId, string pName)
        {
            TicketId = ticketId;
            PName = pName;
        }

        public abstract double CalculateFare(int distance);

        
        
    }
}
