using System;
using System.Collections.Generic;
using System.Linq;

class Student
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string Address { get; set; }
}

class Program
{
    static void Main()
    {
        List<Student> students = new List<Student>()
        {
            new Student { Name = "Hari", Age = 18, Address = "Kathmandu" },
            new Student { Name = "Ram", Age = 20, Address = "Bhaktapur" },
            new Student { Name = "Shyam", Age = 22, Address = "Lalitpur" },
            new Student { Name = "Ram", Age = 19, Address = "Pokhara" }
        };

        Student student = students.FirstOrDefault(s => s.Name == "Ram");

        if (student != null)
        {
            Console.WriteLine("First student named Ram:");
            Console.WriteLine($"Name: {student.Name}");
            Console.WriteLine($"Age: {student.Age}");
            Console.WriteLine($"Address: {student.Address}");
        }
        else
        {
            Console.WriteLine("No student named Ram found.");
        }
    }
}