using System;

class NumBet
{
    public static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());

        Console.WriteLine("The numbers between "+a+" and "+b+" are:");
        for (int i = a + 1; i < b; i++)
        {
            Console.WriteLine(i);
        }
        Console.ReadLine(); 
    }
}