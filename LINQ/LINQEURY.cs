using System;
using System.Collections.Generic;
using System.Linq;

class Test
{
    static void Main()
    {
        //string collection of list
        List<string>stringList = new List<string>(){"c#","java","python","c++","ruby"};

        var result = from s in stringList 
                      where s.Contains("c") 
                        select s;

        var result = stringList.Where(s => s.Contains("c"));

       foreach(string value in result)
        {
            Console.WriteLine(value);
        }
    
    }
}