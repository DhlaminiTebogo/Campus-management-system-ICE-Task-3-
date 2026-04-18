//Code contributed by Sedi
using System;
using System.Collections.Generic;
using System.Text;

namespace Campus_Management_system
{
    internal class Registration
    {
        public List<Student> Students = new List<Student>();
        public List<Lecturer> Lecturers = new List<Lecturer>();
        public List<string> Courses = new List<string>();

        public void RegisterStudent(string name, string email, string studentNumber)
        {
            Students.Add(new Student(name, email, studentNumber));
            Console.WriteLine($"\n   Student {name} registered!");
        }

        public void AddLecturer(string name, string email, string employeeId, string department)
        {
            Lecturers.Add(new Lecturer(name, email, employeeId, department));
            Console.WriteLine($"\n   Lecturer {name} added!");
        }

        public void CreateCourse(string courseName)
        {
            Courses.Add(courseName);
            Console.WriteLine($"\n Course '{courseName}' created!");
        }

        public void AssignCourse(int studentIndex, int courseIndex)
        {
            Student s = Students[studentIndex];
            string c = Courses[courseIndex];
            s.Courses.Add(c);
            s.Marks.Add(0.0);
            Console.WriteLine($"\n {c} assigned to {s.Name}!");
        }

        public void CaptureMark(int studentIndex, int courseIndex, double mark)
        {
            Student s = Students[studentIndex];
            if (mark < 0 || mark > 100)
            {
                Console.WriteLine(" Invalid mark. Must be between 0 and 100.");
                return;
            }
            s.Marks[courseIndex] = mark;
            Console.WriteLine($"\n Mark of {mark}% captured for {s.Courses[courseIndex]}!");
        }
    }
}
