using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parking
{
    abstract class Vehicle
    {

        public int VehicleId { get; set; }
        public string OwnerName { get; set; }


        public Vehicle(int vehicleId, string ownername)
        {
            VehicleId = vehicleId;
            OwnerName = ownername;
        }



        public abstract double CalculateParkingFee(int hoursParked);



    }
}
