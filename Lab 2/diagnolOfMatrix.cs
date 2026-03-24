using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter size of square matrix: ");
        int n = int.Parse(Console.ReadLine());

        int[,] matrix = new int[n, n];

        // Input matrix elements
        Console.WriteLine("Enter elements of matrix:");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                matrix[i, j] = int.Parse(Console.ReadLine());
            }
        }

        Console.WriteLine("Main diagonal elements:");
        for (int i = 0; i < n; i++)
        {
            Console.Write(matrix[i, i] + " ");
        }

    }
}