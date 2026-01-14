using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Car
    {
        public string Make {  get; set; }
        public string Model { get; set; }
        public  string Color {  get; set; }
        public decimal PricePerDay {  get; set; }
        public bool IsRented {  get; set; }

        public Car(string make, string model, string color, decimal pricePerDay)
        {
            Make = make;
            Model = model;
            Color = color;
            PricePerDay = pricePerDay;
            IsRented = false;
        }
        public void RentCar()
        {
            if (!IsRented)
            {
                IsRented = true;
                Console.WriteLine($"The car {Make}{Model}has been rented.");
            }
            else
            {
                Console.WriteLine($"The car{Make}{Model}is already rented.");
            }
        }
            public void ReturnCar()
        {
            if (IsRented)
            {
                Console.WriteLine($"The car {Make} {Model} has been returned.");
            }
            else
            {
                Console.WriteLine($"The car {Make} {Model} was not rented.");
            }
        }
    }
}
