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
            new Student { Name = "Ram", Age = 15, Address = "Kathmandu" },
            new Student { Name = "Shyam", Age = 22, Address = "Bhaktapur" },
            new Student { Name = "Hari", Age = 18, Address = "Lalitpur" },
            new Student { Name = "Sita", Age = 12, Address = "Pokhara" },
            new Student { Name = "Gita", Age = 19, Address = "Chitwan" }
        };

        var teenagers = students.Where(s => s.Age >= 13 && s.Age <= 19);

        Console.WriteLine("Teenage Students:");

        foreach (var student in teenagers)
        {
            Console.WriteLine($"Name: {student.Name}, Age: {student.Age}, Address: {student.Address}");
        }
    }
}