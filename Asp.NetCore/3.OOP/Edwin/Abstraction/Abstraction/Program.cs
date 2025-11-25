using Abstraction;

internal class Program
{
    private static void Main(string[] args)
    {

        User user = new JobSeeker();
        user.Welcome();
    }
}