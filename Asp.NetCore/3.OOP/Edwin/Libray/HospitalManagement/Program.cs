using HospitalManagement;

internal class Program
{
    private static void Main(string[] args)
    {
        Patient p1 = new Patient("Aswin", 30, "Fever", "No major issues");
        p1.ShowPatientDetails();

        Staff doc = new Doctor("Dr. Vishnu", 201,500);
        Staff Nur = new Nurse("Anju", 302,50);
        Staff Recp = new Receptionist("Aleena", 401,50000);

        Console.WriteLine($"Doctor Salary {doc.CalculateSalary()}");
        Console.WriteLine($"Nurse Salary {Nur.CalculateSalary()}");
        Console.WriteLine($"Receptionist Salary {Recp.CalculateSalary()}");


        //doc.CalculateSalary();
        //Nur.CalculateSalary();
        //Recp.CalculateSalary();


        Appointment a1 = new OnlineAppointment("Abi",100);
        Appointment a2 = new OfflineAppointment("Benlin",101);


        a1.ScheduleAppointment();
        a2.ScheduleAppointment();

    }
}