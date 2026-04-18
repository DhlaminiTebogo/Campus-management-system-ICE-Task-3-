//Code contributed by Tebogo
using System;
using System.Collections.Generic;
using System.Text;

namespace Campus_Management_system
{
    internal class Student : Person
    {
        public string StudentNumber { get; set; }
        public List<string> Courses { get; set; } = new List<string>();
        public List<double> Marks { get; set; } = new List<double>();

        public Student(string name, string email, string studentNumber)
            : base(0, name, email)
        {
            StudentNumber = studentNumber;
        }

        public override void DisplayDetails()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Email: {Email}");
            Console.WriteLine($"Student No: {StudentNumber}");
            for (int i = 0; i < Courses.Count; i++)
            {
                Console.WriteLine($"  {Courses[i]}: {Marks[i]}%");
            }
        }
    }
}
