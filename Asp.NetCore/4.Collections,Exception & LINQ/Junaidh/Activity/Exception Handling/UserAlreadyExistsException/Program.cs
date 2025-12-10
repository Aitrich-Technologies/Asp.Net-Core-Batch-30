using userAlreadyExistsException.Exception;
using UserAlreadyExistsException.Exception;
using UserAlreadyExistsException.Model;


internal class Program
{
    public static void Main(string[] args)
    {
        User[] users = new User[5];
        int userCount = 0;

        while (true)
        {
            Console.WriteLine("Choose an Option :\n1. Register\n2. Login\n3.Exit");
            string option = Console.ReadLine();

            if (option == "1")
            {
                try
                {
                    if (userCount >= users.Length)
                    {
                        Console.WriteLine("user Limit reached. cannot register more users.");
                        continue;
                    }
                    Console.Write("Enter Name:");
                    string name = Console.ReadLine();

                    Console.Write("Enter Email:");
                    string email = Console.ReadLine();

                    for (int i = 0; i < userCount; i++)
                    {
                        if (users[i].email == email)
                        {
                            throw new EmailAlreadyExistsException("Email ID already exists. please use a different one");
                        }
                    }

                    Console.WriteLine("Enter Password :");
                    string password = Console.ReadLine();

                    if(password.Length<8)
                    {

                        throw new PasswordException("Password must be above 8 characters");
                    }
                    Console.Write("Enter Age:");
                    int age = int.Parse(Console.ReadLine());

                    if (age < 18)
                    {
                        throw new AgeException("You must be atleast 18 years old to register.");
                    }

                    users[userCount] = new User { name = name, email = email, age = age };
                    userCount++;

                    Console.WriteLine("Registration Succesfull");
                }
                catch (AgeException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (EmailAlreadyExistsException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (PasswordException ex)
                {
                    Console.WriteLine(ex.Message);
                }

                catch (Exception ex)
                {
                    Console.WriteLine("An error Occured : " + ex.Message);
                }
            }
            else if (option == "2")
            {
                Console.WriteLine("Enter Email to login:");
                string loginemail = Console.ReadLine();

                bool foundUser = false;

                for (int i = 0; i < userCount; i++)
                {
                    if (users[i].email == loginemail)
                    {
                        foundUser = true;
                        Console.WriteLine($"Login successfull! welcome, {users[i].name}.");
                        break;
                    }
                }
                if (!foundUser)
                {
                    Console.WriteLine("Email not Found. please register first.");
                }
            }
            else if (option == "3")
            {
                Console.WriteLine("Exiting the Program....");
                break;
            }
            else
            {
                Console.WriteLine("Invalid Option . please choose 1,2,or 3.  ");
            }
        }
    }
}

            