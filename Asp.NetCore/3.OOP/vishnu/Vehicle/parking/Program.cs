using parking;

internal class Program
{
    private static void Main(string[] args)
    {
        Car car1 = new Car(101, "Vishnu");
        Car car2 = new Car(102, "Arun");


        Motorcycle m1 = new Motorcycle(201, "Rahul");
        Motorcycle m2 = new Motorcycle(202, "Kiran");

       
        List<Vehicle> vehicles = new List<Vehicle>();

        vehicles.Add(car1);
        vehicles.Add(car2);
        vehicles.Add(m1);
        vehicles.Add(m2);

        int perhour = 2;

        foreach (var v in vehicles)
        {
            double fine = v.CalculateParkingFee(perhour);

            Console.WriteLine($"{v.OwnerName} Fine: {fine}");
        }





        double highest = 0;
        double lowest = 0;

        double fee=perhour ;

        if (fee > highest)
            highest = fee;

        if (fee < lowest)
            lowest = fee;
    

    Console.WriteLine("Highest " + highest);
Console.WriteLine("Lowest " + lowest);
        
    }
}
