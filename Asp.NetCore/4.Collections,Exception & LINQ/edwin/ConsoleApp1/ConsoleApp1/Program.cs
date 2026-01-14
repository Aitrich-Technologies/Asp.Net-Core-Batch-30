using ConsoleApp1;
using static ConsoleApp1.Vehicle;

internal class Program
{
   static void Main(string[] args)
    {
        //JobSeeker seeker= new JobSeeker(1,"Vishnu","M");
        ////seeker.FirstName = "Richard";
        ////seeker.LastName = "Wilson";
        //Console.WriteLine($"{seeker.FirstName} {seeker.LastName}");
        ////seeker.ApplyJob(1);
        ///



        //Car car1 = new Car("BMW", "M5", "Black", 100.00m);
        //Car car2 = new Car("Toyota", "Corolla", "Blue", 50.00m);

        //Console.WriteLine($"Car 1: {car1.Make} {car1.Model}, Color: {car1.Color}, Price per day: ${car1.PricePerDay}");
        //Console.WriteLine($"Car 2: {car2.Make} {car2.Model}, Color: {car2.Color}, Price per day: ${car2.PricePerDay}");

        //car1.RentCar();
        //car1.RentCar();
        //car1.ReturnCar();

        //car2.RentCar();
        //car2.ReturnCar();



        //Book b1 = new Book(1, "C#", "James", 450);
        //Book b2 = new Book(2, "OOPS", "Ravi", 500);
        //Book b3 = new Book(3, ".Net", "Seetha", 800);

        //b1.displaybook();
        //b2.displaybook();
        //b3.displaybook();


        //Hospital p1 = new Hospital (101,   "John",   "Fever" );
        //Hospital p2 = new Hospital ( 102,   "Sara",   "Cold" );

        //p1.ShowDetails();
        //p2.ShowDetails();


        Shopping p1 = new Shopping ( 1,  "Laptop",  50000,  2 );
        Shopping p2 = new Shopping (  2,  "Mouse",  800, 3 );

        double total = p1.CalculateTotalPrice() + p2.CalculateTotalPrice();
        Console.WriteLine($"Total Bill: ₹{total}");




        //School s1 = new School (1,   "Asha",  85 );
        //School s2 = new School (2,   "Binu",  35 );
        //School s3 = new School (3,   "Chris", 50 );

        //s1.CheckResult();
        //s2.CheckResult();
        //s3.CheckResult();

        //BankAccount acc = new BankAccount (12345,  "Neha",   10000 );

        //acc.Deposit(2000);
        //acc.Withdraw(3000);
        //acc.Withdraw(10000);


        //Cars c1 = new Cars (1, "Toyota", 18.5 );
        //Cars c2 = new Cars ( 2, "Hyundai" , 20.2 );

        //c1.DisplayCarInfo();
        //c2.DisplayCarInfo();

        //Employee e1 = new Employee(1, "Anu", 30000);
        //Employee e2 = new Employee(2, "Ravi", 45000);

        //Console.WriteLine($"{e1.Name} Net Salary: {e1.CalculateNetSalary()}");
        //Console.WriteLine($"{e2.Name} Net Salary: {e2.CalculateNetSalary()}");
        //double totalsalary1=e1.CalculateNetSalary();
        //double totalsalary2= e2.CalculateNetSalary();
        //Console.WriteLine($"totalsalary:{totalsalary1}");
        //Console.WriteLine($"totalsalary:{totalsalary2}");



    }
}