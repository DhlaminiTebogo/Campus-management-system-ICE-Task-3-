//Code contributed by Zack
using System;
using System.Collections.Generic;
using System.Text;

namespace Campus_Management_system
{
    internal class Report
    {
        public void GenerateAllReports(List<Student> students)
        {
            if (students.Count == 0) { Console.WriteLine("  ✗ No students registered."); return; }

            foreach (Student s in students)
                GenerateReport(s);
        }

        public void GenerateReport(Student s)
        {
            Console.WriteLine("\n==============================");
            Console.WriteLine("     STUDENT REPORT CARD");
            Console.WriteLine("==============================");
            s.DisplayDetails();
            Console.WriteLine("------------------------------");

            if (s.Courses.Count == 0)
            {
                Console.WriteLine("  No courses assigned.");
            }
            else
            {
                Console.WriteLine($"  {"Course",-20} {"Mark",6}");
                Console.WriteLine("------------------------------");

                for (int i = 0; i < s.Courses.Count; i++)
                    Console.WriteLine($"  {s.Courses[i],-20} {s.Marks[i],5}%");

                double avg = s.Marks.Average();
                string status = avg >= 75 ? "Distinction" :
                                avg >= 60 ? "Pass with Merit" :
                                avg >= 50 ? "Pass" : "Fail";

                Console.WriteLine("------------------------------");
                Console.WriteLine($"  Average : {avg:F2}%");
                Console.WriteLine($"  Highest : {s.Marks.Max():F2}%");
                Console.WriteLine($"  Status  : {status}");
            }
            Console.WriteLine("==============================");
        }
    }
}
