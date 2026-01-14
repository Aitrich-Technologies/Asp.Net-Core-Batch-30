using Extra;

internal class Program
{
    private static void Main(string[] args)
    {
        LibraryMember[] members = new LibraryMember[4];

        members[0] = new StudentMember(1, "edwin");
        members[1] = new FacultyMember(2, "John");
        members[2] = new StudentMember(3, "ivan");
        members[3] = new FacultyMember(4, "m");

        int OverDays = 5;

        foreach (LibraryMember m in members)
        {
            Console.WriteLine($"{m.Name} (ID: {m.MemberId}) - Fine: ${m.CalculateFine(OverDays)}");
        }
    }
}