using System;
using System.Linq;
using System.Collections.Generic;

class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        Student[] students = new Student[]
        {
            new Student { Id = 1, Name = "Ram", Age = 20 },
            new Student { Id = 2, Name = "Hari", Age = 21 },
            new Student { Id = 3, Name = "Sita", Age = 22 },
            new Student { Id = 3, Name = "Rama", Age = 22 },
            new Student { Id = 3, Name = "Uma", Age = 18 },
        };

        //find all teenager students
        Student[] teenagerStudents = students.Where(s => s.Age > 12 && s.Age < 20).ToArray();
        foreach (Student t in teenagerStudents)
        {
            Console.WriteLine($"Id: {t.Id}, Name: {t.Name}, Age: {t.Age}");
        }

        //find the first student whose name is Hari
        Student hari = students.Where(s => s.Name == "Hari").FirstOrDefault();
        Console.WriteLine($"Id: {hari.Id}, Name: {hari.Name}, Age: {hari.Age}");
    }

}