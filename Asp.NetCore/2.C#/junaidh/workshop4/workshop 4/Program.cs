namespace provider_app
{
    public class program
    {
        struct jobProvider
        {
            public string CompanyName;
            public string Email;
            public string Phone;
            public string Password;
            public string JobRole;
            public string Salary;
            public int ExperienceRequired;
        }
        static jobProvider[] JobProvider = new jobProvider[1];
        static jobProvider loggedinUser;
        static int userCount = 0;
        static void Main (string[] args)
        {
            string ch;
            do
            {
                Console.WriteLine("***********************************");
                Console.WriteLine("choose the option you want to from below");
                Console.WriteLine("1 : Login");
                Console.WriteLine("2 : Register as a new job provider");
                Console.WriteLine("***********************************");

                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        Login();
                        break;

                    case "2":
                        Register();
                        break;

                    default:
                        Console.WriteLine("Invalid Choice");
                        break;
                }
                Console.WriteLine("Do you want to continue (Y/N)");
                ch = Console.ReadLine();
            }
            while (ch == "y" || ch == "Y");

        }

        static void Login()
        {
            Console.WriteLine("********************************");
            Console.WriteLine();
            Console.WriteLine("Enter Email:");
            string email = Console.ReadLine();
            Console.WriteLine("Enter Password:");
            string password = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("*********************************");

            bool loginSuccessfull = false;

            foreach (jobProvider jp in JobProvider)
            {
                if (jp.Email == email && jp.Password == password) ;
                {
                    loginSuccessfull = true;
                    loggedinUser = jp;

                    Console.WriteLine("Login Successfull");
                    Console.WriteLine();
                    Console.WriteLine("Here are your details :");
                    Console.WriteLine("CompanyName :{0}", loggedinUser.CompanyName);
                    Console.WriteLine("Email :{0}", loggedinUser.Email);
                    Console.WriteLine("Password :{0}", loggedinUser.Password);
                    Console.WriteLine("Salary :{0}", loggedinUser.Salary);
                    Console.WriteLine("ExperienceRequired :{0}", loggedinUser.ExperienceRequired);
                    Console.WriteLine("JobRole :{0}", loggedinUser.JobRole);
                    Console.WriteLine("Phone :{0}", loggedinUser.Phone);
                    Console.WriteLine();
                }
            }
        }
        static void Register()
        {
            jobProvider jobProvider = new jobProvider ();

            Console.WriteLine("***************************************");
            Console.WriteLine();
            Console.WriteLine("Enter companyName :");
            jobProvider.CompanyName = Console.ReadLine();

            Console.WriteLine("enter Email :");
            jobProvider.CompanyName = Console.ReadLine();

            Console.WriteLine("Enter Phone :");
            jobProvider.Phone = Console.ReadLine();

            Console.WriteLine("Enter Password :");
            jobProvider.Password = Console.ReadLine();

            Console.WriteLine("Enter JobRole :");
            jobProvider.JobRole = Console.ReadLine();

            Console.WriteLine("Enter Salary :");
            jobProvider.Salary = Console.ReadLine();

            Console.WriteLine(" Enter ExperienceRequired :");
            jobProvider.ExperienceRequired = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("**************************************");

            JobProvider[userCount] = jobProvider;
            userCount++;
        }
    }
}
