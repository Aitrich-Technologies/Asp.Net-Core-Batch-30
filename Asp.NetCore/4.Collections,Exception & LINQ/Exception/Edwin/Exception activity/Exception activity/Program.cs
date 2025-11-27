internal class Program
{
    private static void Main(string[] args)
    {
        int i, j, k = 0;
        try
        {
            Console.WriteLine("Enter First Number");
            i = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Second Number");
            j = Convert.ToInt32(Console.ReadLine());
            k = i / j;
        }
        catch(Exception e)
        {
            Console.WriteLine(e.Message);
        }
        finally
        {
            Console.WriteLine("Result is {0}:", k);
        }
    }
}