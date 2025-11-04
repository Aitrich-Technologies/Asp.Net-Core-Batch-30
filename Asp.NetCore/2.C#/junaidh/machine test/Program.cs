using System;
using System.Xml.Serialization;

struct Patient
{
    public int ID;
    public string Name;
    public int Age;
}

internal class program
{
    static void Main()
    {
        Patient[] patients = new Patient[5]; 

        Console.WriteLine("Enter details for 5 patients:\n");

        
        for (int i = 0; i <= patients.Length; i++)
        {
            Console.WriteLine($"Enter details for Patient {i + 1}:");

            Console.Write("ID: ");
            patients[i].ID = Convert.ToInt32(Console.ReadLine());

            Console.Write("Name: ");
            patients[i].Name = Console.ReadLine();

            Console.Write("Age: ");
            patients[i].Age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(); 
        }

       
        Console.WriteLine("--- Patient Details ---");
        for (int i = 0; i <=patients.Length; i++)
        {
            Console.WriteLine($"Patient {i + 1}:");
            Console.WriteLine($"ID: {patients[i].ID}");
            Console.WriteLine($"Name: {patients[i].Name}");
            Console.WriteLine($"Age: {patients[i].Age}");
            
        }
    }
}

//    static Patient[] Patients = new Patient[5];
//        static Patient patients; 

//    public static void Main(string[] args)
//    {
//        do
//        { 
//        Console.WriteLine("Hospital Management System");
//        Console.WriteLine(" 1: register ");
//        Console.WriteLine(" 2: login ");

//        string ch =Console.ReadLine();
       

//            switch (ch)
//            {
//                case "1":
//                    register();
//                    break;
//                case "2":
//                    login();
//                    break;
//                default:
//                    Console.WriteLine("invalid choice");
//                    break;
//            }
//            Console.WriteLine(" continue (Y/N)");
//        }
//        while (choice == "Y" || choice == "y");

//    }
    


//    public void register()
//    {
//        Patient hos = new Patient();
//        Console.WriteLine("Patient ID");
//        hos.Id = Convert.ToInt32(Console.ReadLine);
//        Console.WriteLine("Patient name");
//        hos.Name = Console.ReadLine();
//        Console.WriteLine("Patient age");
//        hos.age = Convert.ToInt32(Console.ReadLine());
//    }

//    public void login()
//    {
//        Console.WriteLine("Id");
//        int Id = Convert.ToInt32(Console.ReadLine());
//        Console.WriteLine("Name");
//        string Name = Console.ReadLine();

//        bool logginsuccess=false;
//        for (int i = 0; i <= Patients.Length; i++)
//        {
//            if (Patients[i].Id == Id && Patients[i].Name == Name)
//            {
//                Console.WriteLine("login Successfull");
//                bool loginsuccess = true;
//                patients = Patients[i];

//                patientsdetails();

//            }
//            else
//            {
//                Console.WriteLine("Login error");
//            }
                
//        }
       
//    }
//    public void patientsdetails()
//    {

//        do
//        {
//            Console.WriteLine(" 1:list");
//            Console.WriteLine("display");
//        }
//        while(true);

//    }
//    public void list()
//    {
//        Console.WriteLine("Id :11 , Name :hary ,age :20");
//        Console.WriteLine("Id :12, name : rahul,age :55");
//        Console.WriteLine("Id :13, Name :wale , age :54");
//        Console.WriteLine("Id : 14, name : gwen, age :67");
//        Console.WriteLine("Id :15 , name :ravi , age :34");
//    }
//    public void display()
//    {
//        Console.WriteLine($"{patients.Id}");
//        Console.WriteLine($"{patients.Name}");
//        Console.WriteLine($"{patients.age}");
//    }
//}

