using Sysmtem;

class SumOfFirstNNatural
{
    public static void Main()
    {
        Console.WriteLine("Enter a number: ");
        int n = int.Parse(Console.ReadLine());

        int sum = n * (n + 1) / 2;
        Console.WriteLine("The sum of the first " + n + " natural numbers is: " + sum);

        Console.ReadLine();
    }
}