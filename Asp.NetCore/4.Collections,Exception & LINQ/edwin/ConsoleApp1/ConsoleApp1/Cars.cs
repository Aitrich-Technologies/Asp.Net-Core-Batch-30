using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp1
{
    internal class Cars
    {
        public int CarId;
        public string Brand;
        public double Mileage;

        public Cars(int carId, string brand, double mileage)
        {
          CarId=carId;
            Brand=brand;
            Mileage=mileage;
        }

        public void DisplayCarInfo()
        {
            Console.WriteLine($"Car ID: {CarId}, Brand: {Brand}, Mileage: {Mileage} km/l");
        }
    }
}
