internal class Program
{
    private static void Main(string[] args)
    {
        try
        {
            string[] pets = { "Dog", "cat", "Parrot" };
            Console.WriteLine(pets[10]);
        }
        catch(IndexOutOfRangeException)
        {
            Console.WriteLine("Exception occured");
        }
        finally
        {
            Console.WriteLine("Final block executed");
        }
    }
}