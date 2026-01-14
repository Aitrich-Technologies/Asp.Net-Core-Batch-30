using System;
using System.Linq;
using System.Collections.Generic;

public class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Department { get; set; }
    public int Salary { get; set; }
}

public class Program
{
    public static void Main()
    {
        List<int> marks = new List<int> { 45, 67, 89, 23, 90, 56, 78 };

        List<string> names = new List<string> { "Riya", "Aman", "John", "Priya", "Ali", "Ramesh" };

        List<Employee> employees = new List<Employee>()
        {
            new Employee(){ Id=1, Name="Riya", Department="HR", Salary=35000 },
            new Employee(){ Id=2, Name="Aman", Department="IT", Salary=50000 },
            new Employee(){ Id=3, Name="John", Department="HR", Salary=40000 },
            new Employee(){ Id=4, Name="Priya", Department="IT", Salary=60000 },
            new Employee(){ Id=5, Name="Ali", Department="Admin", Salary=30000 }
        };


        bool anyHighMark = marks.Any(m => m > 85);
        Console.WriteLine("Any mark Greater Than 85: " + anyHighMark);


        bool anyIT = employees.Any(e => e.Department == "IT");
        Console.WriteLine("Any employee in IT: " + anyIT);


        bool anyStartsWithP = names.Any(n => n.StartsWith("P"));
        Console.WriteLine("Any name starts with P: " + anyStartsWithP);


        int firstLowMark = marks.FirstOrDefault(m => m < 50);
        Console.WriteLine("First mark Less Than 50: " + firstLowMark);


        var highSalaryEmp = employees.FirstOrDefault(e => e.Salary > 55000);
        Console.WriteLine("First employee salary Greater Than 55000: " + highSalaryEmp?.Name);


        var skipNames = names.Skip(2);
        Console.WriteLine("Names after skipping 2: " + string.Join(", ", skipNames));


        var skipMarks = marks.Skip(3);
        Console.WriteLine("Marks after skipping 3: " + string.Join(", ", skipMarks));


        int totalMarks = marks.Sum();
        Console.WriteLine("Total marks: " + totalMarks);


        double avgSalary = employees.Average(e => e.Salary);
        Console.WriteLine("Average salary: " + avgSalary);


        int maxMark = marks.Max();
        Console.WriteLine("Maximum mark: " + maxMark);


        var highMarksList = marks.Where(m => m > 60).ToList();
        Console.WriteLine("Marks Greater Than 60 List: " + string.Join(", ", highMarksList));


        var hrList = employees.Where(e => e.Department == "HR").ToList();
        Console.WriteLine("HR Employees: " + string.Join(", ", hrList.Select(e => e.Name)));


        var empId3 = employees.SingleOrDefault(e => e.Id == 3);
        Console.WriteLine("Employee with Id 3: " + empId3?.Name);


        var empAli = employees.SingleOrDefault(e => e.Name == "Ali");
        Console.WriteLine("Employee named Ali: " + empAli?.Name);


        int mark90 = marks.SingleOrDefault(m => m == 90);
        Console.WriteLine("Mark = 90: " + mark90);
    }
}