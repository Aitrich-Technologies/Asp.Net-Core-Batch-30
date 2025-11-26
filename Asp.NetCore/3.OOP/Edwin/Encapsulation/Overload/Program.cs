using Overload;

internal class Program
{
    private static void Main(string[] args)
    {
        Dog dog= new Dog();
        Cat cat= new Cat();
        cat.MakingSound();
        dog.MakingSound();
    }
}