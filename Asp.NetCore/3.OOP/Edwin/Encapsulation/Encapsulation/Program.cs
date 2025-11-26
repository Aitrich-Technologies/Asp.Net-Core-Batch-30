using Encapsulation;

internal class Program
{
    private static void Main(string[] args)
    {
        Person person = new Person("Alice", 25);
        Console.WriteLine(person.Name);

        person.Age = 30;
        person.DisplayDetails();

        person.Age = -5;


    }
}