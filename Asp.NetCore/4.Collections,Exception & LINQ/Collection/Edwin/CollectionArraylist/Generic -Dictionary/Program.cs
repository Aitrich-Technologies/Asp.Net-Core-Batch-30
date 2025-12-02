internal class Program
{
    private static void Main(string[] args)
    {
        Dictionary<int, string> students = new Dictionary<int, string>();
        students.Add(101, "Alice");
        students.Add(102, "Bob");
        students.Add(103, "Charlie");

        int searchId = 102;
        if (students.ContainsKey(searchId))
        {
            Console.WriteLine($"Student ID {searchId}: {students[searchId]}");
        }
        else
        {
            Console.WriteLine("Student not found.");
        }

        int removeId = 101;
        if(students.ContainsKey(removeId))
        {
            students.Remove(removeId);
            Console.WriteLine($"Student Id {removeId} removed");
        }
        Console.WriteLine("\nList of all students:");
        foreach (var student in students)
        {
            Console.WriteLine($"ID: {student.Key}, Name: {student.Value}");
        }
        students.Clear();
        Console.WriteLine("\nAll student records have been cleared.");

        if (students.Count == 0)
        {
            Console.WriteLine("No students left in the system.");
        }
        Console.ReadLine();
    }
}
