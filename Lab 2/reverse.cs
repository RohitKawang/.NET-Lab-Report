using System;

class Program
{
    // Function to reverse a number
    static int reverse(int n)
    {
        int rev = 0;
        while (n != 0)
        {
            int digit = n % 10;   // Get last digit
            rev = rev * 10 + digit;  // Add digit to reversed number
            n = n / 10;           // Remove last digit
        }
        return rev;
    }

    static void Main()
    {
        Console.Write("Enter a number: ");
        int num = int.Parse(Console.ReadLine());

        int reversedNum = reverse(num); // Call the function
        Console.WriteLine("Reversed number: " + reversedNum);
    }
}