<<<<<<< HEAD
﻿internal class Program
{
    private static void Main(string[] args)
    {
        double[] temprature = new double[7];
        double sum = 0;

        Console.WriteLine("Enter temprature");

        for (int i = 0; i < 7; i++)
        {
            Console.Write($"Day {i + 1}");
            temprature[i] = Convert.ToDouble(Console.ReadLine());
            sum += temprature[i];
        }
        double average = sum / 7;

        double highest = temprature[0];
        double lowest = temprature[0];

        for (int i = 1; i < 7; i++)
        {

            if (temprature[i] > highest)
                highest = temprature[i];

        if (temprature[i] < lowest)
            lowest = temprature[i];
    }
        Console.WriteLine($"Highest Temprature {highest}");
        Console.WriteLine($"Lowest Temprature {lowest}");
        Console.WriteLine($"Average Temprature{average}");

        }
=======
﻿internal class Program
{
    private static void Main(string[] args)
    {
        double[] temprature = new double[7];
        double sum = 0;

        Console.WriteLine("Enter temprature");

        for (int i = 0; i < 7; i++)
        {
            Console.Write($"Day {i + 1}");
            temprature[i] = Convert.ToDouble(Console.ReadLine());
            sum += temprature[i];
        }
        double average = sum / 7;

        double highest = temprature[0];
        double lowest = temprature[0];

        for (int i = 1; i < 7; i++)
        {

            if (temprature[i] > highest)
                highest = temprature[i];

        if (temprature[i] < lowest)
            lowest = temprature[i];
    }
        Console.WriteLine($"Highest Temprature {highest}");
        Console.WriteLine($"Lowest Temprature {lowest}");
        Console.WriteLine($"Average Temprature{average}");

        }
>>>>>>> c65346a8715ef5f84b526c46ede8030b3555f835
}