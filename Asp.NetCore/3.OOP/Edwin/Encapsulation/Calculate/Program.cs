using Calculate;

internal class Program
{
    private static void Main(string[] args)
    {
      Calculates sum1= new Calculates();
        Console.WriteLine(sum1.Sum(3, 4));
        Console.WriteLine(sum1.Sum(6,7,8));
        Console.WriteLine(sum1.Sum(1.5, 1.8));
    }
}