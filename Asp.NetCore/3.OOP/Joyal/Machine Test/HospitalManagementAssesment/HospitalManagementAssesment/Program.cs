using HospitalManagementAssesment;

internal class Program
{
    private static void Main(string[] args)
    {
        //InPatient ip1 = new(121, "john");
        //InPatient ip2 = new (128, "jose");

        //OutPatient op1 = new(132, "Joseph");
        //OutPatient op2 = new(136, "Jorly");
        //ip1.CalculateBillPatient(8);
        //ip2.CalculateBillPatient(12);
        //op1.CalculateVisit(5);
        //op1.CalculateVisit(8);
        //Console.WriteLine($"InPatient ID: {ip1.PatientId}, Inpatient Name: {ip1.PatientName}, Total bill: {ip1.CalculateBillInPatient(8)} ");
        //Console.WriteLine($"InPatient ID: {ip2.PatientId}, Inpatient Name: {ip2.PatientName} Total bill: {ip2.CalculateBillInPatient(12)}");
        //Console.WriteLine($"OutPatient ID: {op1.PatientId}, OutPatient Name: {op1.PatientName} Total bill: {op1.CalculateVisit(5)}");
        //Console.WriteLine($"OutPatient ID: {op2.PatientId}, OutPatient Name: {op2.PatientName} Total bill: {op2.CalculateVisit(8)}");


        //InPatient[] arr;
        //InPatient[] inp = arr[];

        //for (int i = 1; i < arr.Length; i++)
        //{
        //    if (arr[i].CalculateBillInPatient() > highestbill.CalculateVisit())
        //    {
        //        highestbill = arr[i];
        //    }
        //    return highestbill;
        //}




        InPatient[] pi = new InPatient[]
        {
        new InPatient(122, "Alice"),
        new InPatient(145, "John"),
        };

        OutPatient[] po = new OutPatient[]
        {
        new OutPatient(342, "Bob"),
        new OutPatient(544, "Smith")
        };

        int daysAdmitted = 8;
        int perVisit = 3;

        Console.WriteLine("=== Hospital Management ===\n");

        foreach (InPatient ip in pi)
        {
            int d = ip.CalculateBillInPatient(daysAdmitted);

            Console.WriteLine(
                $"Member ID: {ip.PatientId}, " +
                $"Name: {ip.PatientName}, " +
                $"" +
                $"Per Day bill of {daysAdmitted} days is = {d} rupees"
            );
        }

        foreach (OutPatient op in po)
        {
            int per = op.CalculateVisit(perVisit);

            Console.WriteLine(
                $"Member ID: {op.PatientId}, " +
                $"Name: {op.PatientName}, " +
                $"" +
                $"Per Visit bill of {perVisit} visits is = {per} rupees"
            );
        }
    }
}