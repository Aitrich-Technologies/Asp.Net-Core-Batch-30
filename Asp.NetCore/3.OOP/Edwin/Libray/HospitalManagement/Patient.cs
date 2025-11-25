using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagement
{
    internal class Patient
    {
        private string name;
        private int age;
        private string disease;
        private string medicalHistory;
        

        public Patient(string Name, int Age, string Disease, string MedicalHistory)
        {
            name=Name;
            age=Age;
            disease=Disease;
            medicalHistory=MedicalHistory;
        }
        public void ShowPatientDetails()
        {
            Console.WriteLine("Patient Details:");
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Disease: " + disease);
            Console.WriteLine("Medical History: " + medicalHistory);
        }
    }
}
