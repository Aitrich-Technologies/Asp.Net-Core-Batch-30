using InterfaceSample;

internal class Program
{
    private static void Main(string[] args)
    {
        FullTime ft = new FullTime(50000, 6000, " : vishnu ", 001);
        ft.DisplayInfo();
        Console.WriteLine($"Monthly Salary: {ft.CalculateSalary()}");

        PartTime gt = new PartTime(800, 12, " : edwin ", 006);
        gt.DisplayInfo();
        Console.WriteLine($"Monthly Salary: {gt.CalculateSalary()}");
    }
}