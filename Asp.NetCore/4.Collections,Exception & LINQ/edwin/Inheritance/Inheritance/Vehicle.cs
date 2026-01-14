using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    namespace ConsoleApp1
    {
        public class Vehicle
        {
            public string Brand { get; set; }
            public string Model { get; set; }
            public int Speed { get; set; }

            public Vehicle(string brand, string model, int speed)
            {
                Brand = brand;
                Model = model;
                Speed = speed;
            }
            public virtual void DisplayInfo()
            {
                Console.WriteLine($"Brand: {Brand}, Model: {Model}, Speed: {Speed} km/h");
            }
            public class Car : Vehicle
            {
                public int NumberOfDoors { get; set; }

                public Car(string brand, string model, int speed, int numberOfDoors)
                    : base(brand, model, speed)
                {
                    NumberOfDoors = numberOfDoors;
                }

                public override void DisplayInfo()
                {
                    base.DisplayInfo();
                    Console.WriteLine($"Number of Doors: {NumberOfDoors}");
                }
            }


            public class Bike : Vehicle
            {
                public bool HasCarrier { get; set; }

                public Bike(string brand, string model, int speed, bool hasCarrier)
                    : base(brand, model, speed)
                {
                    HasCarrier = hasCarrier;
                }

                public override void DisplayInfo()
                {
                    base.DisplayInfo();
                    Console.WriteLine($"Has Carrier: {HasCarrier}");
                }
            }


            public class Truck : Vehicle
            {
                public int LoadCapacity { get; set; }

                public Truck(string brand, string model, int speed, int loadCapacity)
                    : base(brand, model, speed)
                {
                    LoadCapacity = loadCapacity;
                }

                public override void DisplayInfo()
                {
                    base.DisplayInfo();
                    Console.WriteLine($"Load Capacity: {LoadCapacity} tons");
                }



            }
        }
    }

}
