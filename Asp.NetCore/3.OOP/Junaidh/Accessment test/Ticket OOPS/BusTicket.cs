using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ticket_OOPS
{
    public class BusTicket :Ticket
    {
       
        public BusTicket( int ticketId, string pName) : base(ticketId, pName) {  }

        public void FareLogic(int ticketFare)

        {
            ticketFare = 5;
        }

        public override double CalculateFare(int distance)
        {
            return distance * 5;
        }

    }
}
