using System;
using System.Collections.Generic;
using System.Text;

namespace Campus_Management_system
{
    internal class Student : Person
    {
        public string StudentNumber { get; set; }
        public string Course { get; set; }
        public double Marks { get; set; }

        public Student(int id, string name, string email, string studentNumber, string course, double marks)
            : base(id, name, email)
        {
            StudentNumber = studentNumber;
            Course = course;
            Marks = marks;
        }

        public override void DisplayDetails()
        {
            Console.WriteLine($"ID: {ID}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Email: {Email}");
            Console.WriteLine($"Student No: {StudentNumber}");
            Console.WriteLine($"Course: {Course}");
            Console.WriteLine($"Marks: {Marks}");
        }
    }
}
