internal class Program
{
    private static void Main(string[] args)
    {
        SortedList<int, string> studentGrades = new SortedList<int, string>();

        
        studentGrades.Add(105, "B");
        studentGrades.Add(102, "A");
        studentGrades.Add(108, "C");
        studentGrades.Add(101, "A+");
        studentGrades.Add(107, "B+");

        
        Console.WriteLine("Student Grades (Sorted by Student ID):");
        foreach (var student in studentGrades)
        {
            Console.WriteLine($"Student ID: {student.Key}, Grade: {student.Value}");
        }

        
        int searchId = 102;
        if (studentGrades.ContainsKey(searchId))
        {
            Console.WriteLine($"\nStudent {searchId} has grade: {studentGrades[searchId]}");
        }

        
        studentGrades.Remove(108);
        Console.WriteLine("\nAfter removing Student ID 108:");

        foreach (var student in studentGrades)
        {
            Console.WriteLine($"Student ID: {student.Key}, Grade: {student.Value}");
        }
    }
}