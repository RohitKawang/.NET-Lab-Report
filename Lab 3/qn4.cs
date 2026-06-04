using System;

class Person
{
    protected string name;
    protected int age;

    public Person(string name, int age)
    {
        this.name = name;
        this.age = age;
    }

    public virtual void ShowInfo()
    {
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Age: " + age);
    }
}

class Student : Person
{
    string faculty;

    public Student(string name, int age, string faculty)
        : base(name, age)
    {
        this.faculty = faculty;
    }

    public override void ShowInfo()
    {
        base.ShowInfo();
        Console.WriteLine("Faculty: " + faculty);
    }
}

class Teacher : Person
{
    double salary;

    public Teacher(string name, int age, double salary)
        : base(name, age)
    {
        this.salary = salary;
    }

    public override void ShowInfo()
    {
        base.ShowInfo();
        Console.WriteLine("Salary: " + salary);
    }
}

class Program
{
    static void Main()
    {
        Student s = new Student("Rohit", 22, "BCA");
        Teacher t = new Teacher("Ram", 40, 50000);

        Console.WriteLine("Student Details:");
        s.ShowInfo();

        Console.WriteLine("\nTeacher Details:");
        t.ShowInfo();
    }
}