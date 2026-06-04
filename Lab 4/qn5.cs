using System;

class Number
{
    public int value;

    public Number(int v)
    {
        value = v;
    }

    public static Number operator --(Number n)
    {
        n.value--;
        return n;
    }

    public void Display()
    {
        Console.WriteLine("Value = " + value);
    }
}

class Program
{
    static void Main()
    {
        Number n = new Number(10);

        Console.WriteLine("Before:");
        n.Display();

        --n;

        Console.WriteLine("After:");
        n.Display();
    }
}