using System;
using System.Linq;
using System.Collections.Generic;
    public class student
    {
        public string Name { get; set; }
        public int Marks { get; set; }
    }

public class program
{
    private static void Main(string[] args)
    {
        List<student> students = new List<student>()
        {
            new student { Name = "edwin", Marks = 85 },
            new student { Name = "vishnu" , Marks = 92},
            new student { Name = "tom" , Marks = 45},
        };

        var topper = students.LastOrDefault(s => s.Marks > 80);

        Console.WriteLine($"Topper: {topper.Name},Marks: {topper.Marks}");
    }
}
    