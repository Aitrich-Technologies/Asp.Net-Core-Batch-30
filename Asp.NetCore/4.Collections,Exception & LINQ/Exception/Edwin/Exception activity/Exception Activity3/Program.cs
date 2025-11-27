internal class Program
{
    private static void Main(string[] args)
    {
        try
        {
            int i = int.MaxValue;
            int j = checked(i + 1);
            Console.WriteLine(j);
        }
        catch(OverflowException ex)
        {
            Console.WriteLine(ex.Message);
        }
        finally
        {
            Console.WriteLine("Final block executed");
        }
    }
}