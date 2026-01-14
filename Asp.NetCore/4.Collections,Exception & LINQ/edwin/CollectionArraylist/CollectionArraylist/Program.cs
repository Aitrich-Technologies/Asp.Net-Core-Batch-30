using System.Collections;

internal class Program
{
    private static void Main(string[] args)
    {
     
        
            ArrayList jobList = new ArrayList();
            jobList.Add("Dotnet Developer");
            jobList.Add("Java Developer");
            jobList.Add("Angular Developer");
            Console.WriteLine("The jobs in the list are:");

            foreach(var item in jobList)
            {
                Console.WriteLine(item);
            }
        
    }
}