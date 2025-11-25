using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle
{
    abstract  class Motorcycle:Vehicle 
    {
        public Motorcycle (int vehicleId, string ownername):base (vehicleId,ownername) { }

        private double fine(int perhour)
        {
            return perhour*15;
        }

        public override double CalculateParkingFee(int hoursParked)
        {
            return fine(hoursParked);
        }



    }
}
