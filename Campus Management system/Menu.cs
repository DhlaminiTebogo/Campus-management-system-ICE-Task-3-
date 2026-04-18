// Code contributed by Tebogo, Zack and Sedi
using System;
using System.Collections.Generic;
using System.Text;

namespace Campus_Management_system
{
    internal class Menu
    {
        private Registration reg = new Registration();
        private Report report = new Report();

        public void Run()
        {
            bool running = true;

            while (running)
            {
                Console.Clear();
                Console.WriteLine("==============================");
                Console.WriteLine("  CAMPUS MANAGEMENT SYSTEM");
                Console.WriteLine("==============================");
                Console.WriteLine("  1. Register Student");
                Console.WriteLine("  2. Add Lecturer");
                Console.WriteLine("  3. Create Course");
                Console.WriteLine("  4. Assign Student to Course");
                Console.WriteLine("  5. Capture Marks");
                Console.WriteLine("  6. View Reports");
                Console.WriteLine("  0. Exit");
                Console.WriteLine("==============================");
                Console.Write("  Choice: ");

                string choice = Console.ReadLine();
                Console.WriteLine();

                switch (choice)
                {
                    case "1": RegisterStudent(); break;
                    case "2": AddLecturer(); break;
                    case "3": CreateCourse(); break;
                    case "4": AssignStudentToCourse(); break;
                    case "5": CaptureMarks(); break;
                    case "6": ViewReports(); break;
                    case "0": Console.WriteLine("  Goodbye!"); running = false; break;
                    default: Console.WriteLine("  ✗ Invalid option. Try again."); break;
                }

                if (running)
                {
                    Console.WriteLine("\n  Press any key to continue...");
                    Console.ReadKey();
                }
            }
        }

        // ── Option 1 ──────────────────────────
        private void RegisterStudent()
        {
            Console.WriteLine("──── Register Student ────");
            Console.Write("  Name          : "); string name = Console.ReadLine();
            Console.Write("  Email         : "); string email = Console.ReadLine();
            Console.Write("  Student Number: "); string num = Console.ReadLine();

            reg.RegisterStudent(name, email, num);
        }

        // ── Option 2 ──────────────────────────
        private void AddLecturer()
        {
            Console.WriteLine("──── Add Lecturer ────");
            Console.Write("  Name       : "); string name = Console.ReadLine();
            Console.Write("  Email      : "); string email = Console.ReadLine();
            Console.Write("  Employee ID: "); string empId = Console.ReadLine();
            Console.Write("  Department : "); string dept = Console.ReadLine();

            reg.AddLecturer(name, email, empId, dept);
        }

        // ── Option 3 ──────────────────────────
        private void CreateCourse()
        {
            Console.WriteLine("──── Create Course ────");
            Console.Write("  Course Name: "); string name = Console.ReadLine();

            reg.CreateCourse(name);
        }

        // ── Option 4 ──────────────────────────
        private void AssignStudentToCourse()
        {
            Console.WriteLine("──── Assign Student to Course ────");

            if (reg.Students.Count == 0) { Console.WriteLine("  ✗ No students registered."); return; }
            if (reg.Courses.Count == 0) { Console.WriteLine("  ✗ No courses available."); return; }

            Console.WriteLine("\n  Students:");
            for (int i = 0; i < reg.Students.Count; i++)
                Console.WriteLine($"    {i + 1}. {reg.Students[i].Name} ({reg.Students[i].StudentNumber})");

            Console.Write("  Select Student No: ");
            int sIndex = int.Parse(Console.ReadLine()) - 1;

            Console.WriteLine("\n  Courses:");
            for (int i = 0; i < reg.Courses.Count; i++)
                Console.WriteLine($"    {i + 1}. {reg.Courses[i]}");

            Console.Write("  Select Course No: ");
            int cIndex = int.Parse(Console.ReadLine()) - 1;

            if (sIndex >= 0 && sIndex < reg.Students.Count &&
                cIndex >= 0 && cIndex < reg.Courses.Count)
                reg.AssignCourse(sIndex, cIndex);
            else
                Console.WriteLine("  ✗ Invalid selection.");
        }

        // ── Option 5 ──────────────────────────
        private void CaptureMarks()
        {
            Console.WriteLine("──── Capture Marks ────");

            if (reg.Students.Count == 0) { Console.WriteLine("  ✗ No students registered."); return; }

            Console.WriteLine("\n  Students:");
            for (int i = 0; i < reg.Students.Count; i++)
                Console.WriteLine($"    {i + 1}. {reg.Students[i].Name}");

            Console.Write("  Select Student No: ");
            int sIndex = int.Parse(Console.ReadLine()) - 1;

            if (sIndex < 0 || sIndex >= reg.Students.Count) { Console.WriteLine("  ✗ Invalid selection."); return; }

            Student s = reg.Students[sIndex];

            if (s.Courses.Count == 0) { Console.WriteLine("  ✗ No courses assigned to this student."); return; }

            Console.WriteLine($"\n  Courses for {s.Name}:");
            for (int i = 0; i < s.Courses.Count; i++)
                Console.WriteLine($"    {i + 1}. {s.Courses[i]}");

            Console.Write("  Select Course No  : ");
            int cIndex = int.Parse(Console.ReadLine()) - 1;

            Console.Write("  Enter Mark (0-100): ");
            double mark = double.Parse(Console.ReadLine());

            if (cIndex >= 0 && cIndex < s.Courses.Count)
                reg.CaptureMark(sIndex, cIndex, mark);
            else
                Console.WriteLine("  ✗ Invalid selection.");
        }

        // ── Option 6 ──────────────────────────
        private void ViewReports()
        {
            Console.WriteLine("──── View Reports ────");
            Console.WriteLine("  1. All Students");
            Console.WriteLine("  2. Single Student");
            Console.Write("  Choice: ");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                report.GenerateAllReports(reg.Students);
            }
            else if (choice == "2")
            {
                if (reg.Students.Count == 0) { Console.WriteLine("  ✗ No students registered."); return; }

                Console.WriteLine("\n  Students:");
                for (int i = 0; i < reg.Students.Count; i++)
                    Console.WriteLine($"    {i + 1}. {reg.Students[i].Name}");

                Console.Write("  Select Student No: ");
                int sIndex = int.Parse(Console.ReadLine()) - 1;

                if (sIndex >= 0 && sIndex < reg.Students.Count)
                    report.GenerateReport(reg.Students[sIndex]);
                else
                    Console.WriteLine("  ✗ Invalid selection.");
            }
            else
            {
                Console.WriteLine("  ✗ Invalid option.");
            }
        }
    }
}
