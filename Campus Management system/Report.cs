using System;
using System.Collections.Generic;
using System.Text;

namespace Campus_Management_system
{
    internal class Class1
    {
      public static void GenerateStudentReport (Student student) 
      {
          Console.WriteLine("\n-------------Student Report-------------");

          Console.WriteLine($"Name: {student.Name}");
          Console.WriteLine($"Student Number: {student.StudentNumber}");
          Console.WriteLine($"Course: {student.Course}");
          Console.WriteLine($"Marks: {student.Marks}");

          if (student.Marks > 50)
          {
              Console.WriteLine("Status: Passed")
          }
          else
          {
              Console.WriteLine("Status: Failed")
          }

          Console.WriteLine("--------------------------------------------\n")
      }
    }
}
