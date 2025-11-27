using UseraleradyExists.Exception;
using UseraleradyExists.Model;

internal class Program
{
    private static void Main(string[] args)
    {
        User[] users = new User[5];
        int userCount = 0;

        while (true)
        {
            Console.WriteLine("Choose an option : \n1. Register \n2. Login \n3. Exit");
            string option = Console.ReadLine();

            if(option == "1")
            {
                try
                {
                    if(userCount >= users.Length)
                    {
                        Console.WriteLine("User Limit reached. cannot register more users.");
                        continue;
                    }
                    Console.Write("Enter Name:");
                    string name = Console.ReadLine();

                    Console.Write("Enter Email:");
                    string email = Console.ReadLine();

                    Console.Write("Enter Password:");
                    string password = Console.ReadLine();   

                    for(int i=0; i<userCount; i++)
                    {
                        if (users[i].Email == email)
                        {
                            throw new EmailAleradyExistsException("Email Id Already exists. Please use a differnt one.");

                        }
                    }
                    if(password.Length<8)
                    {
                        //Console.WriteLine("Password must be 8 characters");
                        //continue;
                        throw new PasswordException("Password must be 8 characters");
                    }
                    
                    Console.Write("Enter age:");
                    int age = int.Parse(Console.ReadLine());
                    if(age < 18)
                    {
                        throw new AgeException("You Must be at least 18 years old to register.");

                    }
                    users[userCount] = new User { Name = name, Email = email, Age = age,Password=password };
                    userCount++;

                    Console.WriteLine("Registration sucessful!");
                }
                catch(AgeException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch(EmailAleradyExistsException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch(PasswordException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch(Exception ex)
                {
                    Console.WriteLine("An error occured:"+ ex.Message);
                }
            }
            else if(option == "2")
            {
                Console.Write("Enter Email to  Login:");
                string loginEmail = Console.ReadLine();

                //Console.Write("Enter password to Login:");
                //string loginpassword = Console.ReadLine();

                bool foundUser = false;

                for(int i=0; i<  userCount; i++)
                {
                    if (users[i].Email == loginEmail )
                    {
                        foundUser = true;
                        Console.WriteLine($"Login successful! Welcome, {users[i].Name}.");
                        break;
                    }
                }
                if (!foundUser)
                {
                    Console.WriteLine("Email not found.Please register first.");
                }
            }
            else if (option == "3")
            {
                Console.WriteLine("Exiting the program..");
                break;
            }
            else
            {
                Console.WriteLine("Invalid option. Please choose 1,2, or 3.");
            }
        }
    }
}