using System;

class Program
{
    // Function to find maximum value in an array
    static int max(int[] arr)
    {
        int maxValue = arr[0];  // Assume first element is max

        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i] > maxValue)
            {
                maxValue = arr[i];  // Update maxValue
            }
        }

        return maxValue;
    }

    static void Main()
    {
        Console.Write("Enter number of elements: ");
        int n = int.Parse(Console.ReadLine());  // Using int.Parse

        int[] numbers = new int[n];

        Console.WriteLine("Enter elements:");
        for (int i = 0; i < n; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());  // Using int.Parse
        }

        int maximum = max(numbers); // Call function
        Console.WriteLine("Maximum value = " + maximum);
    }
}