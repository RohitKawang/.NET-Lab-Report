using System;

// 1. The Employee Class
public class Employee
{
    // Properties
    public string Name { get; set; }
    public int Age { get; set; }
    public double Salary { get; set; }

    // Method to display details
    public void DisplayDetails()
    {
        Console.WriteLine("--- Employee Details ---");
        Console.WriteLine($"Name:   {Name}");
        Console.WriteLine($"Age:    {Age}");
        Console.WriteLine($"Salary: ${Salary:N2}");
    }
}

// 2. The Test Class
class Program
{
    static void Main(string[] args)
    {
        // Create the employee object
        Employee emp = new Employee();

        // Set the details
        emp.Name = "Rohit Kawan";
        emp.Age = 23;
        emp.Salary = 35000;

        // Display the details
        emp.DisplayDetails();

        // Keep console open
        Console.ReadLine();
    }
}
