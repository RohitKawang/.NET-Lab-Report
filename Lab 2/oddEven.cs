using System;

class Program
{
    // Function to check odd or even
    static void check(int n)
    {
        if (n % 2 == 0)
        {
            Console.WriteLine(n + " is Even");
        }
        else
        {
            Console.WriteLine(n + " is Odd");
        }
    }

    static void Main()
    {
        Console.Write("Enter a number: ");
        int num = int.Parse(Console.ReadLine());

        check(num);  // Call the function
    }
}