using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter the size of array: ");
        int n = int.Parse(Console.ReadLine());

        int[] arr = new int[n];
        int sum = 0;

        Console.WriteLine("Enter " + n + " numbers:");

        for (int i = 0; i < n; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
            sum += arr[i];
        }

        Console.WriteLine("Sum = " + sum);
    }
}