using System;

class RightPyra
{
    public static void Main()
    {
        Console.WriteLine("Enter the height of the pyramid:");
        int height = int.Parse(Console.ReadLine());

        for (int i = 1; i <= height; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write("* ");
            }
            Console.WriteLine();
        }

        Console.ReadLine();
    }
}