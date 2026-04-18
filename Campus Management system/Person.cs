//Code contributed by Tebogo
using System;
using System.Collections.Generic;
using System.Text;

namespace Campus_Management_system
{
    internal class Person
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        public Person(int id, string name, string email)
        {
            ID = id;
            Name = name;
            Email = email;
        }

        public virtual void DisplayDetails()
        {
            Console.WriteLine($"ID: {ID}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Email: {Email}");
        }
    }
}
