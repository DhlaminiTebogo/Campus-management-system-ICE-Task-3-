using System;
using System.Collections.Generic;
using System.Text;

namespace Campus_Management_system
{
    internal class Class1
    {
    {
    public List<Student> students = new List<Student>();

    public void RegisterStudent()
    {
        Console.Write("Enter Name: ");
        string name = Console.ReadLine();

        Console.Write("Enter Email: ");
        string email = Console.ReadLine();

        Console.Write("Enter ID: ");
        string id = Console.ReadLine();

        Console.Write("Enter Student Number: ");
        string studentNumber = Console.ReadLine();

        Student student = new Student(name, email, id, studentNumber);

        Console.Write("Enter Course: ");
        student.Course = Console.ReadLine();

        Console.Write("Enter Marks: ");
        student.Marks = Convert.ToInt32(Console.ReadLine());

        students.Add(student);

        Console.WriteLine("Student registered successfully!\n");
    }

    public void ViewStudents()
    {
        foreach (var student in students)
        {
            student.DisplayInfo();
            Console.WriteLine("----------------------");
        }
    }

    public void GenerateReports()
    {
        foreach (var student in students)
        {
            Report.GenerateStudentReport(student);
        }
    }
    }
}
}
