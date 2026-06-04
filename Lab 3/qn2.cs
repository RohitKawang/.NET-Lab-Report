using System;

class Employee
{
    public string Name { get; set; }
    public int Age { get; set; }
    public double Salary { get; set; }
}

class Program
{
    static void Main()
    {
        Employee emp = new Employee();

        emp.Name = "Rohit";
        emp.Age = 22;
        emp.Salary = 45000;

        Console.WriteLine("Name: " + emp.Name);
        Console.WriteLine("Age: " + emp.Age);
        Console.WriteLine("Salary: " + emp.Salary);
    }
}