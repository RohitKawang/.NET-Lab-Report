using System;
using System.Collections.Generic;
using System.Linq;

class Test
{
    static void Main()
    {
        //string collection of list
        List<int>numberList = new List<int>(){1,2,3,4,5};

        List<int>evenList = numberList.FindAll(x=>(x%2)==0);

        foreach(int value in evenList)
        {
            Console.WriteLine(value);
        }

        List<int>oddList = numberList.Where(n => n % 2 != 0).ToList();

        foreach(int value in oddList)
        {
            Console.WriteLine(value);
        }
    
    }
}