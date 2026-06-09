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
            new Student { Name = "Ram", Age = 20, Address = "Kathmandu" },
            new Student { Name = "Sita", Age = 17, Address = "Bhaktapur" },
            new Student { Name = "Hari", Age = 22, Address = "Lalitpur" },
            new Student { Name = "Gita", Age = 19, Address = "Pokhara" }
        };

        var sortedStudents = students.OrderBy(s => s.Age);

        Console.WriteLine("Students sorted by age (ascending):");

        foreach (var s in sortedStudents)
        {
            Console.WriteLine($"Name: {s.Name}, Age: {s.Age}, Address: {s.Address}");
        }
    }
}