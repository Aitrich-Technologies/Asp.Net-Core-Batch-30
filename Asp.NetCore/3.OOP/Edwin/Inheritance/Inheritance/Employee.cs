using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Employee:Person
    {
        public int? Id { get; set; }
        public string? Position { get; set; }

        public string GetEmployee()
        {
           

            return $"ID:{Id} FullName:{FirstName} {LastName} Position:{Position} Age:{Age}";

        }

        public Employee() : base()
        {
            Id = 001;
            Position = "Java Developer";
        }

        public Employee(string firstName, string lastName, int age, int id, string position) : base(firstName, lastName, age)

        {

            Id = id;
            Position = position;

        }

    }
    }

