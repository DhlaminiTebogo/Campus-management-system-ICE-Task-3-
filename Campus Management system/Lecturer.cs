using System;
using System.Collections.Generic;
using System.Text;

namespace Campus_Management_system
{
    internal class Lecturer : Person
    {
        public string EmployeeId { get; set; }
        public string Department { get; set; }

        public Lecturer(int id, string name, string email, string employeeId, string department)
            : base(id, name, email)
        {
            EmployeeId = employeeId;
            Department = department;
        }

        public override void DisplayDetails()
        {
            Console.WriteLine($"ID: {ID}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Email: {Email}");
            Console.WriteLine($"Employee ID: {EmployeeId}");
            Console.WriteLine($" | Department: {Department}");
        }
    }
}
