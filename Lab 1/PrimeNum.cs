using System;

class PrimeNum
{
    public static void Main()
    {
        int i;
        for(i=100;i<200;i++)
        {
            int count=0;
            for(int j=2;j<i;j++)
            {
                if(i%j==0)
                {
                    count++;
                    break;
                }
            }
            if(count==0)
            {
                Console.Write(i+" ");
            }
        }
    }
}
