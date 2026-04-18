//Code contributed by Tebogo
using System;
using System.Collections.Generic;
using System.Text;

namespace Campus_Management_system
{
    internal class Lecturer : Person
    {
        public string EmployeeId { get; set; }
        public string Department { get; set; }

        public Lecturer(string name, string email, string employeeId, string department)
            : base(0, name, email)
        {
            EmployeeId = employeeId;
            Department = department;
        }

        public override void DisplayDetails()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Email: {Email}");
            Console.WriteLine($"Employee ID: {EmployeeId}");
            Console.WriteLine($"Department: {Department}");
        }
    }
}
