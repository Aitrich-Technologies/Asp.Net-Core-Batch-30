using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ticket_OOPS
{
    public class TrianTicket : Ticket
    {
       
      
        public TrianTicket( int ticketId , string pName  ) : base( ticketId,  pName )
        {
        }

        public void FareLogic( int ticketFare )
        {
            ticketFare = 2;
        }
        public override double CalculateFare(int distance)
        {
            return distance * 2;
        }

    }
}
