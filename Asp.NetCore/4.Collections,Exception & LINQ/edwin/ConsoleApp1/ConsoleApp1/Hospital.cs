using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Hospital
    {
        public int PatientId {  get; set; }
        public string Name { get; set; }
        public string Disease { get; set; }



        public Hospital(int patientId, string name, string disease)
        {
            PatientId = patientId;
            Name = name;
            Disease = disease;
        }

        public void ShowDetails()
        {
            Console.WriteLine($"ID: {PatientId}, Name: {Name}, Disease: {Disease}");
    }
        }

    }

