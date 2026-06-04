using System;

class Employee
{
    private string name;
    private int age;
    private double salary;

    // Getters and Setters
    public void SetName(string name) { this.name = name; }
    public string GetName() { return name; }

    public void SetAge(int age) { this.age = age; }
    public int GetAge() { return age; }

    public void SetSalary(double salary) { this.salary = salary; }
    public double GetSalary() { return salary; }
}

class Program
{
    static void Main()
    {
        Employee emp = new Employee();

        emp.SetName("Rohit");
        emp.SetAge(22);
        emp.SetSalary(45000);

        Console.WriteLine("Name: " + emp.GetName());
        Console.WriteLine("Age: " + emp.GetAge());
        Console.WriteLine("Salary: " + emp.GetSalary());
    }
}