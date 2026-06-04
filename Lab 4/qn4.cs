using System;

class Time
{
    public int hr, min, sec;

    public Time(int h, int m, int s)
    {
        hr = h;
        min = m;
        sec = s;
    }

    public static Time operator +(Time t1, Time t2)
    {
        int s = t1.sec + t2.sec;
        int m = t1.min + t2.min + s / 60;
        int h = t1.hr + t2.hr + m / 60;

        s %= 60;
        m %= 60;

        return new Time(h, m, s);
    }

    public void Display()
    {
        Console.WriteLine(hr + ":" + min + ":" + sec);
    }
}

class Program
{
    static void Main()
    {
        Time t1 = new Time(2, 50, 40);
        Time t2 = new Time(1, 20, 30);

        Time t3 = t1 + t2;

        t3.Display();
    }
}