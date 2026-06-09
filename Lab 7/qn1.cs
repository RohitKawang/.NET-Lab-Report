using System;
using System.Collections.Generic;
using System.Linq;

class Test
{
    static void Main()
    {
        //string collection of list
        List<string>CountryList = new List<string>();
          for (int i = 0; i < 5; i++)
        {
            Console.Write("Enter string: ");
            CountryList.Add(Console.ReadLine());
        }
        var result = countries.Where(c => c.StartsWith("N"));

        Console.WriteLine("Countries starting with 'N':");

        foreach (string country in result)
        {
            Console.WriteLine(country);
        }

        
    
    }
}