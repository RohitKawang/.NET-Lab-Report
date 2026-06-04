using System;

class Area
{
    double length, breadth;

    public Area(double length, double breadth)
    {
        this.length = length;
        this.breadth = breadth;
    }

    public double GetArea()
    {
        return length * breadth;
    }
}

class Program
{
    static void Main()
    {
        Console.Write("Enter length: ");
        double l = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter breadth: ");
        double b = Convert.ToDouble(Console.ReadLine());

        Area rect = new Area(l, b);

        Console.WriteLine("Area = " + rect.GetArea());
    }
}