using System;
using System.Collections.Generic;
using System.Linq;

public class LinqTest
{
    static void Main()
    {
        List<string> names = new List<string>() { "Alice", "Bob", "Charlie" };
        List<string> address = new List<string>() { "Kathmandu", "Bhaktapur", "Lalitpur" };

        var result1 = names.Concat(address);
        var result2 = names.Union(address);

        foreach(var r in result1)
        {
            Console.WriteLine(r);
        }
    }
}