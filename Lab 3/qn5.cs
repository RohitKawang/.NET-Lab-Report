using System;

abstract class Shape
{
    protected double dim1, dim2;

    public Shape(double dim1, double dim2)
    {
        this.dim1 = dim1;
        this.dim2 = dim2;
    }

    public abstract double Area();
}

class Rectangle : Shape
{
    public Rectangle(double l, double b) : base(l, b) { }

    public override double Area()
    {
        return dim1 * dim2;
    }
}

class Triangle : Shape
{
    public Triangle(double b, double h) : base(b, h) { }

    public override double Area()
    {
        return 0.5 * dim1 * dim2;
    }
}

class Program
{
    static void Main()
    {
        Shape r = new Rectangle(10, 5);
        Shape t = new Triangle(10, 5);

        Console.WriteLine("Rectangle Area: " + r.Area());
        Console.WriteLine("Triangle Area: " + t.Area());
    }
}