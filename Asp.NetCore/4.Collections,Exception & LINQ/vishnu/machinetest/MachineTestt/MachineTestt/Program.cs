using MachineTestt;

internal class Program
{
    private static void Main(string[] args)
    {




        Theatre theatre = new Theatre();




        bool exit = false;

        while (!exit)
        {

            Console.WriteLine("1. Add Movie");
            Console.WriteLine("2. Remove Movie");
            Console.WriteLine("3. Display Movie");
            Console.WriteLine("Enter your choice: ");








            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:

                    Console.WriteLine("Enter movie name");
                    string name = Console.ReadLine();

                    Console.Write("Enter genre: ");
                    string genre = Console.ReadLine();

                    Console.Write("Enter AvailableSeats: ");
                    int availableseats = Convert.ToInt32(Console.ReadLine());

                    theatre.AddMovies(new Movie(name, genre, availableseats));

                    break;


                case 2:
                    Console.WriteLine("Remove movie");
                    string removename = Console.ReadLine();

                    theatre.Removemovie(removename );

                    break;

                case 3:
                    Console.WriteLine("Display Movies");
                    theatre.Display();
                    break;


                case 4:
                    exit = true;
                    break;

                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
        }
    }
    }