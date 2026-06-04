using System;

class Program
{
    static void Main()
    {
        try
        {
            int[] arr = { 10, 20, 30, 40, 50 };

            Console.Write("Enter index (0-4): ");
            int i = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Value = " + arr[i]);
        }
        catch (IndexOutOfRangeException)
        {
            Console.WriteLine("Error: Invalid index.");
        }
    }
}