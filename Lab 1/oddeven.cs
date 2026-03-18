using System;

class OddEven
{
    public static void Main()
    {
        Console.WriteLine("Enter a number: ");
        int num = int.Parse(Console.ReadLine());

        if (num % 2 == 0)
        {
            Console.WriteLine("The number is even.");
        }
        else
        {
            Console.WriteLine("The number is odd.");
        }

        Console.ReadLine();
    }
}