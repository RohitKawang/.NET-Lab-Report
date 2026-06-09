using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<string> countries = new List<string>()
        {
            "Nepal",
            "India",
            "China",
            "Bhutan",
            "Japan"
        };

        var result = countries.Where(c =>
                        c.ToLower().Contains("a") ||
                        c.ToLower().Contains("i"));

        Console.WriteLine("Countries containing 'a' or 'i':");

        foreach (var country in result)
        {
            Console.WriteLine(country);
        }
    }
}