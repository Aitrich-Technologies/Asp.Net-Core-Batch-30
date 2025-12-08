using System.Collections.Generic;

internal class Program
{
    private static void Main(string[] args)
    {
      

        List <int> marks = new List<int>() { 45, 67, 89, 23, 90, 56, 78 };

        List<string> names = new List<string>() { "Riya", "Aman", "John", "Priya", "Ali", "Ramesh" };

        List<Employee> employees = new List<Employee>()
            {
    new Employee(){ Id=1, Name="Riya", Department="HR", Salary=35000 },
    new Employee(){ Id=2, Name="Aman", Department="IT", Salary=50000 },
    new Employee(){ Id=3, Name="John", Department="HR", Salary=40000 },
    new Employee(){ Id=4, Name="Priya", Department="IT", Salary=60000 },
    new Employee(){ Id=5, Name="Ali", Department="Admin", Salary=30000 }
        };



        bool result1 = marks.Any(m => m > 85);
        Console.WriteLine("Any mark > 85: " + result1);



        bool result2 = employees .Any (e => e.Department =="IT");
        Console.WriteLine("Any employee in it: " + result2);


        bool result3 = names.Any(e => e.StartsWith ("P"));
        Console.WriteLine("Any name starting with P: " + result3);


        int markbelow50 = marks.FirstOrDefault(m => m < 50);
        Console.WriteLine("First mark < 50: " + markbelow50);


        var empHighSalary = employees.FirstOrDefault(e => e.Salary > 55000);
        Console.WriteLine("First employee with salary > 55000: " + empHighSalary.Name);


        Console.WriteLine("Names after skipping 2:");
        foreach (var n in names.Skip(2)) 
        {
            Console.WriteLine(n);
        }


        Console.WriteLine("Total Marks: " + marks.Sum());

        Console.WriteLine("Average Salary: " + employees.Average (e=> e.Salary));


        Console.WriteLine("Max mark: " + marks.Max());


        Console.WriteLine("Marks > 60:");
        foreach (var m in marks.Where(m => m > 60)) 
        Console.WriteLine(m);




        Console.WriteLine("HR Employees:");
        foreach (var hr in employees.Where(h => h.Department == "HR"))
            Console.WriteLine(hr.Name );


        var empId3 = employees.SingleOrDefault(e => e.Id == 3);
        Console.WriteLine("Employee ID=3: " + empId3.Name );



        var empAli=employees .SingleOrDefault (e => e.Name  == "Ali");
        Console.WriteLine("Employee named ali:" + empAli.Name);


        int mark90 = marks.SingleOrDefault( e => e == 90);
        Console.WriteLine("Mark exactly = 90: " + mark90);








            }
}