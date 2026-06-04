using System;

class MyException : Exception
{
    public MyException(string message) : base(message) { }
}

class Program
{
    static void Main()
    {
        try
        {
            Console.Write("Enter age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            if (age < 18)
                throw new MyException("Age must be 18 or above");

            Console.WriteLine("Valid Age");
        }
        catch (MyException e)
        {
            Console.WriteLine("Custom Exception: " + e.Message);
        }
    }
}