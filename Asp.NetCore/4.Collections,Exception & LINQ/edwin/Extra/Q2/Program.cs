using Q2;

internal class Program
{
    private static void Main(string[] args)
    {
        Department[] students = new Department[3];

        students[0] = new Department("Computer Science")
        {
            Name = "John",
            Age = 20,
            Marks1 = 85,
            Marks2 = 90,
            Marks3 = 89,
            Marks4 = 92,
            Marks5 = 95,
            Marks6 = 88
        };

        students[1] = new Department("Computer Science")
        {
            Name = "Anna",
            Age = 19,
            Marks1 = 70,
            Marks2 = 75,
            Marks3 = 80,
            Marks4 = 78,
            Marks5 = 72,
            Marks6 = 74
        };

        students[2] = new Department("Computer Science")
        {
            Name = "Sam",
            Age = 21,
            Marks1 = 95,
            Marks2 = 94,
            Marks3 = 96,
            Marks4 = 90,
            Marks5 = 92,
            Marks6 = 93
        };

        // Find topper
        Department topper = students[0];

        foreach (Department std in students)
        {
            if (std.CalculateCGPA() > topper.CalculateCGPA())
            {
                topper = std;
            }
        }

        Console.WriteLine("\nTopper of the Department:");
        Console.WriteLine($"Name: {topper.Name}");
        Console.WriteLine($"Department: {topper.DeptName}");
        Console.WriteLine($"CGPA: {topper.CalculateCGPA():0.00}");
        Console.WriteLine($"Grade: {topper.GetGrade()}");
    }
}